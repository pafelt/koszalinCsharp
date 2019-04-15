Feature: CalcScenario
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Simple
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen


@Table
Scenario Outline: : Add two numbers from Table
	Given I have entered <base> into the calculator
	And I have entered <addedValue> into the calculator
	When I press add
	Then the result should be <result> on the screen

Examples: 
| base | addedValue | result |
| 1    | 2          | 3      |
| 4    | 5          | 9      |
| 10   | 12         | 22     |


@Simple
Scenario: Table Test
	Given I have login with credentials
	| Key   | Value |
	| Login | fake  |
	| Pass  | fake  |
	And I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
