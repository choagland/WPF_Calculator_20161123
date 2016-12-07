Feature: Subtracting
	
@UI
Scenario: Subtract two numbers
	Given I have launched the calculator
	When I push the "3" button
	And I push the "-" button
	And I push the "2" button
	And I push the "=" button
	Then the displayed value is "1"
