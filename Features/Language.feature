Feature: Language functionality
As a user, I want to add, edit, and delete languages with proficiency level so that I can accurately showcase my language skills

Background:
Given I am logged in 

Scenario: Add a new language
	When I click the Add New button
    And I enter the language
    And I select the level of proficiency 
    And I click on the Add button
    Then the language and the level should be displayed in the list

Scenario: Cancel adding a new language
    When I click the Add New button
    And I enter the language
    And I select the level of proficiency
    And I click on the Cancel button
    Then the language should not be added to the list

Scenario: Prevent adding an existing language
    When I click the Add New button
    And I add the same language again
    And I select the level of proficiency
    And I click on the Add button
    Then I should see an error message

Scenario: Prevent adding a language with empty fields
    When I click the Add New button
    And I leave the language and level fields empty
    And I click on the Add button
    Then I should see an error message

 Scenario: User adds four languages successfully
    When the user clicks Add New
    And the user enters the first language and selects a language level
    And the user clicks Add
    And the user repeats adding three more languages with different language levels
    Then the user should see all four languages added successfully

  Scenario: User tries to add a fifth language
    Given the user has already added four languages on the Homepage
    When the user looks for the Add New button
    Then the Add New button should not be visible

  Scenario: Edit an existing language level
    Given language and level is listed
    When I click the edit icon next to a language
    And I change the level 
    And I click on the Update button
    Then the level should be updated

  Scenario: Edit an existing language 
    Given language and level is listed
    When I click the edit icon next to a language
    And I change the language 
    And I click on the Update button
    Then the level should be updated

Scenario: Cancel editing a language
   Given language and level are listed
   When I click the edit icon next to a language
   And I change the language name or level
   And I click on the Cancel button
   Then the language and level should remain unchanged
   
   Scenario: Delete an existing language
    Given language and level is listed
    When I click the delete icon next to a language
    Then the level should be updated

