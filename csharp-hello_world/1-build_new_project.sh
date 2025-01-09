#!/usr/bin/env bash

# Exit immediately if a command exits with a non-zero status.
set -e

# Function to display usage information
usage() {
    echo "Usage: $0 [project_name]"
    exit 1
}

# Check if a project name was provided
if [ -z "$1" ]; then
    echo "Error: No project name provided."
    usage
fi

PROJECT_NAME=$1

echo "Creating a new .NET project: $PROJECT_NAME"

# Step 1: Create the project folder
mkdir -p $PROJECT_NAME
cd $PROJECT_NAME

# Step 2: Create a new .NET project
echo "Initializing a new .NET console application..."
dotnet new console -n $PROJECT_NAME

# Step 3: Move into the .NET project folder
cd $PROJECT_NAME

# Step 4: Set up Git (optional)
if command -v git &>/dev/null; then
    echo "Initializing a Git repository..."
    git init
    echo "# $PROJECT_NAME" > README.md
    cat <<EOL > .gitignore
# Ignore build directories
bin/
obj/

# User-specific files
*.user
*.suo
*.rsuser
.vscode/

# Logs
*.log
EOL
    git add .
    git commit -m "Initial project setup with .NET"
else
    echo "Git not installed. Skipping Git initialization."
fi

# Step 5: Restore project dependencies
echo "Restoring project dependencies..."
dotnet restore

# Step 6: Build the project
echo "Building the project..."
dotnet build

echo "Project $PROJECT_NAME has been successfully created!"
