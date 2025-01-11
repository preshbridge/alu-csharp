#!/usr/bin/env bash
# Initialize a new .NET project using .NET 7.0

echo "Creating project with .NET 7.0..."
dotnet new console -o 0-new_project

# Check if the project folder was created
if [ -d "0-new_project" ]; then
    echo "Project created successfully. Files:"
    ls -la 0-new_project
else
    echo "Failed to create the project."
fi
