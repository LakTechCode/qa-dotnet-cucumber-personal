using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.Log;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace qa_dotnet_cucumber.Pages
{
    public class LanguagePage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        public IWebDriver Driver => _driver;

        //Locators
        private readonly By AddNewButton = By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div");
        private readonly By AddLanguageField = By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input");
        private readonly By ProficiencyDropdown = By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select");
        private readonly By AddButton = By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]");
        private readonly By CancelButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]");
        public LanguagePage(IWebDriver driver) // Inject IWebDriver directly
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10)); // 10-second timeout
        }

        public void ClickAddNew()
        {
            var addNewButtonElement = _wait.Until(ExpectedConditions.ElementToBeClickable(AddNewButton));
            addNewButtonElement.Click();
        }

        public void AddLanguage(string language)

        {
            var addLanguageElement = _wait.Until(ExpectedConditions.ElementToBeClickable(AddLanguageField));
            addLanguageElement.SendKeys(language);

        }

        public void ProficiencyLevel (string level)

        {
            var dropdown = _wait.Until(ExpectedConditions.ElementToBeClickable(ProficiencyDropdown));
            var select = new SelectElement(dropdown);
            select.SelectByText(level);

        }

        public void ClickAdd()

        {
            var addButtonElement = _wait.Until(ExpectedConditions.ElementToBeClickable(AddButton));
            addButtonElement.Click();
        }

        public void ClickCancel()

        {
            var cancelButtonElement = _wait.Until(ExpectedConditions.ElementToBeClickable(CancelButton));
            cancelButtonElement.Click();
        }

        public bool IsLanguageInList(string language)
        {
            return Driver.FindElements(By.XPath($"//div[text()='{language}']")).Any();

        }
    }
}
