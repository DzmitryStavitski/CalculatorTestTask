Feature: Calculator

@mytag
Scenario: Add two numbers
	Given open the calculator
	And enter the number 12
	And click add button
	And enter the number 999
	And click equals button
	And click memory add button
	And enter the number 19
	And click add button
	And click memory reccall button
	And click equals button
	Then result should be 1030
	And close the calculator