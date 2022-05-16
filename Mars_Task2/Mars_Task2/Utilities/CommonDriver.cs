using ExcelDataReader;
using Mars_Task2.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars_Task2.Excel_Data_Reader;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.Threading;
using SeleniumExtras.PageObjects;

namespace Mars_Task2.Utilities
{
    

    
    public class CommonDriver
    {

        
        public static IWebDriver driver;
        public static ExtentReports extentreportObj;
        public static ExtentHtmlReporter htmlreporter;
        public static ExtentTest test;
        public static FileStream stream;


        [OneTimeSetUp]
        public void loginFunction()
        {
            Thread.Sleep(6000);

            string filename = (@"C:\Users\teja.LAPTOP-JPPE5QFM\Desktop\Teja\ShareSkills.xlsx");


            stream = File.Open(filename, FileMode.Open, FileAccess.Read);

                
                ExcelReader.ReadDataTable(stream, "Login");

                var htmlreporter = new ExtentHtmlReporter(@"C:\Users\teja.LAPTOP-JPPE5QFM\Desktop\Teja\Automation_Testing\Project_Mars_Task2\MarsTask_2\Mars_Task2\Mars_Task2\ExtentReprt\");
                extentreportObj = new ExtentReports();
                extentreportObj.AttachReporter(htmlreporter);



            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://localhost:5000/");

            // Login page object initialization and definition

            LoginPage LoginpageObj = new LoginPage();

            PageFactory.InitElements(driver, LoginpageObj);

            LoginpageObj.SignInButton();

            string UserName = ExcelReader.ReadData(1, "EmailId");
            LoginpageObj.EmailId.SendKeys(UserName);
            string Passwords = ExcelReader.ReadData(1, "Password");
            LoginpageObj.Password.SendKeys(Passwords);
            LoginpageObj.ClickLoginButton();
            Thread.Sleep(3000);

           

        }
        [TearDown]
        public void closeTestRun()
        {
            extentreportObj.Flush();
            
        }

        



    }
}
