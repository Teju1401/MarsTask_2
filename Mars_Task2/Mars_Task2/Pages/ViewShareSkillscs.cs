using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Task2.Pages
{
    public class ViewShareSkillscs
    {
        // page object model for view share skills page 

        // search for view button

        [FindsBy (How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[1]/i")]
        public IWebElement View { get; set; }

        public void View_Button()
        {
            View.Click();
        }
        





    }
}
