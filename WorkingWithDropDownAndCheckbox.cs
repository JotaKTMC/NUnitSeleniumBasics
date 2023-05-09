using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace LearningSelenium
{
    public class WorkingWithDropDownAndCheckbox
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
            Driver.Url = "https://test.qatechhub.com/drag-and-drop/";
        }

        [Test]
        public void VerifyFormFill()
        {
            Driver.FindElement(By.Id("wpforms-49-field_1")).SendKeys("Jota");
            Driver.FindElement(By.Name("wpforms[fields][1][last]")).SendKeys("Aguirre");
            Driver.FindElement(By.Id("wpforms-49-field_2")).SendKeys("jota@gmail.com");
            Driver.FindElement(By.Id("wpforms-49-field_4")).SendKeys("989445588");
            // Checkbox or radio button could have the same name attribute but using XPath
            // XPath format: //tagname[@attibute=value]
            Driver.FindElement(By.XPath("//input[@value='Female']")).Click();
            // Drop Down (Html Options tag)
            IWebElement dropdown= Driver.FindElement(By.Id("wpforms-49-field_5"));
            SelectElement select=new SelectElement(dropdown);
            select.SelectByText("Selenium");
            //Submit button            
            Driver.FindElement(By.Id("wpforms-submit-49")).Click();
            
            string expectedMessage= "You have successfully filled in the form!\r\n ";
            string currentMesssage=Driver.FindElement(By.Id("wpforms-confirmation-49")).Text;
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