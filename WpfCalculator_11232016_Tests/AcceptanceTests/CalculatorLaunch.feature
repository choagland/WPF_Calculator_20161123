Feature: CalculatorLaunch

@UI
Scenario: Calculator Title
	Given I have launched the calculator
	Then the calculators window title is "WPF Calculator"

Scenario: Initial Value is Zero
	Given I have launched the calculator
	Then the displayed value is "0"
