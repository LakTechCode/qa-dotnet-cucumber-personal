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
            Thread.Sleep(2000);
            var addSkillMessage = addSkillMessageElement.Text;
            Assert.That(addSkillMessage, Does.Match("has been added to your skills|has been updaed to your skills|This skill is already exist in your skill list|Please enter skill and experience level"),
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
            _skillsPage.AddSkill("Selenium");
        }

        [When("I leave the skill and level fields empty")]
        public void WhenILeaveTheSkillAndLevelFieldsEmpty()
        {
            _skillsPage.AddSkill("");
            _skillsPage.AddSkillLevel("Choose Skill Level");
        }

        [When("I click the edit icon next to a skill")]
        public void WhenIClickTheEditIconNextToASkill()
        {
            _skillsPage.ClickEditonSkills();
        }

        [When("I change the level on Skills page")]
        public void WhenIChangeTheLevelOnSkillsPage()
        {
            _skillsPage.UpdateSkillLevel("Intermediate");
        }


        [When("I click on the Update button on Skills page")]
        public void WhenIClickOnTheUpdateButtonOnSkillsPage()
        {
            _skillsPage.ClickUpdateonSkills();
        }

        [When("I change the skill")]
        public void WhenIChangeTheSkill()
        {
            _skillsPage.UpdateSkill("JIRA");
        }

        [When("I click on the Cancel button on Edit Page for Skills page")]
        public void WhenIClickOnTheCancelButtonOnEditPageForSkillsPage()
        {
            {
                _skillsPage.ClickCancelinEditPageforSkills();
            }
        }

        [Then("the skill and level should remain unchanged")]
        public void ThenTheSkillAndLevelShouldRemainUnchanged()
        {
            var actualLanguage = _skillsPage.GetSkill();
            var actualLevel = _skillsPage.GetLevel();

            Assert.That(actualLanguage, Is.EqualTo("Selenium"), "Language did not match expected.");
            Assert.That(actualLevel, Is.EqualTo("Beginner"), "Level did not match expected.");
        }

        [When("I click the delete icon next to a skill")]
        public void WhenIClickTheDeleteIconNextToASkill()
        {
            _skillsPage.ClickDeleteonSkills();
        }

        [Then("the skill {string} should be deleted")]
        public void ThenTheSkillShouldBeDeleted(string skill)
        {
            Assert.That(_skillsPage.IsSkillInList(skill), Is.False, $"'{skill}' should be deleted but is still present in the list.");
        }


    }
}
