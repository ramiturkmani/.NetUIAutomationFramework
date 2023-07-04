using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UIAutomationFramework.Pages
{
	public class MockInterviewsPage : BasePage
	{
		public IWebElement loginFormTitle => driver.FindElement(By.CssSelector(".Login_loginText__heJKr>h2"));
        public IWebElement loginFormUserNameLabel => driver.FindElement(By.XPath("(//form//label)[1]"));
        public IWebElement loginFormUserNameInput => driver.FindElement(By.XPath("(//form//input)[1]"));
        public IWebElement loginFormPasswordLabel => driver.FindElement(By.XPath("(//form//label)[2]"));
        public IWebElement loginFormPasswordInput => driver.FindElement(By.XPath("(//form//input)[2]"));
        public IWebElement loginFormLanguageLabel => driver.FindElement(By.XPath("(//form//label)[3]"));
        public IWebElement loginFormLanguageInput => driver.FindElement(By.XPath("//form//select"));
        public IWebElement loginFormLoginButton=> driver.FindElement(By.CssSelector(".Login_buttonOuterDiv__vT8CL>button"));
        public IWebElement loginFormErrorMessage => driver.FindElement(By.CssSelector(".Login_errorMessage__Hhsw0>p"));


        public void FillOutLoginForm(string username = "johndoe@gmail.com", string password = "techglobal", string language = "java")
        {
            loginFormUserNameInput.SendKeys(username);
            loginFormPasswordInput.SendKeys(password);
            SelectElement element = new SelectElement(loginFormLanguageInput);
            element.SelectByValue(language);
        }
    }
}

