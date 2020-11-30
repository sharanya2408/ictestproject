Feature: Horse Portal

Scenario: Verify the user is able to login into the portal

#GHERKIN language
Given I navigate to the portal

When I add credentials to the login page 
Then I verify that the user is able to login into the portal
When I add Time and material records.
Then I verify that the entered records.

Scenario: verify the user is able to enter the customer details.

Given I login into the portal using valid credentials.
When I add customers records by clicking create new.
Then I validate the records entered.

Scenario: verify whether the user is able to navigate from Time material to customers 

Given I login into the portal using valid credentials
When I enter valid TM records.
Then I navigate back to customer.

	