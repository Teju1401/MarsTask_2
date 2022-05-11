using Mars_Task2.Excel_Data_Reader;
using Mars_Task2.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mars_Task2.Pages
{
    public class LoginPage
    {
       public void LoginSteps(IWebDriver driver)
        {
            // launch web portal

            driver.Navigate().GoToUrl("http://localhost:5000/");

            //check if seller can login to the web portal with valid credentials

            //search for signin button

            IWebElement Signinbutton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            Signinbutton.Click();

            // search for emailid textbox
            IWebElement Emailidtextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            Emailidtextbox.Click();
            string UserName = ExcelReader.ReadData(1, "EmailId");
            Emailidtextbox.SendKeys(UserName);

            // search for password textbox

            IWebElement Passwordtextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            Passwordtextbox.Click();
            string Password = ExcelReader.ReadData(1, "Password");
            Passwordtextbox.SendKeys(Password);

            // search for Login button

            IWebElement Loginbutton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            Loginbutton.Click();

            Thread.Sleep(5000);


        }

    }
}


