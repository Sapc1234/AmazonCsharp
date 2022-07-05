using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.PageObjects
{
    public class ItemSearch
    {
        IWebDriver driver;
        public ItemSearch(IWebDriver driver)

        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "input[id='twotabsearchtextbox']")]
        private IWebElement serchBox;

        [FindsBy(How = How.XPath, Using = "//input[@id='nav-search-submit-button']")]
        private IWebElement searchButton;


        public IWebElement searchbox()

        {
            return serchBox;
        }

        public IWebElement clickOnSearchButton()

        {
            return searchButton;
        }
    }
}
