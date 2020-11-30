using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace ictestproject.Horseportal
{
    public  class TimeMaterial
    {
        IWebDriver driver;
        

        public TimeMaterial(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void TimeMaterial1()
        {
            //clicking on time an material
            driver.FindElement(By.XPath("//*[text()='Time & Materials']")).Click();

            //creating new record
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();


            //clicking on material
            driver.FindElement(By.XPath("//span[text()='Material']")).Click();


            //selecting time
            driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();
            //explicit wait
            var wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            //input value into code

            //Random Randomnum = new Random(1000);
            //int n = Randomnum.Next();
            //driver.FindElement(By.Id("Code")).SendKeys(n);
            
            //code.SendKeys("1345");
            var randomNumber = new Random();
            var code = "Code_" + randomNumber.Next(0, 999);
            driver.FindElement(By.Id("Code")).SendKeys(code);

            //input value into description
            driver.FindElement(By.Id("Description")).SendKeys("this is my time value");


            //input value into price per unit
            driver.FindElement(By.CssSelector("input[class='k-formatted-value k-input']")).SendKeys("20$");


            //clicking on save
            driver.FindElement(By.Id("SaveButton")).Click();
            

            //verifying the created instance
            driver.FindElement(By.XPath("//*[@title='Go to the last page']")).Click();
            
            //var expected = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[5]/td[1]"));
            //expected.Text();
            //Assert.AreEqual(code, expected);



        }
    }
}
