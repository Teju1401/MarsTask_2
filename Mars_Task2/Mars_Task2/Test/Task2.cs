using Mars_Task2.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using AutoItX3Lib;
using Mars_Task2.Pages;
using System.IO;
using Mars_Task2.Excel_Data_Reader;
using Mars_Task2.ScreenShot;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using SeleniumExtras.PageObjects;

namespace Mars_Task2
{ 

    [TestFixture]
    
    public class ShareSkill_Test : CommonDriver
    {
        
        [Test, Order(1)]
        public void ExcelReaderMethod()
        {
            try
            {
                ExcelReader.ClearData();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);


            }

        }
             


         [Test,Order(2)] 
        public void CreateShareSkill_Task2()
        {

            ExcelReader.ReadDataTable(stream, "ShareSkill");

            try
            {
                test = extentreportObj.CreateTest("AddSkillPage", "Testing of add skill page");
                ShareSkillHomePage CreateShareSkillsObj = new ShareSkillHomePage();
                PageFactory.InitElements(driver, CreateShareSkillsObj);
                CreateShareSkillsObj.ShareSkill_Button();
                string title = ExcelReader.ReadData(1, "Title");
                CreateShareSkillsObj.Title.SendKeys(title);
                string DescriptionRead = ExcelReader.ReadData(1, "Description");
                CreateShareSkillsObj.Description.SendKeys(DescriptionRead);
                string categoryRead = ExcelReader.ReadData(1, "Category");
                CreateShareSkillsObj.Category_Select();
                CreateShareSkillsObj.SubCategory_Select();
                string TagName = ExcelReader.ReadData(1, "Tag");
                CreateShareSkillsObj.Tag.SendKeys(TagName);
                CreateShareSkillsObj.Tag.SendKeys(Keys.Enter);
                string StartDateRead = ExcelReader.ReadData(1, "Available start date");
                CreateShareSkillsObj.StartDate.SendKeys(StartDateRead);
                string EndDateRead = ExcelReader.ReadData(1, "Available End date");
                CreateShareSkillsObj.EndDate.SendKeys(EndDateRead);
                CreateShareSkillsObj.credit_button();
                string PerhourRead = ExcelReader.ReadData(1, "creditHour");
                CreateShareSkillsObj.PerHour_Button();
                CreateShareSkillsObj.Perhour.SendKeys(PerhourRead);
                CreateShareSkillsObj.Worksample_Button();
                AutoItX3 autoit = new AutoItX3();
                autoit.WinActivate("Open");
                Thread.Sleep(2000);
                autoit.Send(@"C:\Users\teja.LAPTOP-JPPE5QFM\Desktop\worksamples\Sample");
                Thread.Sleep(3000);
                autoit.Send("{ENTER}");
                CreateShareSkillsObj.Active_Button();
                CreateShareSkillsObj.Save_Button();

                //CreateShareSkillsObj.Createshareskill(driver);
                TakeScreenShot.ScreenShotMethod(driver);

                test.Log(Status.Info, "Skills saved successfully");
                test.Log(Status.Pass, "AddSkillPage executed successfully, test passed");

            }

            catch 
            {
                test.Log(Status.Fail, "skills not added");

            } 
           
        }

        [Test, Order(3)]
        public void ViewSkill_Task2()

        {
            Thread.Sleep(2000);
            ViewShareSkillscs viewSkillObj = new ViewShareSkillscs();
            PageFactory.InitElements(driver, viewSkillObj);
            viewSkillObj.View_Button();
            Thread.Sleep(2000);
            TakeScreenShot.ScreenShotMethod(driver);


            test.Log(Status.Info, "View page opened successfully");
            test.Log(Status.Pass, "Test passed");

        }
        [Test, Order(4)]
        public void ManageListing_Task2()
        {
            Thread.Sleep(2000);
            ManageListings ManageListingObj = new ManageListings();
            PageFactory.InitElements(driver, ManageListingObj);
            ManageListingObj.ManageListing_Button();
           
        }
        [Test, Order(5)]
        public void EditManageListing_Task2()
        {
            Thread.Sleep(2000);
            ExcelReader.ReadDataTable(stream, "EditSkills");
            try
            {

                test = extentreportObj.CreateTest("Editskillpage", "Testing of edit page");
                EditShareSkills editSkillsObj = new EditShareSkills();
                PageFactory.InitElements(driver, editSkillsObj);
                editSkillsObj.Edit_Button();
                Thread.Sleep(1000);
                String EditTitletext = ExcelReader.ReadData(1, "EditTitle");
                editSkillsObj.Title();
                editSkillsObj.EditTitle.SendKeys(EditTitletext);

                editSkillsObj.Edit_Category();
                editSkillsObj.Edit_SubCategory();
                editSkillsObj.Edit_Day();
                string WednessdaystarttimeRead = ExcelReader.ReadData(1, "EditDayStart Time");
                editSkillsObj.EditStarttime.SendKeys(WednessdaystarttimeRead);
                string WednessdayEndtimeRead = ExcelReader.ReadData(1, "EditDayEnd Time");
                editSkillsObj.EditDayEndtime.SendKeys(WednessdayEndtimeRead);
                editSkillsObj.Edit_Service();
                editSkillsObj.Edit_SkillExchange();
                string SkillexchangeTagRead = ExcelReader.ReadData(1, "EditSkillExchangeTag");
                editSkillsObj.EditTag.SendKeys(SkillexchangeTagRead);
                editSkillsObj.EditTag.SendKeys(Keys.Enter);
                editSkillsObj.Edit_Save();
                TakeScreenShot.ScreenShotMethod(driver);
                test.Log(Status.Info, "Skills editted successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch
            {
                test.Log(Status.Fail, "Test failed");

            }
  
        }


        [Test, Order(6)]
        public void DeleteManageListing_Task2()
        {

            Thread.Sleep(2000);
            DeleteSkills DeleteManageListingObj = new DeleteSkills();
            PageFactory.InitElements(driver, DeleteManageListingObj);
            DeleteManageListingObj.Delete_Button();
            DeleteManageListingObj.Delete_Confirmation();

        }


    }
}

