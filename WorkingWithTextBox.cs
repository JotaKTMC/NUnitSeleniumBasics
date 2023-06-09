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
            Driver.FindElement(By.Id("wpforms-20-field_0")).SendKeys("Jota");
            Driver.FindElement(By.Name("wpforms[fields][0][last]")).SendKeys("Aguirre");
            Driver.FindElement(By.Id("wpforms-20-field_1")).SendKeys("jota@gmail.com");
            Driver.FindElement(By.Id("wpforms-20-field_2")).SendKeys("Comment");
            Driver.FindElement(By.Name("wpforms[submit]")).Click();
            
            string expectedMessage= "Thanks for contacting us! We will be in touch with you shortly.";
            string currentMesssage=Driver.FindElement(By.Id("wpforms-confirmation-20")).Text;
            Assert.AreEqual(expectedMessage,currentMesssage);
        }

        [TearDown] 
        // Finish Testing
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}