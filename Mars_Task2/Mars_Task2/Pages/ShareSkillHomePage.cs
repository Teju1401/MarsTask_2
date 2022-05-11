using AutoItX3Lib;
using Mars_Task2.Excel_Data_Reader;
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
    public class ShareSkillHomePage
    {

        public void Createshareskill(IWebDriver driver)
        {
            // search for Share Skill button

            Thread.Sleep(6000);

            IWebElement ShareSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/div[2]/a"));
            ShareSkill.Click();

            Thread.Sleep(3000);

            // search for Title text box

            IWebElement AddTitle = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            string title = ExcelReader.ReadData(1, "Title");
           
            AddTitle.SendKeys(title);

            Thread.Sleep(2000);

            // check total number of charecters remaining for Title

            IWebElement RemainingCharectersTitle = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[2]"));

            //Assertion

            Assert.That(RemainingCharectersTitle.Text == "Characters remaining: 87", "remaining charecters is not matching");

            //search for Description text box

            IWebElement Description = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            Description.Click();
            string DescriptionRead = ExcelReader.ReadData(1, "Description");
            Description.SendKeys(DescriptionRead);

            Thread.Sleep(2000);

            // check total number of charecters remaining for Description

            IWebElement RemainingCharectersDescription = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[2]"));



            //Assertion

            Assert.That(RemainingCharectersDescription.Text == "Characters remaining: 538", "remaining charecters is not matching");


            //Select category from dropdown

            



            IWebElement Category = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div/select/option[3]"));
            Category.Click();
            string categoryRead = ExcelReader.ReadData(1, "Category");

            // select subcategory from dropdown

            IWebElement Subcategory = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[3]"));
            Subcategory.Click();


            //search for tag text box

            IWebElement Tag = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            Tag.Click();
            string TagName = ExcelReader.ReadData(1, "Tag");
            Tag.SendKeys(TagName);
            Tag.SendKeys(Keys.Enter);



            //Tag.SendKeys("House@1234!");


            //select Service Type

            IWebElement ServiceType = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));

            ServiceType.Click();

            //Select Location Type

            IWebElement Locationtype = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
            Locationtype.Click();

            //Select available days

            // select start date

            IWebElement StartDate = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
            StartDate.Click();
            string StartDateRead = ExcelReader.ReadData(1, "Available start date");
            StartDate.SendKeys(StartDateRead);



            //select end date

            IWebElement Enddate = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
            Enddate.Click();
            string EndDateRead = ExcelReader.ReadData(1, "Available End date");
            Enddate.SendKeys(EndDateRead);

            // select days for the avaliable date

            //Select sunday

            IWebElement Sunday = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input"));
            Sunday.Click();

            // selct time for sunday

            IWebElement Sundaystarttime = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input"));
            Sundaystarttime.Click();
            string SundaystarttimeRead = ExcelReader.ReadData(1, "DayStart Time");
            Sundaystarttime.SendKeys(SundaystarttimeRead);

            IWebElement SundayEndtime = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input"));
            SundayEndtime.Click();
            string SundayEndtimeRead = ExcelReader.ReadData(1, "DayEnd Time");
            SundayEndtime.SendKeys(SundayEndtimeRead);

            
            // select skill trade

            // select Credit

            IWebElement Credit = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
            Credit.Click();


            // Add perhour in credit box

           
            IWebElement Perhour = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input"));
            Perhour.Click();
            Perhour.Clear();
            string PerhourRead = ExcelReader.ReadData(1, "creditHour");
            Perhour.SendKeys(PerhourRead);



            // add file to the worksamples

            IWebElement WorksampleFile = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));

            WorksampleFile.Click();

            // Initializing autoit

            AutoItX3 autoit = new AutoItX3();

            autoit.WinActivate("Open");

            Thread.Sleep(2000);

            autoit.Send(@"C:\Users\teja.LAPTOP-JPPE5QFM\Desktop\worksamples\image2");

            Thread.Sleep(3000);

            autoit.Send("{ENTER}");

            // select active

            IWebElement Active = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
            Active.Click();

            // click on save

            IWebElement Savebutton = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
            Savebutton.Click();





        }

        public void Viewshareskill(IWebDriver driver)
        {
            // Wait.Waittobeclickable(driver, "XPath", "//*[@id='listing-management-section']/section[1]/div/a[3]", 60);

            // click on Manage Listings
            IWebElement ManageListings = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[3]"));
            ManageListings.Click();


            Thread.Sleep(5000);


            //View created share skill Listing

            IWebElement ViewListing = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[1]/i"));
            ViewListing.Click();

            //check if the skill title

            IWebElement SkillTitle = driver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span"));

            if (SkillTitle.Text == "House keeping")
            {
                Console.WriteLine("Skill Title match");

            }
            else
            {

                Console.WriteLine("Skill title do not match");

            }


        }
























    }
}
