using AssertLibrary;
using Longrichway2021.Hooks;
using Longrichway2021.PageObject;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;


namespace Longrichway2021.Steps
{
    [Binding]
    public class VerifyBuyerMakingPaymentSteps
    {
        public IWebDriver driver = WebHook.driver;

        VerifyBuyerMakesPaymentPage verifyBuyerMakesPayment = new VerifyBuyerMakesPaymentPage();

        [Given(@"I navigate to https://longrichway\.com/")]
        public void GivenINavigateToHttpsLongrichway_Com()
        {
            driver.Navigate().GoToUrl(@"https://longrichway.com/");
        }

        [When(@"I click on categoryField")]
        public void WhenIClickOnCategoryField()
        {
            verifyBuyerMakesPayment.ClickCategoryArea();
        }


        [When(@"click on Skincare")]
        public void WhenClickOnSkincare()
        {
            verifyBuyerMakesPayment.SkinCareArea();
        }

        [When(@"click on selected item")]
        public void WhenClickOnSelectedItem()
        {
            verifyBuyerMakesPayment.SelectedArea();
        }

        [When(@"click addCartField")]
        public void WhenClickAddCartField()
        {
            verifyBuyerMakesPayment.AddcartField();
        }

        [When(@"click checkOutField")]
        public void WhenClickCheckOutField()
        {
            verifyBuyerMakesPayment.CheckOutField();
        }


        [When(@"enter emailTextField ""(.*)""")]
        public void WhenEnterEmailTextField(string emailTextField)
        {
            verifyBuyerMakesPayment.EmailTextField(emailTextField);
        }


        [When(@"enter passwordField ""(.*)""")]
        public void WhenEnterPasswordField(string passwordField)
        {
            verifyBuyerMakesPayment.PasswordField(passwordField);
        }
        [When(@"click on the loginField")]
        public void WhenClickOnTheLoginField()
        {
            verifyBuyerMakesPayment.LoginField();
        }


        [When(@"click on delivery option")]
        public void WhenClickOnDeliveryOption()
        {
            Thread.Sleep(5000);
            verifyBuyerMakesPayment.DeliveryOption();
            
        }

        [When(@"click address button")]
        public void WhenClickAddressButton()
        {
            verifyBuyerMakesPayment.AddressButton();
        }

        [When(@"click on payment option")]
        public void WhenClickOnPaymentOption()
        {
            verifyBuyerMakesPayment.ClickOnPaymentOption();
        }

        [When(@"I  click on the complete order button")]
        public void WhenIClickOnTheCompleteOrderButton()
        {
            verifyBuyerMakesPayment.ClickCompleteOrderButton();
        }

        [Then(@"I should be able to make payment with my card details")]
        public void ThenIShouldBeAbleToMakePaymentWithMyCardDetails()
        {
            Assert.IsTrue(verifyBuyerMakesPayment.SuccessfulPaymentProcess());
        }
    }
}
