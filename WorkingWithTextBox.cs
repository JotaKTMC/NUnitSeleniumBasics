using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LearningSelenium
{
    public class WorkingWithTextBox
    {
        // Selenium components
        IWebDriver Driver;
        
        [SetUp] 
        //Attribute NUnit measns this will be excecuted previous to our testing
        public void Setup()
        {
            // Initialize and config Selenium
            Driver = new ChromeDriver();
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Manage().Window.Maximize(); // Full screen
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Url = "https://test.qatechhub.com/contact-us/";
        }

        [Test]
        public void VerifyContactUsFormFill()
        {
            Driver.FindElement(By.id("wpforms-20-field_0"));
            string expectedTitle= "Test QA Tech Hub – Learning By Doing is the best way to learn!";
            string currentTitle= Driver.Title;
            Assert.AreEqual(expectedTitle,currentTitle);
        }

        [TearDown] 
        // Finish Testing
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}