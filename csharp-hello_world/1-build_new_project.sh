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

echo "Creating a new project: $PROJECT_NAME"

# Step 1: Create project directory
mkdir -p $PROJECT_NAME
cd $PROJECT_NAME

# Step 2: Initialize a Git repository
echo "Initializing a Git repository..."
git init

# Step 3: Set up a virtual environment (for Python projects)
echo "Setting up a Python virtual environment..."
python3 -m venv venv
echo "Virtual environment created. Activate it using 'source venv/bin/activate'."

# Step 4: Create a basic project structure
echo "Creating project structure..."
mkdir src tests
touch src/__init__.py
touch tests/__init__.py
echo "# $PROJECT_NAME" > README.md
echo "Project structure created."

# Step 5: Create a requirements.txt file
echo "Creating requirements.txt..."
touch requirements.txt
echo "# Add your project dependencies here" > requirements.txt

# Step 6: Create a .gitignore file
echo "Creating .gitignore..."
cat <<EOL > .gitignore
# Virtual environment
venv/

# Python cache files
__pycache__/
*.pyc
*.pyo

# Other common ignores
.DS_Store
.env
EOL

# Step 7: Initialize a basic main script
echo "Initializing main script..."
cat <<EOL > src/main.py
def main():
    print("Welcome to $PROJECT_NAME!")

if __name__ == "__main__":
    main()
EOL

# Final step: Git commit
echo "Making the initial commit..."
git add .
git commit -m "Initial project setup"

echo "Project $PROJECT_NAME has been successfully created!"
