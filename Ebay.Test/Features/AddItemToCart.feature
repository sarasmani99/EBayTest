Feature: AddItemToCard

@addItem
Scenario Outline: 01-Verify item added to cart is displayed in the cart
	Given I launched ebay application
	When I searched for <item>
	And I click on 1 item
	And I add item in to the cart
	Then I should see added item in the cart
	
	Examples: 
	| item		|
	| city bike |