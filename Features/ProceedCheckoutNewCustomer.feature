Feature: ProceedCheckoutNewCustomer
	As a new customer 
	I want to checkout my products
	So I can complete my order

@mytag
Scenario:Checkout as a new customer
	Given I navigate to https://longrichway.com/home
	When I click on categories 
	And click on Nutrition 
	And click on selected product
	And click add to cart button 
	And the cart page is displayed
	And click on the checkout button
	And click on New Customer? Quick Registration Button
	And I enter my First Name "Jessee"  
	And I enter my Last Name "Jones"
	And I enter my EmailAddress "atolayomi+70@gmail.com"
	And I enter my PhoneNumber "01234848993"
	And I enter my Password "donkey"
	And I enter my ConfirmPassword "donkey"
	And I enter my Address "Flat 4 Strathmore Court"
	And I enter my Town/City "Wimbledon"
	And I enter my State "London"
	And I click on Create Account button
	Then a message should appear Registration successful 
	#Then  user account page is displayed
	
    
	#Examples: 
	#| FirstName | LastName | EmailAddress          | PhoneNumber | Password  | ConfirmPassword | Address                          | TownCity  | State  |  
	#| Jessee    | Jones    | atolayomi+6@gmail.com | 07508651162 | Achievers | Achievers       | Flat 4 Strathmore Court,SW19 8DD | Wimbledon | London |