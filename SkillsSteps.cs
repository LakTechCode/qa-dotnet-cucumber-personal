using qa_dotnet_cucumber.Pages;
using Reqnroll;
using System;

namespace qa_dotnet_cucumber
{
    [Binding]
    public class SkillsSteps
    {
        private readonly LoginPage _loginPage;
        private readonly NavigationHelper _navigationHelper;
        private readonly SkillsPage _skillsPage;

        public SkillsSteps(LoginPage loginPage, NavigationHelper navigationHelper, SkillsPage skillsPage)
        {
            _loginPage = loginPage;
            _navigationHelper = navigationHelper;
            _skillsPage = skillsPage;
        }

        [Given("I am logged in and on Skills page")]
        public void GivenIAmLoggedInAndOnSkillsPage()
        {
            _navigationHelper.NavigateTo("");
            _loginPage.ClickSignIn();
            _loginPage.Login("test@test.com", "123123");

            _skillsPage.Click 
        }

        [When("I click the Add New button on Skills page")]
        public void WhenIClickTheAddNewButtonOnSkillsPage()
        {
            throw new PendingStepException();
        }

        [When("I enter the skill")]
        public void WhenIEnterTheSkill()
        {
            throw new PendingStepException();
        }

        [When("I select the level")]
        public void WhenISelectTheLevel()
        {
            throw new PendingStepException();
        }

        [When("I click the Add button on Skills page")]
        public void WhenIClickTheAddButtonOnSkillsPage()
        {
            throw new PendingStepException();
        }

        [Then("I should see an appropriate message for Skills page")]
        public void ThenIShouldSeeAnAppropriateMessageForSkillsPage()
        {
            throw new PendingStepException();
        }

        [When("I click on the Cancel button on Skills page")]
        public void WhenIClickOnTheCancelButtonOnSkillsPage()
        {
            throw new PendingStepException();
        }

        [Then("the Skill {string} should not be added to the list")]
        public void ThenTheSkillShouldNotBeAddedToTheList(string selenium)
        {
            throw new PendingStepException();
        }

        [Given("skill and level is listed")]
        public void GivenSkillAndLevelIsListed()
        {
            throw new PendingStepException();
        }

        [When("I add the same skill again")]
        public void WhenIAddTheSameSkillAgain()
        {
            throw new PendingStepException();
        }

        [When("I leave the skill and level fields empty")]
        public void WhenILeaveTheSkillAndLevelFieldsEmpty()
        {
            throw new PendingStepException();
        }

        [When("I click the edit icon next to a skill")]
        public void WhenIClickTheEditIconNextToASkill()
        {
            throw new PendingStepException();
        }

        [When("I change the level on Skills page")]
        public void WhenIChangeTheLevelOnSkillsPage()
        {
            throw new PendingStepException();
        }

        [When("I click on the Update button on Skills page")]
        public void WhenIClickOnTheUpdateButtonOnSkillsPage()
        {
            throw new PendingStepException();
        }

        [When("I change the skill")]
        public void WhenIChangeTheSkill()
        {
            throw new PendingStepException();
        }

        [When("I click on the Cancel button on Edit Page for Skills page")]
        public void WhenIClickOnTheCancelButtonOnEditPageForSkillsPage()
        {
            throw new PendingStepException();
        }

        [Then("the skill and level should remain unchanged")]
        public void ThenTheSkillAndLevelShouldRemainUnchanged()
        {
            throw new PendingStepException();
        }

        [When("I click the delete icon next to a skill")]
        public void WhenIClickTheDeleteIconNextToASkill()
        {
            throw new PendingStepException();
        }

        [Then("the skill {string} should be deleted")]
        public void ThenTheSkillShouldBeDeleted(string selenium)
        {
            throw new PendingStepException();
        }


    }
}
