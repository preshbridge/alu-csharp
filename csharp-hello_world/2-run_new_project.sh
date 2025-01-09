#!/usr/bin/env bash
# this is gonna initialize a new project

dotnet new console -o 2-new_project
dotnet build "2-new_project"
dotnet run --project "2-new_project"
