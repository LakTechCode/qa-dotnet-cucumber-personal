using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using qa_dotnet_cucumber.Pages;
using Reqnroll;
using System;

namespace qa_dotnet_cucumber.Steps
{
    [Binding]
    public class LanguageSteps 

    {
        private readonly LoginPage _loginPage;
        private readonly NavigationHelper _navigationHelper;
        private readonly LanguagePage _languagePage;
      
        public LanguageSteps(LoginPage loginPage, NavigationHelper navigationHelper, LanguagePage languagePage)
        {
            _loginPage = loginPage;
            _navigationHelper = navigationHelper;
            _languagePage = languagePage;
        }

        [Given("I am logged in")]
        public void GivenIAmLoggedIn()
        {
            {
                _navigationHelper.NavigateTo("");

                _loginPage.ClickSignIn();
                _loginPage.Login("test@test.com", "123123");

                var successMessage = _loginPage.GetSuccessMessage();
                Assert.That(successMessage, Does.Contain("Hi Lakshmi"), "Should see successful login message");
            }
        }

        [When("I click the Add New button")]
        public void WhenIClickTheAddNewButton()
        {
            _languagePage.ClickAddNew();
        }

        [When("I enter the language")]
        public void WhenIEnterTheLanguage()
        {
            _languagePage.AddLanguage("English");
            
  

        }


        [When("I select the level of proficiency")]
        public void WhenISelectTheLevelOfProficiency()
        {
            _languagePage.ProficiencyLevel("Fluent");
        }

        [When("I click on the Add button")]
        public void WhenIClickOnTheAddButton()
        {
            _languagePage.ClickAdd();
        }

        [When("I click on the Cancel button")]
        public void WhenIClickOnTheCancelButton()
        {
            _languagePage.ClickCancel();
        }

        [Then("I should see an appropriate message")]
        public void ThenIShouldSeeAnAppropriateMessage()
        {
            var wait = new WebDriverWait(_loginPage.Driver, TimeSpan.FromSeconds(10));
            var addLanguageMessageElement = wait.Until(d => d.FindElement(By.XPath("/html/body/div[1]/div")));
            var addLanguageMessage = addLanguageMessageElement.Text;
            Assert.That(addLanguageMessage, Does.Match("has been added to your languages|This language is already exist in your language list"),
                "Should see an appropriate message");
        }


        [Then("the language {string} should not be added to the list")]
        public void ThenTheLanguageShouldNotBeAddedToTheList (string language)
        {
      
       Assert.That(_languagePage.IsLanguageInList(language), Is.False,$"'{language}' should not be added after cancel.");
        }


        [When("I add the same language again")]
        public void WhenIAddTheSameLanguageAgain()
        {
            throw new PendingStepException();
        }

        [When("I leave the language and level fields empty")]
        public void WhenILeaveTheLanguageAndLevelFieldsEmpty()
        {
            throw new PendingStepException();
        }

        [When("the user clicks Add New")]
        public void WhenTheUserClicksAddNew()
        {
            throw new PendingStepException();
        }

        [When("the user enters the first language and selects a language level")]
        public void WhenTheUserEntersTheFirstLanguageAndSelectsALanguageLevel()
        {
            throw new PendingStepException();
        }

        [When("the user clicks Add")]
        public void WhenTheUserClicksAdd()
        {
            throw new PendingStepException();
        }

        [When("the user repeats adding three more languages with different language levels")]
        public void WhenTheUserRepeatsAddingThreeMoreLanguagesWithDifferentLanguageLevels()
        {
            throw new PendingStepException();
        }

        [Then("the user should see all four languages added successfully")]
        public void ThenTheUserShouldSeeAllFourLanguagesAddedSuccessfully()
        {
            throw new PendingStepException();
        }

        [Given("the user has already added four languages on the Homepage")]
        public void GivenTheUserHasAlreadyAddedFourLanguagesOnTheHomepage()
        {
            throw new PendingStepException();
        }

        [When("the user looks for the Add New button")]
        public void WhenTheUserLooksForTheAddNewButton()
        {
            throw new PendingStepException();
        }

        [Then("the Add New button should not be visible")]
        public void ThenTheAddNewButtonShouldNotBeVisible()
        {
            throw new PendingStepException();
        }

        [Given("language and level is listed")]
        public void GivenLanguageAndLevelIsListed()
        {
            throw new PendingStepException();
        }

        [When("I click the edit icon next to a language")]
        public void WhenIClickTheEditIconNextToALanguage()
        {
            throw new PendingStepException();
        }

        [When("I change the level")]
        public void WhenIChangeTheLevel()
        {
            throw new PendingStepException();
        }

        [When("I click on the Update button")]
        public void WhenIClickOnTheUpdateButton()
        {
            throw new PendingStepException();
        }

        [Then("the level should be updated")]
        public void ThenTheLevelShouldBeUpdated()
        {
            throw new PendingStepException();
        }

        [When("I change the language")]
        public void WhenIChangeTheLanguage()
        {
            throw new PendingStepException();
        }

        [Given("language and level are listed")]
        public void GivenLanguageAndLevelAreListed()
        {
            throw new PendingStepException();
        }

        [When("I change the language name or level")]
        public void WhenIChangeTheLanguageNameOrLevel()
        {
            throw new PendingStepException();
        }

        [Then("the language and level should remain unchanged")]
        public void ThenTheLanguageAndLevelShouldRemainUnchanged()
        {
            throw new PendingStepException();
        }

        [When("I click the delete icon next to a language")]
        public void WhenIClickTheDeleteIconNextToALanguage()
        {
            throw new PendingStepException();
        }
    }
}
