using FluentAssertions;
using Longrichway2021.Hooks;
using Longrichway2021.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;




namespace Longrichway2021.Steps
{
    [Binding]
    public class SearchProductSteps
    {
        public IWebDriver driver = WebHook.driver;
        SearchProductPage _searchProductPage = new SearchProductPage();

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string p0)
        {
            driver.Navigate().GoToUrl(@"https://longrichway.com/");
        }
        [When(@"I click on categories for products")]
        public void WhenIClickOnCategoriesForProducts()
        {
            _searchProductPage.ClickCategoriesField();
        }

        [When(@"I select   nutrition")]
        public void WhenISelectNutrition()
        {
            _searchProductPage.ClickNutritionField();
        }
        [Then(@"I should be able to see the products and the price")]
        public void ThenIShouldBeAbleToSeeTheProductsAndThePrice()
        {
            _searchProductPage.ProductPriceIsDisplayed().Should().BeTrue();
        }








    }
}

