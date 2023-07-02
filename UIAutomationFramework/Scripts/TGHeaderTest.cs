using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace UIAutomationFramework.Scripts
{
    [TestFixture]
    public class TGHeaderTests : BaseTest
    {
        [Test]
        public void ValidateTGLogo()
        {
            Thread.Sleep(1000);
            Assert.True(basePage.logo.Displayed);
        }

        [Test]
        public void ValidateTGHeader()
        {
            Assert.True(basePage.heading.Displayed);
            Assert.AreEqual(basePage.heading.Text, "Welcome to TechGlobal School\nTraining");
        }
    }
}