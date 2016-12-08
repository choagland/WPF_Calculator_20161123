Feature: Entering Values

@UI
Scenario: Punch In An Numerend
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

@UI
Scenario: Clear the Displayed Value
	Given I have launched the calculator
	When I push the "1" button
	And I push the "C" button
	Then the displayed value is "0"

@UI
Scenario: Type in the numerends
	Given I have launched the calculator
	When I type "1"
	And I type "2"
	Then the displayed value is "12"

@UI
Scenario: Clear with the C key
	Given I have launched the calculator
	When I push the "1" button
	And I type "C" 
	Then the displayed value is "0"

@UI
Scenario: Reject letters other than C
	Given I have launched the calculator
	When I type "1"
	And I type "abdefghijklmnopqrstuvwxyz"
	Then the displayed value is "1"

@UI
Scenario: Allow entry of decimal values from the keyboard
	Given I have launched the calculator
	When I type "1"
	And I type "."
	And I type "2"
	Then the displayed value is "1.2"