using NUnit.Framework;

namespace UIAutomationFramework.Scripts
{
	public class MockInterviewTest : BaseTest
	{
		[SetUp]
		public void SetPage()
		{
			mockInterviewsPage = new Pages.MockInterviewsPage();
            basePage.selectPracticesDropDownOption("Mock Interviews");
		}

		[Test]
		public void ValidateMockInterviewsLoginForm()
		{
			Assert.True(mockInterviewsPage.loginFormTitle.Displayed);
			Assert.That(mockInterviewsPage.loginFormTitle.Text.Equals("Designed for TechGlobal Students"));

            Assert.True(mockInterviewsPage.loginFormUserNameLabel.Displayed);
            Assert.That(mockInterviewsPage.loginFormUserNameLabel.Text.Equals("Enter your username"));
            Assert.True(mockInterviewsPage.loginFormUserNameInput.Displayed);
            Assert.True(mockInterviewsPage.loginFormUserNameInput.Enabled);
			
            Assert.True(mockInterviewsPage.loginFormPasswordLabel.Displayed);
            Assert.That(mockInterviewsPage.loginFormPasswordLabel.Text.Equals("Enter your password"));
            Assert.True(mockInterviewsPage.loginFormPasswordInput.Displayed);
            Assert.True(mockInterviewsPage.loginFormPasswordInput.Enabled);

            Assert.True(mockInterviewsPage.loginFormLoginButton.Displayed);
            Assert.True(mockInterviewsPage.loginFormLoginButton.Enabled);
            Assert.That(mockInterviewsPage.loginFormLoginButton.Text.Equals("LOGIN"));
        }

        [Test]
        public void ValidateMockInterviewsLoginFormWithInvalidCreds()
        {
            mockInterviewsPage.FillOutLoginForm();
            mockInterviewsPage.loginFormLoginButton.Click();

            Assert.True(mockInterviewsPage.loginFormErrorMessage.Displayed);
            Assert.That(mockInterviewsPage.loginFormErrorMessage.Text.Equals("Email and password do not match!"), "ACTUAL = " + mockInterviewsPage.loginFormErrorMessage.Text);

            Thread.Sleep(2000);
        }
    }
}

