using Longrichway2021.Hooks;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Longrichway2021.PageObject
{
    class RegistrationPage
    {
        public IWebDriver driver;
        public RegistrationPage()
        {
            driver = WebHook.driver;
        }

        private By registerButton = By.CssSelector("#header > div.site-header-wrapper > div.site-header-top-wrapper > div > div.site-header-row.site-header-top.d-flex.justify-content-between > div.site-header-top-right.d-flex > div:nth-child(4) > div:nth-child(2) > a > span");
        private By firstName = By.XPath("//*[@id='firstname']");
        private By lastName = By.XPath("//*[@id='lastname']");
        private By email = By.XPath("//*[@id='emailaddressreg']");
        private By phone = By.XPath("//*[@id='telephone']");
        private By password = By.XPath("//*[@id='passwordreg']");
        private By confirmPassword = By.XPath("//*[@id='cnpassword']");
        private By address = By.XPath("//*[@id='address']");
        private By city = By.XPath("//*[@id='city']");
        private By state = By.XPath("//*[@id='state']");
        private By createaccountbutton = By.XPath("//*[@id='btn_register']");
        private By successNotification = By.CssSelector("#modal_panel > div");
        private By omitphone = By.XPath("//*[@id='telephone']");





       

        public void ClickregisterButton()
        {
            driver.FindElement(registerButton).Click();
        }

        public void ClickfirstName()
        {
            driver.FindElement(firstName).Click();
            driver.FindElement(firstName).SendKeys("David");
        }

        public void ClicklastName()
        {
            driver.FindElement(lastName).Click();
            driver.FindElement(lastName).SendKeys("Jones");
        }

        public void Clickemail()

        {
            driver.FindElement(email).Click();
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            driver.FindElement(email).SendKeys("username+" + randomInt + "@gmail.com");
        }

        public void Clickphone()
        {
            driver.FindElement(phone).Click();
            driver.FindElement(phone).SendKeys("07729943966");
        }

        public void Clickpassword()
        {
            driver.FindElement(password).Click();
            driver.FindElement(password).SendKeys("elephant");
        }

        public void EnterConfirmPassword()
        {
            driver.FindElement(confirmPassword).Click();
            driver.FindElement(confirmPassword).SendKeys("elephant");
        }

        public void clickaddress()
        {
            driver.FindElement(address).Click();
            driver.FindElement(address).SendKeys("Flat 4 Strathmore Court SW19 8DD");
        }

        public void clickcity()
        {
            driver.FindElement(city).Click();
            driver.FindElement(city).SendKeys("Wimbledon");
        }
        public void clickstate()
        {
            driver.FindElement(state).Click();
            driver.FindElement(state).SendKeys("London");
        }
        
        public void clickcreateaccountbutton()
        {
            driver.FindElement(createaccountbutton).Click();
        }
        
        public string SuccessNotificationDisplayed()
        {
            Thread.Sleep(1000);
            return  driver.FindElement(successNotification).Text;
            
        }
            

        public void clickandomitphone()
        {
            driver.FindElement(omitphone).Click();
        }




        

        

    }
}
