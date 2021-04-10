Feature:Registration
	As a user I want to be able to register on the Lonrich way website 

@mytag
Scenario: Valid Registration
	Given I navigate to the Longrich way website 
	And I click on the Register Button
	And I enter my First name 
	And I enter my Last name 
	And I enter my Email address
	And I enter my Phone number 
	And I enter my Password 
	And I enter my Confirm Password 
	And I enter my Address
	And I enter my Town/city
	And I enter my State 
	When I click on the Create Account button
    Then a message should appear "SUCCESS NOTIFICATION"


Scenario: Invalid Registration
    Given I navigate to the Longrich way website 
	And I click on the Register Button
	And I enter my First name 
	And I enter my Last name 
	And I enter my Email address
	And I omit to enter Phone number 
	And I enter my Password 
	And I enter my Confirm Password 
	And I enter my Address
	And I enter my Town/city
	And I enter my State 
	When I click on the Create Account button
    Then I should not be registered
