using Amazon.PageObjects;
using Amazon.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using WebDriverManager.DriverConfigs.Impl;

namespace Amazon
{
    public class Tests : Base
    {


        [Test]
        public void AmazonEndtoend()
        {

            Actions a = new Actions(driver);
            a.MoveToElement(driver.FindElement(By.XPath(" //div[@id='nav-tools']/a[2]"))).Click().Perform();

            LoginPage lp = new LoginPage(getDriver());
           
            // IWebElement userName = driver.FindElement(By.CssSelector("#ap_email"));
            // userName.SendKeys("8073048760");
            
            lp.getUserName().SendKeys("8073048760");

            //driver.FindElement(By.XPath("//input[@id='continue']")).Click();
            lp.clickoncontinue().Click();

            //IWebElement password = driver.FindElement(By.CssSelector("#ap_password"));
            //password.SendKeys("Sapc@1234");
            lp.getPassword().SendKeys("Sapc@1234");

            //driver.FindElement(By.CssSelector("#signInSubmit")).Click();
            lp.clickonSignInButton().Click();

            //searching the item in search Box
            // IWebElement serchBox = driver.FindElement(By.CssSelector("input[id='twotabsearchtextbox']"));
            // serchBox.SendKeys("samsung galaxy m53 5g");

            ItemSearch itemSearch  = new ItemSearch(getDriver());
            itemSearch.searchbox().SendKeys("samsung galaxy m53 5g");


            //driver.FindElement(By.XPath("//input[@id='nav-search-submit-button']")).Click();
            itemSearch.clickOnSearchButton().Click();




            // String parentWindow = driver.WindowHandles[0];
            String parentWindow = driver.CurrentWindowHandle;
            driver.FindElement(By.XPath("//div[contains(@class,'rush-component s-featured-result-item')]//span[@class='a-size-medium a-color-base a-text-normal'][contains(text(),'Samsung Galaxy M53 5G (Mystique Green, 6GB, 128GB ')]")).Click();

            Assert.AreEqual(2, driver.WindowHandles.Count);
            String childWindow = driver.WindowHandles[1];

            driver.SwitchTo().Window(childWindow);

            IWebElement staticdropDown = driver.FindElement(By.XPath("//select[@id='quantity']"));
            SelectElement sd = new SelectElement(staticdropDown);
            sd.SelectByValue("1");


            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name='submit.add-to-cart']")));
           
           // driver.FindElement(By.XPath("//input[@name='submit.add-to-cart']")).Click();
            addToCart atc = new addToCart(getDriver());
            atc.cliconaddToCart().Click();
            
            
            driver.SwitchTo().Window(parentWindow);

            IWebElement clickable = driver.FindElement(By.CssSelector("a[id='nav-cart']"));
            clickable.Click();

            

           
            
            //driver.FindElement(By.XPath("//input[@name='submit.delete.C92499178-c959-49f6-afd5-5a94424eaa3a']")).Click();
            //submit.delete.C92499178-c959-49f6-afd5-5a94424eaa3a


            // String confirText = driver.FindElement(By.XPath("//div[@class='a-section a-spacing-mini sc-list-body sc-java-remote-feature']//div[2]")).Text;

            //TestContext.Progress.WriteLine(confirText);

            //StringAssert.Contains("Samsung Galaxy M53 5G (Mystique Green, 6GB, 128GB Storage) | 108... was removed from Shopping Cart.", confirText);











        }



       

        
    }
}
