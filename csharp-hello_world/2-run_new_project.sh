#!/usr/bin/env bash

# Create a new directory for the project
mkdir 2-new_project

# Change the working directory to the newly created project folder
cd 2-new_project

# Initialize a new C# console application project using dotnet
dotnet new console

# Build the C# project
dotnet build

# Run the C# project
dotnet run

# Display a success message
echo "The C# project was successfully initialized, built, and run."

