using Longrichway2021.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Longrichway2021.PageObject
{
    class VerifyBuyerMakesPaymentPage
    {
        public IWebDriver driver;
        private By categoryArea = By.CssSelector("#menu-main-menu > li:nth-child(2) > a");
        private By skincareArea = By.CssSelector("#menu-main-menu > li:nth-child(2) > ul > li:nth-child(6) > a");
        private By selectedItem = By.CssSelector("#page_wrapper > section > div > div > div.col-sm-12.col-md-8.mb-30 > div > div > div > div:nth-child(2) > div > div > div > div.product-image3 > a > img.pic-2");
        private By AddCartField = By.CssSelector("#cart_area > a > i");
        private By checkOutField = By.CssSelector("#cart_area > div > div > div > p.buttons > a.button.checkout.wc-forward");
        private By emailTextField = By.CssSelector("#emailaddress");
        private By passwordField = By.CssSelector("#password");
        private By loginField = By.CssSelector("#btn_login");
        private By deliveryOption = By.CssSelector("#shipping_home");
        private By addressButton = By.CssSelector("#content > div > form > div > div.col-sm-12.col-md-12.col-lg-5 > div.col-lg-12.mb-20 > div:nth-child(1) > div.panel-default > label");
        private By clickonPaymentOption = By.CssSelector("#payment > ul > li:nth-child(1) > label");
        private By clickCompleteOrderButton = By.CssSelector("#btn_order");
        private By successfulPaymentProcess = By.CssSelector("#test-cards");
        public VerifyBuyerMakesPaymentPage()
        {
            driver = WebHook.driver;
        }

        public void ClickCategoryArea()
        {
            driver.FindElement(categoryArea).Click();
        }
        public void SkinCareArea()
        {
            driver.FindElement(skincareArea).Click();
        }
        public void SelectedArea()
        {
            driver.FindElement(selectedItem).Click();
        }
        public void AddcartField()
        {
            driver.FindElement(AddCartField).Click();
        }
        public void CheckOutField()
        {
            driver.FindElement(checkOutField).Click();
        }
        public void EmailTextField(string EmailTextField)
        {
            driver.FindElement(emailTextField).SendKeys(EmailTextField);
        }
        public void PasswordField(string PasswordField)
        {
            driver.FindElement(passwordField).SendKeys(PasswordField);
        }
        public void LoginField()
        {
            driver.FindElement(loginField).Click();
        }
        public void DeliveryOption ()
        {
            driver.FindElement(deliveryOption).Click();
        }
        public void AddressButton()
        {
            driver.FindElement(addressButton).Click();
        }
        public void ClickOnPaymentOption()
        {
            driver.FindElement(clickonPaymentOption).Click();
        }
        public void ClickCompleteOrderButton()
        {
            driver.FindElement(clickCompleteOrderButton);
        }
        public bool  SuccessfulPaymentProcess()
        {
            return driver.FindElement(successfulPaymentProcess).Displayed;
        }
    }
}
