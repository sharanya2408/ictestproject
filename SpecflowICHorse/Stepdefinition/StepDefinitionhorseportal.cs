using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowICHorse.PageObject;
using System;
using TechTalk.SpecFlow;

namespace ictestproject.Stepdefinition
{
    [Binding]
    public class StepDefinitionhorseportal
    {
        IWebDriver driver;


        [BeforeScenario]
        void Setup()
        {
           // var options = new ChromeOptions();
           // options.AddArgument("---headless");
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
        }

        [Given(@"I navigate to the portal")]
        public void GivenINavigateToThePortal()
        {
           
            //implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [When(@"I add credentials to the login page")]
        public void WhenIAddCredentialsToTheLoginPage()
        {
           var login = new Loginpage(driver);
            login.login1();
        }

        [Then(@"I verify that the user is able to login into the portal")]
        public void ThenIVerifyThatTheUserIsAbleToLoginIntoThePortal()
        {
            var Dashboard = new Dashboard(driver);
            Dashboard.Dashboard1();

        }

        [When(@"I add Time and material records\.")]
        public void WhenIAddTimeAndMaterialRecords_()
        {
            var TimeMaterial = new TimeMaterial(driver);
            TimeMaterial.TimeMaterial1();
        }

        [Then(@"I verify that the entered records\.")]
        public void ThenIVerifyThatTheEnteredRecords_()
        {
            
        }


    }
}
