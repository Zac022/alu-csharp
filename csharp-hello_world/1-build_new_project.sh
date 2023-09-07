#!/usr/bin/env bash

# Create a new directory for the project
mkdir 1-new_project

# Change the working directory to the newly created project folder
cd 1-new_project

# Initialize a new C# console application project using dotnet
dotnet new console

# Build the C# project
dotnet build

# Display a success message
echo "The C# project was successfully initialized and built."

