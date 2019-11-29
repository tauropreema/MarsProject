
using AutoIt;
using MarsFramework.Config;
using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.XPath, Using = "//a[@href='/Home/ServiceListing']")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.XPath, Using = "//input[@name='title']")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }

        #region Service type dropdownlist
        //Select the Hourly basis Service radio button
        [FindsBy(How = How.XPath, Using = "(//input[contains(@name,'serviceType')])[1]")]
        private IWebElement ServiceTypeOptions1 { get; set; }

        //Select the One-off Service radio button
        [FindsBy(How = How.XPath, Using = "(//input[contains(@name,'serviceType')])[2]")]
        private IWebElement ServiceTypeOptions2 { get; set; }

        //Select the Service type text 1
        [FindsBy(How = How.XPath, Using = "//input[@name='serviceType']//following-sibling::label[contains(text(),'Hourly basis service')]")]
        private IWebElement ServiceTypeOptionsText1 { get; set; }

        //Select the Service type text 2
        [FindsBy(How = How.XPath, Using = "//input[@name='serviceType']//following-sibling::label[contains(text(),'One-off service')]")]
        private IWebElement ServiceTypeOptionsText2 { get; set; }
        #endregion
        #region Location type
        //Select the On-site radio button
        [FindsBy(How = How.XPath, Using = "(//input[contains(@name,'locationType')])[1]")]
        private IWebElement LocationTypeOptions1 { get; set; }

        //Select the Online Service radio button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input[@value='1']")]
        private IWebElement LocationTypeOptions2 { get; set; }

        //Select the Location Type text 1
        [FindsBy(How = How.XPath, Using = "//input[@name='locationType']//following-sibling::label[contains(text(),'On-site')]")]
        private IWebElement LocationTypeOptionsText1 { get; set; }

        //Select the Location Type text 2
        [FindsBy(How = How.XPath, Using = "//input[@name='locationType']//following-sibling::label[contains(text(),'Online')]")]
        private IWebElement LocationTypeOptionsText2 { get; set; }
        #endregion
        #region Start Date
        //Click on Start Date dropdown
        //        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/table/tbody/tr/td")]
        //        private IList<IWebElement> StartDateDropDown { get; set; }

        //        [FindsBy(How = How.XPath, Using = "//a[@href='#'][contains(.,'June 2013')]")]//html/body/div[2]/div/div/div[1]/a[2]
        //        private IWebElement SelectedMonth { get; set; }

        //        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/a[3]")]
        //        private IWebElement NextBtn { get; set; }

        //[FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/a[1]/span")]
        //        private IWebElement PreviousBtn { get; set; }

        //        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/table/tbody/tr[1]/td[1]/a[contains(text(), 'Jan')]")]
        //        private IWebElement JanMonth { get; set; }


        //        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div/div[1]/ul[1]/li[4]/a/span[1]")]
        //        private IWebElement Calendar { get; set; }
        #endregion


        //[FindsBy(How = How.Name, Using = "isAllDay")]
        //private IWebElement AllDayEvent { get; set; }

        //[FindsBy(How = How.XPath, Using = "/html/body/div[4]/div[2]/div/div[10]/div/span/span")]
        //private IWebElement RepeatDropdown { get; set; }

        //[FindsBy(How = How.Name, Using = "description")]
        //private IWebElement EventDescription { get; set; }

        //[FindsBy(How = How.XPath, Using = "/html/body/div[4]/div[2]/div/div[15]/span/span")]
        //private IWebElement OwnerDropdown { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }


        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on Skill Trade skill exchange radio button  
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input[@value='true']")]
        private IWebElement SkillTradeOption1 { get; set; }

        //Click on Skill Trade Credit radio button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input[@value='false']")]
        private IWebElement SkillTradeOption2 { get; set; }

        //Select Skill Trade skill exchange text 
        [FindsBy(How = How.XPath, Using = "//input[@name='skillTrades']//following-sibling::label[contains(text(),'Skill-exchange')]")]
        private IWebElement SkillTradeOptionText1 { get; set; }

        //Select the Skill Trade Credit text
        [FindsBy(How = How.XPath, Using = "//input[@name='skillTrades']//following-sibling::label[contains(text(),'Credit')]")]
        private IWebElement SkillTradeOptionText2 { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active radio button 
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input[@value='true']")]
        private IWebElement ActiveOption1 { get; set; }

        //Click on Hidden radio button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input[@value='false']")]
        private IWebElement ActiveOption2 { get; set; }

        //Click on Active radio button text 
        [FindsBy(How = How.XPath, Using = "//input[@name='isActive']//following-sibling::label[contains(text(),'Active')]")]
        private IWebElement ActiveOptionText1 { get; set; }

        //Click on Hidden radio button text
        [FindsBy(How = How.XPath, Using = "//input[@name='isActive']//following-sibling::label[contains(text(),'Hidden')]")]
        private IWebElement ActiveOptionText2 { get; set; }


        //Click on File Upload
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        private IWebElement FileUpload { get; set; }



        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

            //Click on Cancel button
            [FindsBy(How = How.XPath, Using = "//input[@value='Cancel']")]
            private IWebElement Cancel { get; set; }

            #region EditShareSkill
            //Click on Edit button
            [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i")]
            private IWebElement Edit { get; set; }
            //Click on Manage Listings Page
            [FindsBy(How = How.XPath, Using = "//a[@href='/Home/ListingManagement']")]
            private IWebElement ManageListings { get; set; }
            //Click on Delete 
            [FindsBy(How = How.XPath, Using = "(//i[contains(@class,'remove icon')])[1]")]
            private IWebElement Delete { get; set; }

            //Click on No
            [FindsBy(How = How.XPath, Using = "//button[contains(.,'No')]")]
            private IWebElement No { get; set; }

            [FindsBy(How = How.XPath, Using = "//button[contains(.,'Yes')]")]
            private IWebElement Yes { get; set; }

            //Get the total no of rows in the Manage listings page
            [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr")]
            private IList<IWebElement> Totalrows { get; set; }
            //Get the next page
            [FindsBy(How = How.XPath, Using = "//button[@class='ui button otherPage'][contains(.,'>')]")]
            private IWebElement NextPage { get; set; }


        #endregion
        internal void EnterShareSkill()
        {
            try
            {
                //Populate the excel data
                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
                //Click on Share Skill button
                ShareSkillButton.Click();
                //Enter the Title
                Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
                //Enter the Description
                Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
                //Choose the Category
                SelectElement Category = new SelectElement(CategoryDropDown);
                Category.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));
                //Choose the Sub Category
                SelectElement SubCategory = new SelectElement(SubCategoryDropDown);
                SubCategory.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));
                //Enter the tags
                Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
                //Click the Enter button
                Tags.SendKeys(Keys.Enter);
                //Click on Service type radio button
                if (GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType") == ServiceTypeOptionsText1.Text)
                {
                    if (!ServiceTypeOptions1.Selected)
                        ServiceTypeOptions1.Click();
                }
                else if (GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType") == ServiceTypeOptionsText2.Text)
                {
                    if (!ServiceTypeOptions2.Selected)
                    {
                        GlobalDefinitions.wait(5000);
                        ServiceTypeOptions2.Click();
                    }

                }
                //Click on Location type radio button
                if (GlobalDefinitions.ExcelLib.ReadData(2, "LocationType") == LocationTypeOptionsText1.Text)
                {
                    GlobalDefinitions.wait(5000);
                    if (!LocationTypeOptions1.Selected)
                    {
                        GlobalDefinitions.wait(5000);
                        LocationTypeOptions1.Click();
                    }
                }
                else if (GlobalDefinitions.ExcelLib.ReadData(2, "LocationType") == LocationTypeOptionsText2.Text)
                    if (!LocationTypeOptions2.Selected)
                    {
                        GlobalDefinitions.wait(5000);
                        LocationTypeOptions2.Click();
                    }
                //StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Startdate"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal void EditShareSkill()
        {
            try
            {
                //Click on Manage Listings
                ManageListings.Click();
                //Populate the excel data
                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
                string FirstPath = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[";
                string SecondPath = "]/td[3]";
                string getTitle = null;
                bool flag = false;
                while(true)
                {
                    for (int rownum = 1; rownum <= (Totalrows.Count); rownum++)
                    {
                        getTitle = GlobalDefinitions.driver.FindElement(By.XPath(FirstPath + rownum + SecondPath)).Text;
                        if (getTitle == GlobalDefinitions.ExcelLib.ReadData(2, "Title"))
                        {
                            //Click on Edit button 
                            GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[" + rownum + "]/td[8]/div/button[2]/i")).Click();
                            GlobalDefinitions.wait(7000);
                            //Clear the title and description
                            Title.Clear();
                            //Edit the title and Description
                            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Edittitle"));
                            Description.Clear();
                            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Editdescription"));
                            GlobalDefinitions.wait(6000);
                            Save.Click();
                            GlobalDefinitions.wait(7000);
                            flag = true;
                            Console.WriteLine("Successfully Updated");
                            return;
                        }
                    }
                    if (flag == false)
                        NextPage.Click();
                }            
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        internal void DeleteShareSkill()
        {
            try
            {
                //Click on Manage Listings                
                ManageListings.Click();            
                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ManageListingExcelPath, "ManageListings");
                string FirstPath = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[";
                string SecondPath = "]/td[3]";
                string getTitle = null;
                bool flag = false;
                while(true)
                {
                    for (int rownum = 1; rownum <= (Totalrows.Count); rownum++)
                    {
                        getTitle = GlobalDefinitions.driver.FindElement(By.XPath(FirstPath + rownum + SecondPath)).Text;
                        if (getTitle == GlobalDefinitions.ExcelLib.ReadData(2, "Title"))
                        {
                            if (GlobalDefinitions.ExcelLib.ReadData(2, "Deleteaction") == "Yes")
                            {
                                //Click on Delete
                                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[" + rownum + "]/td[8]/div/button[3]/i")).Click();
                                GlobalDefinitions.wait(10000);
                                Yes.Click();
                                GlobalDefinitions.wait(10000);
                                Console.WriteLine("Record is successfully deleted");
                                flag = true;
                                return;
                            }
                            else
                            {
                                //Click on Delete
                                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[" + rownum + "]/td[8]/div/button[3]/i")).Click();
                                GlobalDefinitions.wait(10000);
                                No.Click();
                                GlobalDefinitions.wait(10000);
                                Console.WriteLine("There is matching record but it is not deleted");
                                flag = true;
                                return;
                            }
                        }
                        else
                            Assert.Pass("There is no matching record to delete");
                    }
                    if(flag==false)
                    NextPage.Click();
                }
                    
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }
            


        }
    }
}
