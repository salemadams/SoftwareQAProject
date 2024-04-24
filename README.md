# KSU SWE 3643 Software Testing and Quality Assurance Semester Project: Web-Based Calculator

This repository contains both all the source code required for the Blazor Web App, as well as the internal calculator logic to perform its primary functions. Along with the core functionality, there is a Unit Testing project and a End-to-End testing project. These projects are using NUnit and Playwright respectively. 
## Table of Contents
- [Environment](#environment) 
- [Executing the Web Application](#executing-the-web-application) 
- [Executing Unit Tests](#executing-unit-tests) 
- [Reviewing Unit Test Coverage](#reviewing-unit-test-coverage) 
- [Executing End-to-End Tests](#executing-end-to-end-tests) 
- [Static Analysis](#static-analysis) 
- [Video Presentation](#video-presentation)
### Team Members
- Salem Adams
### Architecture
There are four projects within the general solution folder; CalculatorEngine, CalculatorWebServerApp, CalculatorEngineUnitTests, and CalculatorEndToEndTests. The structure of relationships between each of these enforces single responsibility and avoids unnecessary references. There are two references to the CalculatorEngine module, which are the CalculatorWebServerApp and the CalculatorEngineUnitTests. There are no references made to the WebServerApp as well as the CalculatorEndToEndTests. 
![UMLDiagram](https://github.com/salemadams/SoftwareQAProject/assets/131697693/b0185a97-2fb8-49dc-88c0-1ea0b4bbed04)

## Environment
This is a cross platform application that should be available on Windows 10+, Mac OSx Ventura+, and Linux Environments. However, this application has only been tested on Mac OSx Ventura and Windows 11. 

To prepare your environment to execute this application:
1. Install .NET SDK 8.0 on your system (https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
2. Ensure the ASP.NET Core runtime is installed. This is typically part of the SDK but it can be installed separately if needed. 

To configure your environment for NUnit testing:
- Install NUnit from (https://nunit.org/) or use a package manager such as NuGet (https://www.nuget.org/packages?q=Nunit) to install it. 

To configure your environment for Playwright testing:
1. Install PowerShell 7 for your respective OS (https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell-on-windows?view=powershell-7.4).
2. Execute the command `dotnet tool install --global Microsoft.Playwright.CLI` in the terminal.
3. Using the terminal command `cd`, navigate to the **CalculatorEndToEndTests** folder. Then execute the command `playwright install`.
## Executing the Web Application
To execute and launch the Web Application:
1. Open your terminal and navigate to the solutions installation using the `cd` command.
2. When inside the solution folder, navigate to **CalculatorWebServerApp**
3. Use the command `dotnet run` to launch the web server
4. The terminal should have an output similar to this: 
![WebAppPortData](https://github.com/salemadams/SoftwareQAProject/assets/131697693/ae13a762-34ed-4644-869c-7d77ce910b4f)
5. Copy the url in the build output (in this case its `https://localhost:5000`) and paste it into your browser to connect to the web application. 

## Executing Unit Tests
To execute unit tests for this solution:
1. Ensure that you currently have .NET SDK 8.0 installed, this can be done by typing `dotnet --list-sdks` in the terminal. This command will show the currently installed SDKs. 
2. Staying in the console, type in `dotnet test ProjectInstallationPath\SoftwareQAProject\CalculatorEngineUnitTests\bin\Debug\net8.0\CalculatorEngineTests.dll` and press enter. 
3. This should execute all 21 available unit tests. The output should look like: 
   `Starting test execution, please wait...
   `A total of 1 test files matched the specified pattern.
   `Passed!  - Failed:     0, Passed:    21, Skipped:     0, Total:    21, Duration: 12 ms - CalculatorEngineUnitTests.dll (net8.0)`
## Reviewing Unit Test Coverage
With every unit test executed successfully, 100% coverage of the CalculatorEngine project is achieved. 
![CalcEngineCoverage](https://github.com/salemadams/SoftwareQAProject/assets/131697693/7d4d4d88-f296-4679-b34b-320e19c1cc37)

## Executing End-to-End Tests
To execute playwright tests for this solution:
1. Ensure that you currently have .NET SDK 8.0 installed, this can be done by typing `dotnet --list-sdks` in the terminal. This command will show the currently installed SDKs. 
2. Staying in the console, type in `dotnet test ProjectInstallationPath\SoftwareQAProject\CalculatorEngineUnitTests\bin\Debug\net8.0\CalculatorEndToEndTests.dll` and press enter. 
3. This should execute all 5 available playwright tests. The output should look like:
   `Starting test execution, please wait...
   `A total of 1 test files matched the specified pattern.
   `Passed!  - Failed:     0, Passed:     5, Skipped:     0, Total:     5, Duration: 2 s - CalculatorEndToEndTests.dll (net8.0)
## Static Analysis


## Video Presentation
