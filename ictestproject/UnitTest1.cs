
using ictestproject.Horseportal;
using ictestproject.NewFolder;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.Threading;

namespace ictestproject
{
    public class Tests
    {
        IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            // initialize chrome driver 

            // Open a browser : Chrome
            driver = new ChromeDriver();

            //// Maximize the Chrome browser window

            driver.Manage().Window.Maximize();
            //implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void VerifyUserCanLoginIntoIC()
        {
            //login page code in loginpage
            var login = new Loginpage(driver);
            login.login1();

            //dashboard page code in dashboard
            var dashboard = new Dashboard(driver);
            dashboard.Dashboard1();

            //time and material code in TimeMaterial
            var TimeMaterial = new TimeMaterial(driver);
            TimeMaterial.TimeMaterial1();



            //client page 
            var client = new Client(driver);
            client.Client1();


        }

        [TearDown]
        public void CloseDriver()
        {
            //// Close the chrome driver
            driver.Close();

            //// Frees up the memory taken by chrome. 
            driver.Dispose();
        }
    }
}


