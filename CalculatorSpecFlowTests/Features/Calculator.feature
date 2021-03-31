Feature: Calculator

@test
Scenario Outline: Add numbers
	Given I open the calculator in <view> view
	When I enter the number <number1>
	And I click add button
	And I enter the number <number2>
	And I click equals button
	And I click memory add button
	And I enter the number <number3>
	And I click add button
	And I click memory reccall button
	And I click equals button
	Then result should be <result>
Examples:
|    view    | number1 | number2 | number3 | result |
| Обычный    |    12   |    999  |    19   |  1030  |
| Инженерный |    12   |    999  |    19   |  1030  |
 