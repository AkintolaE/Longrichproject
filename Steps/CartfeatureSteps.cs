using Longrichway2021.Hooks;
using Longrichway2021.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;





namespace Longrichway2021.Steps
{
    [Binding]
    public class CartfeatureSteps
    {
        public IWebDriver driver = WebHook.driver;
        CartPage cartPage = new CartPage();



        [Given(@"I click on categories for products")]
        public void GivenIClickOnCategoriesForProducts()
        {
            cartPage.ClickOnCategories();
        }
        
        [Given(@"I select  category skincare")]
        public void GivenISelectCategorySkincare()
        {
            cartPage.ClickonSkincare();
        }

        [Then(@"the product and retail price is displayed")]
        public void ThenTheCostOfProductAtRetailPriceIsDisplayed()
        {
            Assert.True(cartPage.SkinCarePage());

        }

    }
}
