using System;
using OpenQA.Selenium;
using UIAutomationFramework.EnvironmentConfiguration;


namespace UIAutomationFramework.Pages
{
	public class BasePage : EnvirontmentSettings
	{
        public IWebElement logo => driver.FindElement(By.Id("logo"));

    }
}