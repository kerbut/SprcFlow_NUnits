Feature: ChatFeature
	

Scenario: Successful sending message
	Given Chat page is opened
	And User authorized
	| Login | Passworld |
	| Elmar | 329718    |
	When I send message <message> in text field
	And  I click Send message button
	Then Message with text <message> is displayed from authorized user
	Then fg dfg dfs sdfgh 
	#Examples: 
	#| message     |
	#| hello world |
	#| I am here   |
	#| !@#$%^&&*   |
	

	#Scenario Outline: Successful sending message
	#Given User existed
	#And Login page is opened
	#And User authorized
	#When I send message <message> in text field
	#And  I click Send message button
	#Then Message with text <message> is displayed from authorized user
	#And Data base contains message <message> from current user
	#| User    | Path                      |
	#| current | [Chat].[Users].[Messages] |
	#Examples: 
	#| message     |
	#| hello world |
	#| I am here   |
	#| !@#$%^&&*   |