Feature: Language functionality
As a user, I want to add, edit, and delete languages with proficiency level so that I can accurately showcase my language skills

Background:
Given I am logged in 

Scenario: Add a new language
	When I click the Add New button
    And I enter the language
    And I select the level of proficiency 
    And I click on the Add button
    Then I should see an appropriate message

Scenario: Cancel adding a new language
    When I click the Add New button
    And I enter the language
    And I select the level of proficiency
    And I click on the Cancel button
    Then the language "English" should not be added to the list

Scenario: Prevent adding an existing language
    Given language and level is listed
    When I click the Add New button
    And I add the same language again
    And I select the level of proficiency
    And I click on the Add button
    Then I should see an appropriate message

Scenario: Prevent adding a language with empty fields
    When I click the Add New button
    And I leave the language and level fields empty
    And I click on the Add button
    Then I should see an appropriate message

  Scenario: User tries to add a fifth language
    When the user has already added four languages on the Homepage
    Then the Add New button should not be visible

  Scenario: Edit an existing language level
    Given language and level is listed
    When I click the edit icon next to a language
    And I change the level 
    And I click on the Update button
     Then I should see an appropriate message

  Scenario: Edit an existing language 
    Given language and level is listed
    When I click the edit icon next to a language
    And I change the language 
    And I click on the Update button
    Then I should see an appropriate message

Scenario: Cancel editing a language
   Given language and level is listed
   When I click the edit icon next to a language
   And I change the language 
   And I click on the Cancel button on Edit Page
   Then the language and level should remain unchanged
   
   Scenario: Delete an existing language
    Given language and level is listed
    When I click the delete icon next to a language
    Then the level should be updated

