Feature: Homepage_feature

A short summary of the feature

@tag1
Scenario: User Visit to Web Page
	Given That I am on the telerik web site
	When I click the web link
	Then I see the other options

@tag2
Scenario: When user select services option
	Given That I am on the telerik web site
	When I click the services link 
	Then services page should display

@tag3
Scenario: When user select blogs option
	Given That I am on the telerik web site
	When I click the blogs link
	Then blogs page should display

@tag4
Scenario: When user select prices option
	Given That I am on the telerik web site
	When I Click the prices link
	Then prices page should display

