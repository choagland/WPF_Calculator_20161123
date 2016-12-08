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
	
Scenario: Dividing to a fractional quotient
	Given I have launched the calculator
	When I push the "3" button
	And I push the "/" button
	And I push the "2" button
	And I push the "=" button
	Then the displayed value is "1.5"

Scenario: Dividing to a repeating decimal
	Given I have launched the calculator
	When I push the "1" button
	And I push the "/" button
	And I push the "3" button
	And I push the "=" button
	Then the displayed value is "0.333333333333333"
