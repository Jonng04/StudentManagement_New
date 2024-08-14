# Introduction
## Student Management System
This project is a web-based system developed using C#. It allows administrators to manage students, teachers, and courses.

## Features
Manage student and teacher records
Course assignments and tracking
User authentication and role-based access control


## Prerequisites
- Before setting up the project, ensure you have the following installed:
- .NET Core SDK (8.)
- MySQL
- Visual Studio Code or another C# compatible IDE

# Setup Instructions

## Package
Install Required Packages
- `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`
- `dotnet add package Microsoft.EntityFrameworkCore.Tools`

## Configure the Database Connection
Edit `appsettings.json`

## Run Migrations
To apply the initial database schema, run the following command
- `dotnet tool install --global dotnet-ef`
- `dotnet ef migrations add InitialCreate`
- `dotnet ef database update`

## Run the Application
Start the application using the following command
`dotnet run`

