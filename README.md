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

![diagram][https://www.plantuml.com/plantuml/svg/ZPHRRze-5C2VoQUmsfUW_n_jVPgcKg1gfGsoahRRL2aozcbgpTZPiSrbLR_x4ahgfCIiF138-PtxvSnOYjOjPKIbrEkbs0YLHr51sI-Q0paPKIQTf5RZHEL20KdsaWzaIfTWIX1EoAaK-QFD4K15Jr6FIMeC6L79cgfHhnJr_YD3pcF2jLj889l_wr_R_lrEEdSBYvJPBeJqTyXN9wqevFO8CXOhmU48CFdjg3H7W4Il0O_8l-ZyYFHQws06E-22CgjHKEcflUfSg8Dt8sqEtgNqaBi69WhKxAtPv-YvqLFV6B9lweqIbgHWh24hGNT_wwPkePgBS5ShTgVPQ6-MhlM5rDGAbITQA6koQx0EbPcxPTnlzJdCZiN30o0e1d6xxs6L13LtpCRD8GZJtvos0jGR_2UWhea9eiQuEJ7PR0KugGgJ831XX5OrF5FGHcyK3x6LaxWnQDdtLF_epg8Sj70AaqsX5QWcEuMy15VGKcWdvE5pQY2KS3N3OS-Lj0dE7hhij6SzcshrnrFjH3tcRVcw7X1rcbsHpuNAhjGOSWJm0LCkg3BnwqRz2qdfKIljVSiwo-tb1mg1WlMUgmCHN38o67m-FApbTdUlznqio1nm1KY6HL6lz48w85qRFQQMlhxLogAM4j14PFzvaTmAM9ke2jCpFZ1lAIZtWTU6tu8x5y6i9eeFKZqe7usRbKYwNMEPthik5qzrzTMyMrvSLkr6P4dfDXLMGdPbl2pkTy93pgTkkG0q9Lqk9J0BVEPiuMn0u-NQd6yxXY3auKxOnnGszftuKF6H18gtL3hm5sDPsEtSeb2v7xVkobIjQBNc8xbCqwJo9QkQtojo2PHBC8QSeruRmAfdJ6h7oUbB-SbJHCYZu42OG2OXggUeLjW_oQSZpaghPw2uMyg_]

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
4. The terminal should have an output similar to this: ![[Screenshot 2024-04-22 at 6.27.44 PM.png]]
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

![[Screenshot 2024-04-22 at 11.30.37 PM.png]]

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