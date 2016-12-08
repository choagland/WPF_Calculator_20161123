Feature: Dividing
	
@UI
Scenario: Dividing two numbers
	Given I have launched the calculator
	When I push the "4" button
	And I push the "2" button
	And I push the "/" button
	And I push the "2" button
	And I push the "=" button
	Then the displayed value is "21"
	
