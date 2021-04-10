using Longrichway2021.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Longrichway2021.PageObject
{
    class loginPage
    {
        public IWebDriver driver;


        public loginPage()
        {
            driver = WebHook.driver;

        }


        private By loginButton = By.CssSelector("#header > div.site-header-wrapper > div.site-header-top-wrapper > div > div.site-header-row.site-header-top.d-flex.justify-content-between > div.site-header-top-right.d-flex > div:nth-child(4) > div:nth-child(1) > a > span");
        private By email = By.XPath("//*[@id='emailaddress']");
        private By password = By.XPath("//*[@id='password']");
        private By clickloginButtons = By.XPath("//*[@id='btn_login']");
        private By clickcategoriesButton = By.CssSelector("#menu-main-menu > li:nth-child(2) > a");     
        private By selectfeminineCare = By.CssSelector("#menu-main-menu > li:nth-child(2) > ul > li:nth-child(2) > a");
        private By click1snakeOil = By.CssSelector("#page_wrapper > section > div > div > div.col-sm-12.col-md-8.mb-30 > div > div > div > div:nth-child(2) > div > div > div > div.product-image3 > a > img.pic-2");
        private By click1snakeoiltoCart = By.CssSelector("#content > div > div > div.right_sidebar.col-sm-12.col-md-12.col-lg-9 > div > div.row.product-page > div.main-data.col-sm-12.col-md-7.col-lg-7 > div > form > div > div.variations_button > button");
        private By clickonCart = By.CssSelector("#cart_area > a > i");
        private By clickonviewCart = By.CssSelector("#cart_area > a > i");
        private By clickonCheckout = By.XPath("//*[@id='cart_area']/div/div/div/p[2]/a[2]");

       // public By Checkout { get; private set; }

        public void ClickloginButton()
        {
            driver.FindElement(loginButton).Click();
        }

        

        public void Clickemail()

        {
            driver.FindElement(email).Click();
            driver.FindElement(email).SendKeys("atolayomi+1@gmail.com");
        }

        public void Clickpassword()
        {
            driver.FindElement(password).Click();
            driver.FindElement(password).SendKeys("kidney");
        }

        public void ClickloginButtons()
        {

            driver.FindElement(clickloginButtons).Click();
        }

        public void ClickcategoriesButton()
        {
            Thread.Sleep(1000);
            driver.FindElement(clickcategoriesButton).Click();
           // wait.WaitForElement(driver, clickcategoriesButton);
        }
        public void ClickselectfeminineCare()
        {
            driver.FindElement(selectfeminineCare).Click();
        }

        public void Click1snakeOil()
        {
            driver.FindElement(click1snakeOil).Click();

        }

        public void snakeoiltoCart()
        {
            driver.FindElement(click1snakeoiltoCart).Click();
        }
        public void Cart()
        {
            driver.FindElement(clickonCart).Click();
            driver.FindElement(clickonviewCart).Click();

        }

        public void ClickonCheckout()
        {
            driver.FindElement(clickonCheckout).Click();
        }

    }
}
