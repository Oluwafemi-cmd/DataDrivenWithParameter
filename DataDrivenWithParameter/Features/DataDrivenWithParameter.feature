Feature: DataDrivenWithParameter

As a user 
In order to enjoy this website, i should be able to sign up  successfully

@tag1
Scenario: Data Driven With Parameter
	Given I navigate to "https://angularjs.realworld.io/"
	And I click on Sign up
	And I enter my Username "Hary5441"
	And I enter my Email "mok6@aol.com"
	And I enter my Password "Pocole123"
	When I click on Sign up button 
	Then I should be able to sign up successfully 
