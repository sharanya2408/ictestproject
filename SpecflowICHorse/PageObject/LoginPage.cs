using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowICHorse.PageObject
{
    public class Loginpage
    {
        IWebDriver driver;

        public Loginpage(IWebDriver driver)
        {
            this.driver = driver;
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
