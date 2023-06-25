using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutomationFramework;

[TestFixture]
public class TGHeaderTests
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

    [Test]
    public void ValidateTGLogo()
    {
        IWebElement logo = driver.FindElement(By.Id("logo"));
        Assert.True(logo.Displayed);
    }

    [Test]
    public void ValidateTGHeader()
    {
        IWebElement heading = driver.FindElement(By.CssSelector(".HomePage_pageTitle__UAMbk"));
        Assert.True(heading.Displayed);
        Assert.AreEqual(heading.Text, "Welcome to TechGlobal School\nTraining");
    }
}
