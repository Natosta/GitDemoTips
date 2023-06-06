using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Configuration;

namespace SeleniumWebDriver
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*    IWebDriver driver = new FirefoxDriver();
                  IWebDriver driver = new InternetExplorerDriver();
                  IWebDriver driver = new ChromeDriver();
                  driver.Navigate().GoToUrl("https://qa.worksonlocal.dev/");
                  driver.Close();
                  driver.Quit();

           */
           Console.WriteLine(ConfigurationManager.AppSettings.Get("Browser"));
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Username"));
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Password"));

            Console.WriteLine((int)Configuration.BrowserType.Firefox);
            Console.WriteLine((int)Configuration.BrowserType.Firefox);

        }
    }
}
