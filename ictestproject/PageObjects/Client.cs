using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ictestproject.Horseportal
{
    public class Client
    {
        IWebDriver driver;
        public Client(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Client1()
        { 
        //clicking on administration
        driver.FindElement(By.ClassName("dropdown-toggle")).Click();

        //explicit wait
        var wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
        wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

        //wait.Until(ExpectedConditions.ElementIsClickable(By.XPath("//*[text()='Customers']"));


        //clicking on customers
        driver.FindElement(By.XPath("//*[text()='Customers']")).Click();


        //clicking on creat new
        driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();


        //input value into name
        driver.FindElement(By.Id("Name")).SendKeys("Sharanya");


        //checking select box
        driver.FindElement(By.Id("IsSameContact")).Click();


        //input value into GST
        driver.FindElement(By.Id("GST")).SendKeys("30$");


        //clicking submit button
        driver.FindElement(By.XPath("//*[@type='submit']")).Click();

        }
            
    }
}
