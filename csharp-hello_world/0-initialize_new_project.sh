#!/bin/bash

# Create a folder titled 0-new_project
mkdir -p 0-new_project

# Navigate into the folder
cd 0-new_project || exit

# Initialize a new C# project
dotnet new console

# Return to the original directory
cd ..
