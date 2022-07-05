using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.PageObjects
{
    public class addToCart
    {
        IWebDriver driver;
        public addToCart(IWebDriver driver)

        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
           
        }

        [FindsBy(How = How.XPath, Using = "//input[@name='submit.add-to-cart']")]
        private IWebElement clickonAddToCart;

        public IWebElement cliconaddToCart()
        {
            return clickonAddToCart;
        }

    }
}
