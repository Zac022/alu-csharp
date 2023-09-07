#!/usr/bin/env bash

# Check if the 'dotnet' command is available
if ! command -v dotnet &> /dev/null
then
    echo "Error: 'dotnet' command not found. Please install the .NET SDK."
    exit 1
fi

# Create a new directory for the project
mkdir 0-new_project

# Change the working directory to the newly created project folder
cd 0-new_project

# Initialize a new C# console application project using dotnet
dotnet new console

# Display a success message
echo "The template 'Console Application' was created successfully."

