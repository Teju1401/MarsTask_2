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
    public class ManageListings
    {

        public void GotoManageListings(IWebDriver driver)
        {

           Wait.WaittobeVisible(driver, "XPath", "//*[@id='service-detail-section']/section[1]/div/a[3]", 60);

            // click on Manage Listings
            IWebElement ManageListings = driver.FindElement(By.XPath("//*[@id='service-detail-section']/section[1]/div/a[3]"));
            ManageListings.Click();
            

            Thread.Sleep(5000);

           

        }
        public void EditManageListings(IWebDriver driver)
        {
            
            // click on edit icon
            

            //IWebElement EditManageListings = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[3]"));

            //EditManageListings.Click();

            //Thread.Sleep(4000);


            //Edit  Listing if the title is House Keeping


            //IWebElement Title = driver.FindElement(By.XPath("//*[@id='listing-management-section'']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));

            //Assert.AreEqual("House keeping",Title.Text);
            Wait.WaittobeVisible(driver, "XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i", 60);

            IWebElement EditAction = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]"));
            EditAction.Click();

            Thread.Sleep(2000);

            //Edit Title



            IWebElement EditTitlebox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));

            EditTitlebox.Clear();
            EditTitlebox.Click();
            Thread.Sleep(1000);
            String EditTitletext = ExcelReader.ReadData(1, "EditTitle");
            Thread.Sleep(1000);
            EditTitlebox.SendKeys(EditTitletext);


            IWebElement EditCategory = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select"));
            EditCategory.Click();

            string EditCategorytext = ExcelReader.ReadData(1, "EditCategory");

            EditCategory.SendKeys(EditCategorytext);

            //Edit subcategory from dropdown

            IWebElement EditSubcategory = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
            EditSubcategory.Click();

            String EditSubcategorytext = ExcelReader.ReadData(1, "EditSub Category");

            EditSubcategory.SendKeys(EditSubcategorytext);

            // Select Wednessday

            IWebElement Wednessday = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[1]/div/input"));
            Wednessday.Click();


            // selct time for Wednessday

            IWebElement Wednessdaystarttime = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input"));
            Wednessdaystarttime.Click();
            string WednessdaystarttimeRead = ExcelReader.ReadData(1, "EditDayStart Time");
            Wednessdaystarttime.SendKeys(WednessdaystarttimeRead);

            IWebElement WednessdayEndtime = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[3]/input"));
            WednessdayEndtime.Click();
            string WednessdayEndtimeRead = ExcelReader.ReadData(1, "EditDayEnd Time");
            WednessdayEndtime.SendKeys(WednessdayEndtimeRead);

            //Edit Service Type

            IWebElement EditServiceType = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));

            EditServiceType.Click();

            // Edit Skill Trade and select skill exchange

            IWebElement Skillexchange = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));

            Skillexchange.Click();

            // add Skill exchange tag

            IWebElement SkillexchangeTag = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
            SkillexchangeTag.Click();
            string SkillexchangeTagRead = ExcelReader.ReadData(1, "EditSkillExchangeTag");
            SkillexchangeTag.SendKeys(SkillexchangeTagRead);
            SkillexchangeTag.SendKeys(Keys.Enter);

            // Save

            IWebElement SaveEditted = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
            SaveEditted.Click();

            Thread.Sleep(2000);



        }

        public void DeleteManageListings(IWebDriver driver)
        {

            // click on Manage Listings to Delete
            //IWebElement DeleteManageListings = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[3]"));

            //DeleteManageListings.Click();

            //Thread.Sleep(5000);
            Wait.Waittobecvisible(driver, "XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i", 60);

            // Delete Listing

            IWebElement DeleteListing = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i"));
            DeleteListing.Click();

            //Select yes if service is gardening

            IWebElement Service = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/p[2]"));

            Assert.That(Service.Text == "Gaming", "service is not matching");

            IWebElement SelectYes = driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
            SelectYes.Click();

            Thread.Sleep(2000);

            


        }




    }
}
