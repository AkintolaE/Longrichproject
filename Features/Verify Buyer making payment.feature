Feature: Verify Buyer making payment
	As a Buyer I want to be able to make payment
	So that I can complete my purchase 

@mytag
Scenario: Buyer making payment
	Given I navigate to https://longrichway.com/
	When I click on categoryField 
	And  click on Skincare 
	And click on selected item 
	And click addCartField 
	And click checkOutField
	And  enter emailTextField "atolayomi@gmail.com"
	And  enter passwordField "kidney"
	And click on the loginField 
	And  click on delivery option
	And click address button 
	And click on payment option
	And I  click on the complete order button 
	Then I should be able to make payment with my card details



	