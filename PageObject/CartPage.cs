using Longrichway2021.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Longrichway2021.PageObject
{

    class CartPage
    {
        public IWebDriver driver;

        public CartPage()
        {
            driver = WebHook.driver; 
        }
             
       
      
 
        private By clickonCategories = By.CssSelector("#menu-main-menu > li:nth-child(2) > a");
        private By clickonSkincare = By.CssSelector("#menu-main-menu > li:nth-child(2) > ul > li:nth-child(6) > a");
        private By skinCarePage = By.CssSelector("#page_header > div.ph-content-wrap.d-flex > div > div > div:nth-child(2) > div > h2");

        public void ClickOnCategories()
        {
            driver.FindElement(clickonCategories).Click();
        }

        public void ClickonSkincare()
        {
            driver.FindElement(clickonSkincare).Click();
        }

        public bool SkinCarePage()
        {
            return driver.FindElement(skinCarePage).Displayed;
        }
    }
}
