using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace LearningSelenium
{
    public class WorkingWithDragAndDrop
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
        public void VerifyDragAndDrop()
        {
            // Interact with the mouse
            Actions action= new Actions(Driver);
            IWebElement source= Driver.FindElement(By.Id("draggable"));
            IWebElement target= Driver.FindElement(By.Id("droppable"));
            
            
            string colorBeforeDragAndDrop= target.GetCssValue("color");
            action.DragAndDrop(source,target).Perform();
            string colorAfterDragAndDrop= target.GetCssValue("color");
            Assert.AreNotEqual(colorBeforeDragAndDrop,colorAfterDragAndDrop);
        }

        [TearDown] 
        // Finish Testing
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}