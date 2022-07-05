using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
            {
             this.driver = driver;
             PageFactory.InitElements(driver, this);
            }

        [FindsBy(How = How.CssSelector, Using = "#ap_email")]
        private IWebElement userName;

        [FindsBy(How = How.XPath, Using = "//input[@id='continue']")]
        private IWebElement clickonContinue;

        [FindsBy(How = How.CssSelector, Using = "#ap_password")]
        private IWebElement password;

        [FindsBy(How = How.CssSelector, Using = "#signInSubmit")]
        private IWebElement signINButton;

        public IWebElement getUserName()

        {
            return userName;
        }

        public IWebElement clickoncontinue()

        {
            return clickonContinue;
        }

        public IWebElement getPassword()

        {
            return password;
        }

        public IWebElement clickonSignInButton()

        {
            return signINButton;
        }

    }
}
