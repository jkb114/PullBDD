Feature: Feature1


Scenario Outline: Feature1
	Given I am Launching $Pull
	Then I want to View all the users
	Then I Pull a user
	Then I login using "<Username>" and "<Password>"

	Examples: 
	| Username | Password  |
	| admin    | Goddess13 |