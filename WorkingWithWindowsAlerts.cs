using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace LearningSelenium
{
    public class WorkingWithWindowsAlerts
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
            Driver.Url = "https://test.qatechhub.com/alert-handling/";
        }

        [Test]
        public void VerifyAlerts()
        {
            // Normal Alert
            Driver.FindElement(By.Id("NormalAlert")).Click();
            Thread.Sleep(5000);
            IAlert alert1= Driver.SwitchTo().Alert();
            Console.Write("Alert message"+alert1.Text);
            alert1.Accept();
        }

        [TearDown] 
        // Finish Testing
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}