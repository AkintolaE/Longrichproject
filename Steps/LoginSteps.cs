using Longrichway2021.Hooks;
using Longrichway2021.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Longrichway2021.Steps
{
    [Binding]
    public class LoginSteps

    {
        public IWebDriver driver = WebHook.driver;
        loginPage loginButton  = new loginPage();
       // private object loginButtons;

        [Given(@"that I navigate to https://longrichway\.com/home")]
        public void GivenThatINavigateToHttpsLongrichway_ComHome()
        {
            driver.Navigate().GoToUrl("https://longrichway.com");   
        }
        
        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            loginButton.ClickloginButton();
        }
        
        [When(@"I enter email")]
        public void WhenIEnterEmail()
        {
            loginButton.Clickemail(); 
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            loginButton.Clickpassword();
        }
        
        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButtons()
        {
            loginButton.ClickloginButtons();
        }

        [Then(@"the landing page is displayed")]
        public void ThenTheLandingPageIsDisplayed()
        {
            
        }


        [Then(@"I select categories")]
        public void ThenISelectCategories()
        {
            loginButton.ClickcategoriesButton();
        }
        
        [Then(@"I select Feminine care category")]
        public void ThenISelectFeminineCareCategory()
        {
            loginButton.ClickselectfeminineCare();
        }
        
        [Then(@"I select snake oil uk")]
        public void ThenISelectSnakeOilUk()
        {
            loginButton.Click1snakeOil();
        }
        
        [Then(@"I click (.*) snake oil uk to cart")]
        public void ThenIClickSnakeOilUkToCart(int p0)
        {
            loginButton.snakeoiltoCart();
        }
        
        [Then(@"I click view your shopping cart")]
        public void ThenIClickViewYourShoppingCart()
        {
            loginButton.Cart();
        }
        
        [Then(@"I click on checkout button")]
        public void ThenIClickOnCheckoutButton()
        {
            loginButton.ClickonCheckout();
        }
        
        [Then(@"check out page is displayed")]
        public void ThenCheckOutPageIsDisplayed()
        {
            
        }
    }
}
