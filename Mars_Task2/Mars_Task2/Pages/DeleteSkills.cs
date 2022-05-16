using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Task2.Pages
{
    public class DeleteSkills
    {
        [FindsBy (How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i")]
        public IWebElement Delete { get; set; }
        //select yes for delete
        [FindsBy (How =How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        public IWebElement DeleteConfirmation { get; set; }

        public void Delete_Button()
        {
            Delete.Click();
        }
        public void Delete_Confirmation()
        {
            DeleteConfirmation.Click();
        }




    }
}
