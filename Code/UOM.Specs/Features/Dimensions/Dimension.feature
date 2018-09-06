Feature: Dimension
	In order to measure in different dimensions
	As an administrator
	I want to be able to manage dimensions

Scenario: register a new dimension
	Given I have defined a new dimension as following
	| Title  | Title 2 | Symbol |
	| Length | طول     | L      |
	When I register the dimension
	Then the dimension should be appear in the list of dimensions

Scenario: register a dimension with duplicate symbol
	Given I have already registered a dimension with 'L' symbol
	And I have defined a new dimension as following
	| Title  | Title 2 | Symbol |
	| Length | طول     | L      |
	When I register the dimension 
	Then the system should warned me that dimension is duplicated