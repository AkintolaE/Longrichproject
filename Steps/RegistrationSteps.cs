using FluentAssertions;
using Longrichway2021.Hooks;
using Longrichway2021.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Longrichway2021.Steps
{
    [Binding]
    public class RegistrationSteps
    {
        
      
        public IWebDriver driver = WebHook.driver;
        RegistrationPage _registrationPage = new RegistrationPage();

        [Given(@"I navigate to the Longrich way website")]
        public void GivenINavigateToTheLongrichWayWebsite()


        {
            driver.Navigate().GoToUrl("https://longrichway.com/");
        }
        
        [Given(@"I click on the Register Button")]
        public void GivenIClickOnTheRegisterButton()
        {
            _registrationPage.ClickregisterButton(); 
        }
        
        [Given(@"I enter my First name")]
        public void GivenIEnterMyFirstName()
        {
            _registrationPage.ClickfirstName();
        }
        
        [Given(@"I enter my Last name")]
        public void GivenIEnterMyLastName()
        {
            _registrationPage.ClicklastName();
        }
        
        [Given(@"I enter my Email address")]
        public void GivenIEnterMyEmailAddress()
        {
            _registrationPage.Clickemail(); 
        }
        
        [Given(@"I enter my Phone number")]
        public void GivenIEnterMyPhoneNumber()
        {
            _registrationPage.Clickphone();
        }
        
        [Given(@"I enter my Password")]
        public void GivenIEnterMyPassword()
        {
            _registrationPage.Clickpassword();
        }
        
        [Given(@"I enter my Confirm Password")]
        public void GivenIEnterMyConfirmPassword()
        {
            _registrationPage.EnterConfirmPassword();
        }
        
        [Given(@"I enter my Address")]
        public void GivenIEnterMyAddress()
        {
            _registrationPage.clickaddress();
        }
        
        [Given(@"I enter my Town/city")]
        public void GivenIEnterMyTownCity()
        {
            _registrationPage.clickcity();
        }
        
        [Given(@"I enter my State")]
        public void GivenIEnterMyState()
        {
            _registrationPage.clickstate();
        }
        
        [When(@"I click on the Create Account button")]
        public void WhenIClickOnTheCreateAccountButton()
        {
            _registrationPage.clickcreateaccountbutton();
        }


        [Then(@"a message should appear ""(.*)""")]
        public void ThenAMessageShouldAppear(string sucessMessage)
        {
            var expectedMessage =_registrationPage.SuccessNotificationDisplayed();
            expectedMessage.Should().Contain(sucessMessage);
        }


        [Given(@"I omit to enter Phone number")]
        public void GivenIOmitToEnterPhoneNumber()
        {
            _registrationPage.clickandomitphone();
        }


        [Then(@"I should not be registered")]
        public void ThenIShouldNotBeRegistered()
        {
           
        }

    }
}
