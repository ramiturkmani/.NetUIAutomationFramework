using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace UIAutomationFramework.Scripts
{
    [TestFixture]
    public class TGFooterClass : BaseTest
    {
        [Test]
        public void ValidateTGFooter()
        {
            Assert.That(basePage.address.Displayed);
            Assert.That(basePage.address.Text.Equals("2860 S River Rd Suite 480, Des Plaines, IL 60018"));

            Assert.That(basePage.copyright.Displayed);
            Assert.That(basePage.copyright.Text.Equals("© 2023 TechGlobal - All Rights Reserved"));

            foreach (IWebElement element in basePage.socialMediaElements)
            {
                Assert.That(element.Displayed);
                Assert.That(element.Enabled);
                Assert.IsNotEmpty(element.GetAttribute("href"));
            }
        }
    }
}