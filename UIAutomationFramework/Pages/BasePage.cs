using System;
using OpenQA.Selenium;
using UIAutomationFramework.EnvironmentConfiguration;


namespace UIAutomationFramework.Pages
{
	public class BasePage : EnvirontmentSettings
	{
        //Header Elements
        public IWebElement logo => driver.FindElement(By.Id("logo"));
        public IWebElement heading => driver.FindElement(By.CssSelector(".HomePage_pageTitle__UAMbk"));

        //Footer Elements
        public IWebElement address => driver.FindElement(By.XPath("(//footer[@class='Footer_footer__kXlYa']//p)[1]"));
        public IWebElement copyright => driver.FindElement(By.XPath("(//footer[@class='Footer_footer__kXlYa']//p)[2]"));
        public IList<IWebElement> socialMediaElements => driver.FindElements(By.CssSelector(".Footer_socials__7h4n1>a"));
    }
}