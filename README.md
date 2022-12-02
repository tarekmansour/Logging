# Logging
Demonstrate Logging into text file and Azure

## Getting started

0. Install [.NET 6 SDK](https://download.visualstudio.microsoft.com/download/pr/08ada4db-1e64-4829-b36d-5beb71f67bff/b77050cf7e0c71d3b95418651db1a9b8/dotnet-sdk-6.0.403-win-x64.exe)
1. Clone the project
2. Create empty database on SQL SERVER called `MyApplicationDb`
3. Install [Dotnet ef tool](https://learn.microsoft.com/en-us/ef/core/get-started/overview/install)
  - or run `dotnet tool install --global dotnet-ef`
3. Update db with migrations: `dotnet ef database update`
