Feature: Login
	As a Customer
I want to be able to login to the Longrichway website with my email and password
So that I can buy products   

@mytag
Scenario: Login as a customer
	Given that I navigate to https://longrichway.com/home
	When I click on login 
	And I enter email 
	And I enter password
	And I click on the login button
	Then the landing page is displayed 
	And  I select categories 
	And I select Feminine care category 
	And I select snake oil uk 
	And I click 1 snake oil uk to cart 
	And I click view your shopping cart 
	And I click on checkout button 
	Then check out page is displayed 
	