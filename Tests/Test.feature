Feature: Multi-Instance Application 

Scenario:  Should initialize default instance
	Given I add to context
		| k | v  |
		| a | 10 |

Scenario: Should switch between instances
	Given I add to context
		| k | v   |
		| a | 100 |
		| b | 200 |
	Given I switch to 1
	Given I add to context
		| k | v  |
		| a | 10 |
		| b | 20 |

Scenario: Resolver should access to instance context 
	Given I add to context
		| k | v  |
		| a | 10 |
	Given I copy from a to b
	Given I switch to 1
	Given I add to context
		| k | v  |
		| a | 10 |
	Given I copy from a to b
