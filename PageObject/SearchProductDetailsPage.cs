using Longrichway2021.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Longrichway2021.PageObject
{
    class SearchProductDetailsPage
    {
        public IWebDriver driver;
        private By categoryField  = By.CssSelector("#menu-main-menu > li:nth-child(2) > a");
        private By skincareField = By.CssSelector("#menu-main-menu > li:nth-child(2) > ul > li:nth-child(6) > a");
        private By clickonProduct = By.CssSelector("#page_wrapper > section > div > div > div.col-sm-12.col-md-8.mb-30 > div > div > div > div:nth-child(2) > div > div > div > div.product-image3 > a > img.pic-2");
        private By ProductDetails = By.CssSelector("#content > div > div > div.right_sidebar.col-sm-12.col-md-12.col-lg-9 > div > div.row.product-page > div.single_product_main_image.col-sm-12.col-md-5.col-lg-5.mb-sm-40 > div > a > img");
        public SearchProductDetailsPage()
        {
            driver = WebHook.driver;
        }

        public void ClickCategoryField()
        {
            driver.FindElement(categoryField).Click();
        }

        public void ClickSkincareField()
        {
            driver.FindElement(skincareField).Click();
        }

        public void ClickonProduct()
        {
            driver.FindElement(clickonProduct).Click();
        }


        public bool ProductDetailsIsDisplayed()
        {
            return driver.FindElement(ProductDetails).Displayed;
        }


    }
}
