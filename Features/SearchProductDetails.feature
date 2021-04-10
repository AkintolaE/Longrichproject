Feature: SearchProductDetails
	As a User
	I want to be able to navigate to the Longrichway website
	So that I can search for product with detailed description
@mytag
Scenario: Search for product in detail 
	Given I open browser "https://longrichway.com/home"
	When I click on category 
	And I select skincare
	And I click on displayed product
	Then I should be able to see the product with detailed description