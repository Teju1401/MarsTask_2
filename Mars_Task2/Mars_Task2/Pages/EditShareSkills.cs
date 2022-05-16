using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Task2.Pages
{
    public class EditShareSkills
    {
        //page object model for edit share skills

        //Search for edit button

        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]")]
        public IWebElement EditButton { get; set; }

        //Edit title

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]
        public IWebElement EditTitle { get; set; }

        //Edit Category
        [FindsBy (How= How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select")]
        public IWebElement EditCategory { get; set; }
        //Edit SubCategory
        [FindsBy (How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select")]
        public IWebElement EditSubCategory { get; set; }
        //Edit Day
        [FindsBy (How =How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[1]/div/input")]
        public IWebElement EditDay { get; set; }
        //Edit Day start time
        [FindsBy (How=How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input")]
        public IWebElement EditStarttime { get; set; }
        //edit day end time
        [FindsBy (How=How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[3]/input")]
        public IWebElement EditDayEndtime { get; set; }
        //Edit Service
        [FindsBy (How =How.XPath,Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        public IWebElement EditService { get; set; }
        //Edit Skill exchange
        [FindsBy (How =How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")]
        public IWebElement EditSkills { get; set; }
        //skill exchange tag
        [FindsBy(How=How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")]
        public IWebElement EditTag { get; set; } 
        //click on save button
        [FindsBy (How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]")]
        public IWebElement SaveEditted { get; set; }


        public void Edit_Button()
        {
            EditButton.Click();
        }
        public void Title()
        {
            EditTitle.Clear();

            EditTitle.Click();
        }
        public void Edit_Category()
        {
            EditCategory.Click();
        }
        public void Edit_SubCategory()
        {
            EditSubCategory.Click();
        }
        public void Edit_Day()
        {
            EditDay.Click();
        }
        public void Edit_Service()
        {
            EditService.Click();
        }
        public void Edit_SkillExchange()
        {
            EditSkills.Click();
        }
        public void Edit_Save()
        {
            SaveEditted.Click();
        }



    }
}
