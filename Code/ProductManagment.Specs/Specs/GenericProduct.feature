Feature: GenericProduct
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Root Generic Product
	Given I have a generic product called 'Mobile Phone'
	And 'Mobile Phone' has the following constraints
	| Constraint | Type         | Value               | UOM |
	| Weight     | NumericRange | 50-1000             | GR  |
	| Guarantee  | Boolean      |                     |     |
	| OS         | Selective    | IOS-Android-Symbian |     |
	When I register the 'Mobile Phone'
	Then It should be appear in the list of products

	Scenario: Child Generic Product with limited constaints
	Given I have a generic product called 'Mobile Phone'
	And 'Mobile Phone' has the following constraints
	| Constraint | Type         | Value               | UOM |
	| Weight     | NumericRange | 50-1000             | GR  |
	| Guarantee  | Boolean      |                     |     |
	| OS         | Selective    | IOS-Android-Symbian |     |
	And I have a generic product called 'Smart Mobile Phone' with parent 'Mobile Phone'
	And 'Smart Mobile Phone' has the following constraints
	| Constraint | Type         | Value       | UOM |
	| Weight     | NumericRange | 50-300      | GR  |
	| Guarantee  | Boolean      |             |     |
	| OS         | Selective    | IOS-Android |     |
	When I register the 'Smart Mobile Phone'
	Then It should be appear in the list of products