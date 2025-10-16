using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using qa_dotnet_cucumber.Pages;
using RazorEngine;
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

            _skillsPage.ClickSkills(); 
        }

        [When("I click the Add New button on Skills page")]
        public void WhenIClickTheAddNewButtonOnSkillsPage()
        {
            _skillsPage.ClickAddNewonSkills();
        }

        [When("I enter the skill")]
        public void WhenIEnterTheSkill()
        {
            _skillsPage.AddSkill("Selenium");
        }

        [When("I select the level")]
        public void WhenISelectTheLevel()
        {
            _skillsPage.AddSkillLevel("Beginner");
        }

        [When("I click the Add button on Skills page")]
        public void WhenIClickTheAddButtonOnSkillsPage()
     
        {
            _skillsPage.ClickAddonSkills();
        }

        [Then("I should see an appropriate message for Skills page")]
        public void ThenIShouldSeeAnAppropriateMessageForSkillsPage()
        {
            var wait = new WebDriverWait(_skillsPage.Driver, TimeSpan.FromSeconds(10));
            var addSkillMessageElement = wait.Until(d => d.FindElement(By.XPath("/html/body/div[1]/div")));
            Thread.Sleep(1000);
            var addSkillMessage = addSkillMessageElement.Text;
            Assert.That(addSkillMessage, Does.Match("has been added to your skills|has been updaed to your skills"),
                "Should see an appropriate message"); ;
        }

        [When("I click on the Cancel button on Skills page")]
        public void WhenIClickOnTheCancelButtonOnSkillsPage()
        {
            _skillsPage.ClickCancelonSkills();
        }

        [Then("the Skill {string} should not be added to the list")]
        public void ThenTheSkillShouldNotBeAddedToTheList(string skill)
        {

            Assert.That(_skillsPage.IsSkillInList(skill), Is.False, $"'{skill}' should not be added after cancel.");
        }

        [Given("skill and level is listed")]
        public void GivenSkillAndLevelIsListed()
        {
            _skillsPage.ClickAddNewonSkills();
            _skillsPage.AddSkill("Selenium");
            _skillsPage.AddSkillLevel("Beginner");
            _skillsPage.ClickAddonSkills();
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
            _skillsPage.ClickEditonSkills();
        }

        [When("I change the level on Skills page")]
        public void WhenIChangeTheLevelOnSkillsPage()
        {
            throw new PendingStepException();
        }

        [When("I click on the Update button on Skills page")]
        public void WhenIClickOnTheUpdateButtonOnSkillsPage()
        {
            _skillsPage.UpdateSkill("JIRA");
        }

        [When("I change the skill")]
        public void WhenIChangeTheSkill()
        {  throw new PendingStepException(); }

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
