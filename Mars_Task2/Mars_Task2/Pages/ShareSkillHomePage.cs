using AutoItX3Lib;
using Mars_Task2.Excel_Data_Reader;
using Mars_Task2.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
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

        // share skill page object model

        // search for Share Skill button

        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/div[2]/a")]
        public IWebElement ShareSkill { get; set; }

        //seach for title text box

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]
        public IWebElement Title { get; set; }

        // search for description text box

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")]
        public IWebElement Description { get; set; }

        //select category

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div/select/option[3]")]
        public IWebElement Category { get; set; }
        //select sub category
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[3]")]
        public IWebElement SubCategory { get; set; }
        //search for tag
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")]
        public IWebElement Tag { get; set; }
        //select service type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
        public IWebElement ServiceType { get; set; }
        //select location type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        public IWebElement LocationType { get; set; }
        //select start date for available days
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input")]
        public IWebElement StartDate { get; set; }
        //select end date for available days
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input")]
        public IWebElement EndDate { get; set; }
        //select day
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input")]
        public IWebElement Day { get; set; }
        //select day start time
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input")]
        public IWebElement DayStarttime { get; set; }
        //select day end time
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input")]
        public IWebElement Dayendtime { get; set; }
        // select skill trade as credit
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]
        public IWebElement Credit { get; set; }
        // select credit per hour
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input")]
        public IWebElement Perhour { get; set; }
        //upload worksample
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        public IWebElement Worksample { get; set; }
        // select active
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")]
        public IWebElement Active { get; set; }
        // save shareskills
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]")]
        public IWebElement Save { get; set; }

        public void ShareSkill_Button()
        {
            ShareSkill.Click();

        }

        public void service_Button()
        {
            ServiceType.Click();
        }
        public void Location_Button()
        {
            LocationType.Click();
        }
        public void day()
        {

            Day.Click();
        }
        public void credit_button()
        {

            Credit.Click();
        }
        public void PerHour_Button()
        {
            Perhour.Clear();
        }
        public void Worksample_Button()
        {
            Worksample.Click();
        }
        public void Active_Button()
        {
            Active.Click();
        }
        public void Save_Button()
        {
            Save.Click();
        }
        public void Category_Select()
        {
            Category.Click();
        }
        public void SubCategory_Select()
        {
            SubCategory.Click();
        }


    }
}
