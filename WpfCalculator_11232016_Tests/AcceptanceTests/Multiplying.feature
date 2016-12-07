Feature: Multiplying

@UI
Scenario: Multiply two numbers
	Given I have launched the calculator
	When I push the "4" button
	And I push the "*" button
	And I push the "6" button
	And I push the "=" button
	Then the displayed value is "24"