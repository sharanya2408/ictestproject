using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowICHorse.PageObject;
using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecflowICHorse.Stepdefinition
{
    [Binding]
    public class ABle_to_navigate_from_TM_to_customer
    {
        IWebDriver driver();
        [BeforeScenario]
        void Setup()
        {
            // var options = new ChromeOptions();
            // options.AddArgument("---headless");
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
        }
        [Given(@"I login into the portal using valid credentials")]
        public void GivenILoginIntoThePortalUsingValidCredentials()
        {
            var login = new Loginpage(driver);
        }

        [When(@"I enter valid TM records\.")]
        public void WhenIEnterValidTMRecords_()
        {
           
        }

        [Then(@"I navigate back to customer\.")]
        public void ThenINavigateBackToCustomer_()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
