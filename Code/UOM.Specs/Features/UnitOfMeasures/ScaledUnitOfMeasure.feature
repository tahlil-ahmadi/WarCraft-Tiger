Feature: Converting unit of measures 
	
Scenario: Converting scaled to base unit of measure
	Given I have already registered a base uom as following
	| IsoCode | Title |
	| GR      | Gram  |
	And I have already registered a scaled uom as following
	| BaseUom | IsoCode | Title    | Factor |
	| GR      | KG      | Kilogram | 1000   |
	When I try to convert '200' 'GR' to 'KG'
	Then The result should be '0.2' 'KG'

Scenario: Converting scaled to another scaled unit of measure
	Given I have already registered a base uom as following
		| IsoCode | Title |
		| GR      | Gram  |
	And I have already registered a scaled uom as following
	| BaseUom | IsoCode | Title    | Factor |
	| GR      | KG      | Kilogram | 1000   |
	And I have already registered a scaled uom as following
	| BaseUom | IsoCode | Title             | Factor |
	| GR      | HK      | Hundred Kilograms | 100000   |
	When I try to convert '1000' 'KG' to 'HK'
	Then The result should be '0.01' 'HK'