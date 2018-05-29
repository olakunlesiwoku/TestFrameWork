using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicarion1
{
    class EAPageObject
    {

        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }




        [FindsBy(How=How.Id, Using ="TitleId")]
        public IWebElement ddlTitleID { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        //All operations on the page must be written as methods in the page object class, so including the methods below  [Ola 29/5/2018]

        public void fillUserForm(string initials, string middleName, string firstName)
        {
            SetMethods.entertext(txtInitial, initials);
            SetMethods.entertext(txtFirstName, firstName);
            SetMethods.entertext(txtMiddleName, middleName);
            SetMethods.click(btnSave);
        }
    }

   
}
