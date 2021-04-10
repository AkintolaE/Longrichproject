using Longrichway2021.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Longrichway2021.PageObject
{
    class SearchProductPage
    {
        public IWebDriver driver;
        private By categoriesField = By.CssSelector("#menu-main-menu > li:nth-child(2) > a");
        private By nutritionField = By.CssSelector("#menu-main-menu > li:nth-child(2) > ul > li:nth-child(4) > a");
        private By productPrice = By.CssSelector("#page_wrapper > section > div > div > div.col-sm-12.col-md-8.mb-30 > div > div > div > div:nth-child(1) > h3");
        public SearchProductPage()
        {
            driver = WebHook.driver;
        
        }

        public void ClickCategoriesField()
        {
            driver.FindElement(categoriesField).Click();
        }
        public void ClickNutritionField()
        {
            driver.FindElement(nutritionField).Click();
        }
        public bool ProductPriceIsDisplayed()
        {
            return driver.FindElement(productPrice).Displayed;
        }
    }
    

}


