using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UIAutomationFramework.EnvironmentConfiguration;
using UIAutomationFramework.Pages;
using UIAutomationFramework.Utils;

namespace UIAutomationFramework.Scripts
{
    public class BaseTest : EnvirontmentSettings
    {
        public BasePage basePage;
        public MockInterviewsPage mockInterviewsPage;

        [SetUp]
        public void Setup()
        {
            driver = Driver.GetDriver();
            driver.Navigate().GoToUrl("https://techglobal-training.com/");
            basePage = new BasePage();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}