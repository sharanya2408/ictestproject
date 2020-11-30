using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ictestproject.Horseportal
{
    public class Dashboard
    {
        IWebDriver driver;
        public Dashboard(IWebDriver driver)
        {
            this.driver = driver;

        }
        public void Dashboard1()
        {
            var isHariPresent = driver.FindElement(By.XPath("//*[text()='Hello hari!']"));

            //clicking on administration
            var administrations = driver.FindElements(By.ClassName("dropdown-toggle"));
            bool administration = false;
            foreach (var dropdown in administrations)
            {
                if (dropdown.Text == "Administration")
                {
                    dropdown.Click();

                    break;

                }
            }
        }
    }
}