Feature: Cartfeature
As a user I want to be able to see 
selected  product with costs in the cart 


@mytag
Scenario: Display product with costs in the cart
	Given I navigate to "https://longrichway.com/"
	And I click on categories for products
	And I select  category skincare
    Then the product and retail price is displayed