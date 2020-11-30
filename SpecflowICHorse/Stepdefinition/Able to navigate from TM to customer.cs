
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowICHorse.PageObject;
using TechTalk.SpecFlow;

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
            login.login1();
        }

        [When(@"I enter valid TM records\.")]
        public void WhenIEnterValidTMRecords_()
        {
           
        }

        [Then(@"I navigate back to customer\.")]
        public void ThenINavigateBackToCustomer_()
        {
           
        }


    }
}
