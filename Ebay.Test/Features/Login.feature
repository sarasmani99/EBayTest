Feature: Login
	Login to ebay

@login @errorMessages
Scenario: 01-Verify error messages when logging in without username or password
	Given I launched ebay application
	When I clicked on MyEbay link
	And I enter user name as 'some-known-user-83838'
	And I click on continue button
	Then I should see error message "Oops, that's not a match."