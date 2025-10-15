@Skills
Feature: Skills

As a user, I want to add, edit, and delete skills with appropriate skill level so that I can accurately showcase my skills

Background: 
Given I am logged in and on Skills page

Scenario: Add a new skill
	When I click the Add New button on Skills page
	And I enter the skill
	And I select the level
	And I click the Add button on Skills page
	Then I should see an appropriate message for Skills page

Scenario: Cancel adding a new skill
    When I click the Add New button on Skills page
    And I enter the skill
    And I select the level 
    And I click on the Cancel button on Skills page
    Then the Skill "Selenium" should not be added to the list

Scenario: Prevent adding an existing skill
    Given skill and level is listed
    When I click the Add New button on Skills page
    And I add the same skill again
    And I select the level 
    And I click the Add button on Skills page
    Then I should see an appropriate message for Skills page

Scenario: Prevent adding a skill with empty fields
    When I click the Add New button on Skills page
    And I leave the skill and level fields empty
    And I click the Add button on Skills page
    Then I should see an appropriate message for Skills page

Scenario: Edit an existing skill level
    Given skill and level is listed
    When I click the edit icon next to a skill
    And I change the level on Skills page
    And I click on the Update button on Skills page
     Then I should see an appropriate message for Skills page

  Scenario: Edit an existing skill 
    Given skill and level is listed
    When I click the edit icon next to a skill
    And I change the skill 
    And I click on the Update button on Skills page
    Then I should see an appropriate message for Skills page

Scenario: Cancel editing a skill
   Given skill and level is listed
   When I click the edit icon next to a skill
   And I change the skill 
   And I click on the Cancel button on Edit Page for Skills page
   Then the skill and level should remain unchanged
   
   Scenario: Delete an existing skill
    Given skill and level is listed
    When I click the delete icon next to a skill
    Then the skill "Selenium" should be deleted

