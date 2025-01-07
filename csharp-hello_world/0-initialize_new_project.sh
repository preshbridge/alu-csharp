#!/bin/bash

# Initialize a new C# Console Application project
dotnet new console -n 0-new_project

# Navigate into the newly created project directory
cd 0-new_project

# Restore the required packages
dotnet restore

# Display success message
echo "The new C# project has been created and packages restored successfully."
