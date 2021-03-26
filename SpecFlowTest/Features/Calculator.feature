Feature: Calculator

@mytag
Scenario: Add two numbers
	Given the first number is 1000
	And the second number is 1
	When the two numbers are added
	Then the result should be 1001