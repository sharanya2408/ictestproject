using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowICHorse.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowICHorse.Stepdefinition
{
    [Binding]
  
    public  class verifying_the_customer_details
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
        [Given(@"I login into the portal using valid credentials\.")]
        public void GivenILoginIntoThePortalUsingValidCredentials_()
        {
            var login = new Loginpage(driver);
            login.login1();
        }

        [When(@"I add customers records by clicking create new\.")]
        public void WhenIAddCustomersRecordsByClickingCreateNew_()
        {
            var client = new Client(driver);
            client.Client1();
        }

        [Then(@"I validate the records entered\.")]
        public void ThenIValidateTheRecordsEntered_()
        {
            
        }

    }
}
