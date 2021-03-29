Feature: Calculator

@mytag
Scenario Outline: Add numbers
	Given open the calculator in <view> view
	And enter the number <number1>
	And click add button
	And enter the number <number2>
	And click equals button
	And click memory add button
	And enter the number <number3>
	And click add button
	And click memory reccall button
	And click equals button
	Then result should be <result>
	And close the calculator
Examples:
|    view    | number1 | number2 | number3 | result |
| Standard   |    12   |    999  |    19   |  1030  |
| Scientific |    12   |    999  |    19   |  1030  |
 