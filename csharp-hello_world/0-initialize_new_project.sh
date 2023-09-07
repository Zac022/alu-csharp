#!/usr/bin/env bash

# Create a new directory for the project
mkdir 0-new_project

# Change the working directory to the newly created project folder
cd 0-new_project

# Initialize a new C# console application project using dotnet
dotnet new console

# Display a success message
echo "The template 'Console Application' was created successfully."

