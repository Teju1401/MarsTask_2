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


         [Test, Order(2)] 
        public void CreateShareSkill_Task2()
        {

            ExcelReader.ReadDataTable(stream, "ShareSkill");
            try
            {


                test = extentreportObj.CreateTest("AddSkillPage", "Testing of add skill page");
                ShareSkillHomePage CreateShareSkillsObj = new ShareSkillHomePage();
                CreateShareSkillsObj.Createshareskill(driver);
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
            ShareSkillHomePage viewSkillObj = new ShareSkillHomePage();
            viewSkillObj.Viewshareskill(driver);
            TakeScreenShot.ScreenShotMethod(driver);


            //test.Log(Status.Info, "View page opened successfully");
            //test.Log(Status.Pass, "Test passed");

        }
        [Test, Order(4)]
        public void ManageListing_Task2()
        {

            ManageListings ManageListingObj = new ManageListings();

            ManageListingObj.GotoManageListings(driver);

        }
        [Test, Order(5)]
        public void EditManageListing_Task2()
        {
            ExcelReader.ReadDataTable(stream, "EditSkills");
                
                            
                test = extentreportObj.CreateTest("Editskillpage", "Testing of edit page");
                ManageListings editSkillsObj = new ManageListings();
                editSkillsObj.EditManageListings(driver);
                TakeScreenShot.ScreenShotMethod(driver);
                test.Log(Status.Info, "Skills editted successfully");
                test.Log(Status.Pass, "Test passed");

                


            
            
            
                test.Log(Status.Fail, "Test failed");
                
            
            
        }


        [Test, Order(6)]
        public void DeleteManageListing_Task2()
        {


            ManageListings DeleteManageListingObj = new ManageListings();
            DeleteManageListingObj.DeleteManageListings(driver);


        }


    }
}

