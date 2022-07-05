using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace Amazon.utilities
{
    public class Base
    {
        public IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            String browserName = ConfigurationManager.AppSettings["browser"];
            InitBrowser(browserName);
            //InitBrowser("chrome");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.amazon.in/";
        }
        public IWebDriver getDriver()

        {
            return driver;
        }
        public void InitBrowser(String browserName)
        {
            switch(browserName)

            {
                case "Firefox":

                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;

                case "Chrome":

                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;


                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;



            }
        }

        [TearDown]
        public void AfterTest()
        {
            //driver.Quit();
        }

    }
}
