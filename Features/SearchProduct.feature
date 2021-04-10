Feature: SearchProduct
	As a Customer
I want to be able to navigate to the Longrichway website
So that I can search for products   

@mytag
Scenario: Search for products by categories 
	Given I navigate to "https://longrichway.com/"
	When I click on categories for products
	And I select   nutrition
	Then I should be able to see the products and the price