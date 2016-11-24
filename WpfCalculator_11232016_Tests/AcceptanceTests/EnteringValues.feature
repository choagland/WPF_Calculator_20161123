Feature: Entering Values

@UI
Scenario: Punch In An Addend
	Given I have launched the calculator
	When I push the "1" button
	And I push the "2" button
	And I push the "3" button
	And I push the "4" button
	And I push the "5" button
	And I push the "6" button
	And I push the "7" button
	And I push the "8" button
	And I push the "9" button
	And I push the "0" button
	Then the displayed value is "1234567890"