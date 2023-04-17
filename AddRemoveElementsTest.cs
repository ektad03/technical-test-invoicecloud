using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace InvoiceCloudAssessment
{
    /// <summary>
    ///  This test case adds 'n' number of elements and asserts that 'n' number of elements exist on the page.
    /// </summary>
    [TestClass]
    public class AddRemoveElementsTest
    {
        private IWebDriver driver;

        [TestInitialize]
        public void TestSetup()
        {
            // Set up the ChromeDriver instance
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void AddNElementsAndAssertCount()
        {
            // Navigate to the add/remove elements page
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/add_remove_elements/");

            // Add n number of elements
            int n = 5; // Replace with desired number of elements
            for (int i = 0; i < n; i++)
            {
                driver.FindElement(By.XPath("//button[text()='Add Element']")).Click();
            }

            // Assert that n number of elements exist on the page
            int actualCount = driver.FindElements(By.XPath("//button[text()='Delete']")).Count;
            Assert.AreEqual(n, actualCount, $"Expected {n} elements, but found {actualCount} elements.");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Clean up the ChromeDriver instance
            driver.Quit();
        }
    }
}
