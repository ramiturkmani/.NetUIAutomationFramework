﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;

namespace UIAutomationFramework;

[TestFixture]
public class Tests
{
    [Test]
    public void validateTGLogo()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        driver.Navigate().GoToUrl("https://techglobal-training.com/");

        IWebElement logo = driver.FindElement(By.Id("logo"));

        Assert.True(logo.Displayed);

        Thread.Sleep(5000);

        driver.Quit();
    }

    [Test]
    public void validateTGHeader()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        driver.Navigate().GoToUrl("https://techglobal-training.com/");

        IWebElement heading = driver.FindElement(By.CssSelector(".HomePage_pageTitle__UAMbk"));

        Assert.True(heading.Displayed);
        Assert.AreEqual(heading.Text, "Welcome to TechGlobal School\nTraining");

        Thread.Sleep(5000);

        driver.Quit();
    }
}
