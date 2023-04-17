# technical-test-invoicecloud

InvoiceCloudAssessment Automation Tests:
This project contains automated tests for the add/remove elements page using .NET Framework v4.7.2, C#, Selenium WebDriver for ChromeDriver, MSTest framework, 
and Visual Studio IDE. It also includes a YAML file to run the tests and generate test reports using GitHub Actions.

Prerequisites:
To run this project, you need to have the following software installed on your machine:

Visual Studio IDE
.NET Framework v4.7.2
ChromeDriver
Chrome browser

Running the Tests Locally:
To run the tests locally, follow these steps:

Clone the repository to your local machine
Open the solution file (InvoiceCloudAssessment.sln) in Visual Studio IDE
Build the solution to restore NuGet packages and compile the code
Run the tests using Test Explorer or by pressing Ctrl + R, A keyboard shortcut

Running the Tests with GitHub Actions:
This project includes a YAML file (test-report.yml) to run the tests and generate test reports using GitHub Actions. To use GitHub Actions, follow these steps:

Fork this repository
Navigate to the Actions tab on your forked repository
Click on the "New workflow" button and select "Set up a workflow yourself"
Copy the contents of the test-report.yml file to the editor
Save the changes to the YAML file and commit them to the repository
Wait for the workflow to complete to see the test results

Test Results:
The test results are generated in the .trx format and stored as a build artifact. You can view the test results locally by opening the .trx file in Visual Studio 
or by using an online test results viewer like trx2html. In addition, the test results are also displayed on the Actions tab of the GitHub repository.

Author:
This project was created by Ekta Deshmukh. If you have any questions or comments, please feel free to contact me.
