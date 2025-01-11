#!/usr/bin/env bash

# Create a new directory named 1-new_project
mkdir -p 1-new_project

# Navigate into the 1-new_project directory
cd 1-new_project

# Initialize a new C# console project
dotnet new console

# Build the C# project
dotnet build