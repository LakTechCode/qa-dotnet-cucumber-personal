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
            _languagePage.ProficiencyAddLevel("Fluent");
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
            Assert.That(addLanguageMessage, Does.Match("has been added to your languages|This language is already exist in your language list|Please enter language and level|has been updated to your languages"),
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
            _languagePage.AddLanguage("English");
        }

        [When("I leave the language and level fields empty")]
        public void WhenILeaveTheLanguageAndLevelFieldsEmpty()
        {
            _languagePage.AddLanguage("");
            _languagePage.ProficiencyAddLevel("Choose Language Level");
        }

   
        [When("the user has already added four languages on the Homepage")]
        public void GivenTheUserHasAlreadyAddedFourLanguagesOnTheHomepage()
        {
            _languagePage.ClickAddNew();
            _languagePage.AddLanguage("English");
            _languagePage.ProficiencyAddLevel("Fluent");
            _languagePage.ClickAdd();

            _languagePage.ClickAddNew();
            _languagePage.AddLanguage("Tamil");
            _languagePage.ProficiencyAddLevel("Native/Bilingual");
            _languagePage.ClickAdd();

            _languagePage.ClickAddNew();
            _languagePage.AddLanguage("Hindi");
            _languagePage.ProficiencyAddLevel("Conversational");
            _languagePage.ClickAdd();

            _languagePage.ClickAddNew();
            _languagePage.AddLanguage("Maori");
            _languagePage.ProficiencyAddLevel("Basic");
            _languagePage.ClickAdd();

        }

        [Then("the Add New button should not be visible")]
        public void ThenTheAddNewButtonShouldNotBeVisible()
        {
            Assert.That(_languagePage.IsAddNewButtonVisible(), Is.False, "'Add New' button should not be visible.");
        }

        [Given("language and level is listed")]
        public void GivenLanguageAndLevelIsListed()
        {
            _languagePage.ClickAddNew();
            _languagePage.AddLanguage("English");
            _languagePage.ProficiencyAddLevel("Fluent");
            _languagePage.ClickAdd();
        }

        [When("I click the edit icon next to a language")]
        public void WhenIClickTheEditIconNextToALanguage()
        {
            _languagePage.ClickEdit();
        }

        [When("I change the level")]
        public void WhenIChangeTheLevel()
        {
            _languagePage.ProficiencyUpdateLevel("Basic");
        }

        [When("I click on the Update button")]
        public void WhenIClickOnTheUpdateButton()
        {
            _languagePage.ClickUpdate();
        }


        [When("I change the language")]
        public void WhenIChangeTheLanguage()
        {
            _languagePage.UpdateLanguage("Tamil");
        }



        [Then("the language and level should remain unchanged")]
        public void ThenTheLanguageAndLevelShouldRemainUnchanged()
        {
            var actualLanguage = _languagePage.GetLanguage();
            var actualLevel = _languagePage.GetLevel();

            Assert.That(actualLanguage, Is.EqualTo("English"), "Language did not match expected.");
            Assert.That(actualLevel, Is.EqualTo("Fluent"), "Level did not match expected.");
        }

        [When("I click the delete icon next to a language")]
        public void WhenIClickTheDeleteIconNextToALanguage()
        {
            throw new PendingStepException();
        }
    }
}
