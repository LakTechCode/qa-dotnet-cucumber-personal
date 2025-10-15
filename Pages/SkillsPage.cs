using OpenQA.Selenium;
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
    public class SkillsPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        public IWebDriver Driver => _driver;

        //locators
        private readonly By SkillsButton = By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]");
        private readonly By AddNewonSkillsButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div");
        public SkillsPage(IWebDriver driver) // Inject IWebDriver directly
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10)); // 10-second timeout
        }
        public void ClickSkills()
        {
            var skillsButtonElement = _wait.Until(ExpectedConditions.ElementToBeClickable(SkillsButton));
            skillsButtonElement.Click();
        }

        public void ClickAddNewonSkills()
        {
            var addNewonSkillsButtonElement = _wait.Until(ExpectedConditions.ElementToBeClickable(AddNewonSkillsButton));
            addNewonSkillsButtonElement.Click();
        }

    }
}
