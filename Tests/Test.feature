Feature: Test

@mytag
Scenario: Get Instances
	Given I add to context
		| k | v   |
		| 1 | 100 |
		| 2 | 200 |
	Given I switch to 1
	Given I add to context
		| k | v  |
		| 1 | 10 |
		| 2 | 20 |

Scenario: Get 2
	Given I switch to 2
