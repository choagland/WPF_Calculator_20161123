Feature: CalculatorLaunch

@UI
Scenario: Calculator Title
	Given I have launched the calculator
	Then the calculators window title is "WPF Calculator"
