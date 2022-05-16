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
    public class ManageListings
    {

        //Manage Listing Page Object Model

        // Select Manage Listing

        [FindsBy (How =How.XPath, Using= "//*[@id='service-detail-section']/section[1]/div/a[3]")]
        public IWebElement ManageListing { get; set; }

        

        public void ManageListing_Button()

        {
            ManageListing.Click();

        }
       
    }
}
