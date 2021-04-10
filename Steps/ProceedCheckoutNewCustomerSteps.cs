using AssertLibrary;
using Longrichway2021.Hooks;
using Longrichway2021.PageObject;
using OpenQA.Selenium;
using TechTalk.SpecFlow;


namespace Longrichway2021.Steps
{
    [Binding]
    public class ProceedCheckoutNewCustomerSteps
    {
        public IWebDriver driver = WebHook.driver;
        ProceedCheckoutNewCustomerPage proceedCheckoutNewCustomer = new ProceedCheckoutNewCustomerPage();

        [Given(@"I navigate to https://longrichway\.com/home")]
        public void GivenINavigateToHttpsLongrichway_ComHome()
        {
            driver.Navigate().GoToUrl(@"https://longrichway.com/");
        }
        
        [When(@"I click on categories")]
        public void WhenIClickOnCategories()
        {
            proceedCheckoutNewCustomer.ClickCategoryOption();
        }
        
        [When(@"click on Nutrition")]
        public void WhenClickOnNutrition()
        {
            proceedCheckoutNewCustomer.ClickNutritionOption();
        }
        
        [When(@"click on selected product")]
        public void WhenClickOnSelectedProduct()
        {
            proceedCheckoutNewCustomer.ClickonSelectedOption();
        }
        
        [When(@"click add to cart button")]
        public void WhenClickAddToCartButton()
        {
            proceedCheckoutNewCustomer.ClickAdd2Cart();
        }
        
        [When(@"the cart page is displayed")]
        public void WhenTheCartPageIsDisplayed()
        {
            proceedCheckoutNewCustomer.CartPageDisplayed();
        }
        
        [When(@"click on the checkout button")]
        public void WhenClickOnTheCheckoutButton()
        {
            proceedCheckoutNewCustomer.ClickCheckout();
        }

       

        [When(@"click on New Customer\? Quick Registration Button")]
        public void WhenClickOnNewCustomerQuickRegistrationButton()
        {
            proceedCheckoutNewCustomer.ClicknewCustomerQR();
        }

        [Then(@"user account page is displayed")]
        public void ThenUserAccountPageIsDisplayed()
        {
            proceedCheckoutNewCustomer.UserAccountDisplayed();
        }

        [When(@"I enter my First Name ""(.*)""")]
        public void WhenIEnterMyFirstName(string FirstName)
        {
            proceedCheckoutNewCustomer.FirstName(FirstName);
        }

        [When(@"I enter my Last Name ""(.*)""")]
        public void WhenIEnterMyLastName(string LastName)
        {
            proceedCheckoutNewCustomer.LastName(LastName);
        }

        [When(@"I enter my EmailAddress ""(.*)""")]
        public void WhenIEnterMyEmailAddress(string EmailAddress)
        {
            proceedCheckoutNewCustomer.EmailAddress(EmailAddress);
        }


        [When(@"I enter my PhoneNumber ""(.*)""")]
        public void WhenIEnterMyPhoneNumber(string PhoneNumber)
        {
            proceedCheckoutNewCustomer.PhoneNumber(PhoneNumber);
        }

        [When(@"I enter my Password ""(.*)""")]
        public void WhenIEnterMyPassword(string Password)
        {
            proceedCheckoutNewCustomer.Password(Password);
        }


        [When(@"I enter my ConfirmPassword ""(.*)""")]
        public void WhenIEnterMyConfirmPassword(string ConfirmPassword)
        {
            proceedCheckoutNewCustomer.ConfirmPassword(ConfirmPassword);
        }




        [When(@"I enter my Address ""(.*)""")]
        public void WhenIEnterMyAddress(string Address)
        {
            proceedCheckoutNewCustomer.Address(Address);
        }



        [When(@"I enter my Town/City ""(.*)""")]
        public void WhenIEnterMyTownCity(string TownCity)
        {
            proceedCheckoutNewCustomer.TownCity(TownCity);
        }



        [When(@"I enter my State ""(.*)""")]
        public void WhenIEnterMyState(string State)
        {
            proceedCheckoutNewCustomer.State(State);
        }


        [When(@"I click on Create Account button")]
        public void WhenIClickOnCreateAccountButton()
        {
            proceedCheckoutNewCustomer.CreateAccount();
        }



        [Then(@"a message should appear Registration successful")]
        public void ThenAMessageShouldAppearRegistrationSuccessful()
        {
            Assert.IsTrue(proceedCheckoutNewCustomer.NotificationSuccessful());
        }
    }

}
