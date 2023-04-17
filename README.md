# technical-test-invoicecloud

**InvoiceCloudAssessment Automation Tests:**
This project contains automated tests for the add/remove elements page using .NET Framework v4.7.2, C#, Selenium WebDriver for ChromeDriver, MSTest framework, 
and Visual Studio IDE. It also includes a YAML file to run the tests and generate test reports using GitHub Actions.

**Prerequisites:**
To run this project, you need to have the following software installed on your machine:

1. Visual Studio IDE
2. dotnet Framework v4.7.2
3. ChromeDriver 
4. Chrome browser

**Running the Tests Locally:**
To run the tests locally, follow these steps:

1. Clone the repository to your local machine 
2. Open the solution file (InvoiceCloudAssessment.sln) in Visual Studio IDE
3. Build the solution to restore NuGet packages and compile the code
4. Run the tests using Test Explorer or by pressing Ctrl + R, A keyboard shortcut

**Running the Tests with GitHub Actions:**
This project includes a YAML file (test-report.yml) to run the tests and generate test reports using GitHub Actions. To use GitHub Actions, follow these steps:

1. Fork this repository
2. Navigate to the Actions tab on your forked repository
3. Click on the "New workflow" button and select "Set up a workflow yourself"
4. Copy the contents of the testReport.yml file to the editor
5. Save the changes to the YAML file and commit them to the repository
6. Wait for the workflow to complete to see the test results

**Test Results:**
The test results are generated in the .trx format and stored as a build artifact. You can view the test results locally by opening the .trx file in Visual Studio 
or by using an online test results viewer like trx2html. In addition, the test results are also displayed on the Actions tab of the GitHub repository.

**Author:**
This project was created by Ekta Deshmukh. If you have any questions or comments, please feel free to contact me.
