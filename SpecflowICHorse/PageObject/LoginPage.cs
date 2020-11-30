using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowICHorse.PageObject
{
    public class Loginpage
    {
        IWebDriver driver;
        private Func<IWebDriver> driver1;

        public Loginpage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Loginpage(Func<IWebDriver> driver1)
        {
            this.driver1 = driver1;
        }

        public void login1()
        {
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            //user name
            driver.FindElement(By.Id("UserName")).SendKeys("hari");

            //password
            driver.FindElement(By.Id("Password")).SendKeys("123123");

            //clicking on login
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
        }
    }
}
