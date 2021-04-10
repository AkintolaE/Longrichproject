using Longrichway2021.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Longrichway2021.PageObject
{
    class ProceedCheckoutNewCustomerPage
    {
        public IWebDriver driver;

        private By categoryOption = By.CssSelector("#menu-main-menu > li:nth-child(2) > a");
        private By nutritionOption = By.CssSelector("#menu-main-menu > li:nth-child(2) > ul > li:nth-child(4) > a");
        private By clickonselectedOption = By.CssSelector("#page_wrapper > section > div > div > div.col-sm-12.col-md-8.mb-30 > div > div > div > div:nth-child(2) > div > div > div > div.product-image3 > a > img.pic-2");
        private By clickadd2Cart = By.CssSelector("#content > div > div > div.right_sidebar.col-sm-12.col-md-12.col-lg-9 > div > div.row.product-page > div.main-data.col-sm-12.col-md-7.col-lg-7 > div > form > div > div.variations_button > button");
        private By cartpageDisplayed = By.CssSelector("#cart_area > a > i");
        private By clickCheckout = By.CssSelector("#cart_area > div > div > div > p.buttons > a.button.checkout.wc-forward");
        private By clicknewCustomerQR = By.CssSelector("#headingTwo > a");
        private By useraccountDisplayed = By.CssSelector("#content > div > div > div.right_sidebar.col-sm-12.col-md-12.col-lg-7.mb-md-20 > div > h3");
        private By firstName = By.CssSelector("#firstname");
        private By lastName = By.CssSelector("#lastname");
        private By emailAddress = By.CssSelector("#emailaddressreg");
        private By phoneNumber = By.CssSelector("#telephone");
        private By password = By.CssSelector("#passwordreg");
        private By confirmPassword = By.CssSelector("#cnpassword");
        private By address = By.CssSelector("#address");
        private By townCity = By.CssSelector("#city");
        private By state = By.CssSelector("#country");
        private By createAccount = By.CssSelector("#btn_register");
        private By registrationSuccessful = By.CssSelector("#dialoguetext");
        public ProceedCheckoutNewCustomerPage()
        {
            driver = WebHook.driver;

        }

        public void ClickCategoryOption()
        {
            driver.FindElement(categoryOption).Click();
        }

        public void ClickNutritionOption()
        {
            driver.FindElement(nutritionOption).Click();
        }

        public void ClickonSelectedOption()
        {
            driver.FindElement(clickonselectedOption).Click();
        }
        public void ClickAdd2Cart()
        {
            driver.FindElement(clickadd2Cart).Click();
        }
        public void CartPageDisplayed()
        {
            driver.FindElement(cartpageDisplayed).Click();
        }

        public void ClickCheckout()
        {
            driver.FindElement(clickCheckout).Click();
        }

       

        public void ClicknewCustomerQR()
        {
            driver.FindElement(clicknewCustomerQR).Click();
        }
        public void UserAccountDisplayed()

        {
            driver.FindElement(useraccountDisplayed).Click();
        }
        public void FirstName(string FirstName)
        {
            driver.FindElement(firstName).Click();
            driver.FindElement(firstName).SendKeys(FirstName);
        }
        public void LastName(string LastName)
        {
            driver.FindElement(lastName).Click();
            driver.FindElement(lastName).SendKeys(LastName); 
        }
        public void EmailAddress(string EmailAddress)
        {
            driver.FindElement(emailAddress).Click();
            driver.FindElement(emailAddress).SendKeys(EmailAddress);
         
        }
        public void PhoneNumber(string PhoneNumber)
        {
            driver.FindElement(phoneNumber).SendKeys(PhoneNumber);
          
        }
        public void Password(string Password)
        {
            driver.FindElement(password).SendKeys(Password);
         
        }
        public void ConfirmPassword(string ConfirmPassword)
        {
            driver.FindElement(confirmPassword).SendKeys(ConfirmPassword);
         
        }
        public void  Address(string Address)
        {
            driver.FindElement(address).SendKeys(Address);
            
        }

        public void TownCity(string TownCity)
        {
            driver.FindElement(townCity).SendKeys(TownCity);
           
        }
        public void State(string State)
        {
            driver.FindElement(state).SendKeys(State);
           
        }
        public void CreateAccount()
        {
            driver.FindElement(createAccount).Click();
            
        }
        public bool NotificationSuccessful()
        {
            return driver.FindElement(registrationSuccessful).Displayed;

        }

    }
}
