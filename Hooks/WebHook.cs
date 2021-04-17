using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;

namespace Longrichway2021.Hooks
{
    [Binding]

    public class WebHook
    {

        public static IWebDriver driver;
        //public static IWebDriver driver = new ChromeDriver("C:\Program Files\Google\Chrome\Application\90.0.4430.72", options);


        [BeforeScenario]
        public static void BeforeScenario()
        {
            
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            
            driver.Close();
            driver.Quit();
        }
    }
}
