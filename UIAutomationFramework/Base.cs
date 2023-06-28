using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutomationFramework
{
	public class Base
	{
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://techglobal-training.com/");
        }

        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(3000); //3 Seconds
            driver.Quit();
        }
    }
}