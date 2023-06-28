using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutomationFramework
{
    [TestFixture]
	public class TGFooterClass : Base
	{
        [Test]
        public void ValidateTGFooter()
        {
            IWebElement address = driver.FindElement(By.XPath("(//footer[@class='Footer_footer__kXlYa']//p)[1]"));
            IWebElement copyright = driver.FindElement(By.XPath("(//footer[@class='Footer_footer__kXlYa']//p)[2]"));

            IList<IWebElement> socialMediaElements = driver.FindElements(By.CssSelector(".Footer_socials__7h4n1>a"));

            Assert.That(address.Displayed);
            Assert.That(address.Text.Equals("2860 S River Rd Suite 480, Des Plaines, IL 60018"));

            Assert.That(copyright.Displayed);
            Assert.That(copyright.Text.Equals("© 2023 TechGlobal - All Rights Reserved"));

            foreach(IWebElement element in socialMediaElements)
            {
                Assert.That(element.Displayed);
                Assert.That(element.Enabled);
                Assert.IsNotEmpty(element.GetAttribute("href"));
            }
        }
    }
}