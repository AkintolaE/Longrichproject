using FluentAssertions;
using Longrichway2021.Hooks;
using Longrichway2021.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;


namespace Longrichway2021.Steps
{
    [Binding]
    public class SearchProductDetailsSteps
    {
        public IWebDriver driver = WebHook.driver;
        SearchProductDetailsPage searchProductDetailsPage = new SearchProductDetailsPage();
       

        [Given(@"I open browser ""(.*)""")]
        public void GivenIOpenBrowser(string p0)
        {
            driver.Navigate().GoToUrl(@"https://longrichway.com/");
        }

        [When(@"I click on category")]
        public void WhenIClickOnCategory()
        {
            searchProductDetailsPage.ClickCategoryField();
        }

        [When(@"I select skincare")]
        public void WhenISelectSkincare()
        {
            searchProductDetailsPage.ClickSkincareField();
        }

        [When(@"I click on displayed product")]
        public void WhenIClickOnDisplayedProduct()
        {
            searchProductDetailsPage.ClickonProduct();
        }

        [Then(@"I should be able to see the product with detailed description")]
        public void ThenIShouldBeAbleToSeeTheProductWithDetailedDescription()
        {
            searchProductDetailsPage.ProductDetailsIsDisplayed().Should().BeTrue();
        }

        
    }
}
