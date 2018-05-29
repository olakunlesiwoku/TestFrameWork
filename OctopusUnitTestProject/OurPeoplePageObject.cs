using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;
using System.Web;

namespace ConsoleApplicarion1
{
    class OurPeoplePageObject
    {
        public OurPeoplePageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver,this);
        }


        [FindsBy(How = How.CssSelector, Using = "body > header > div.header_top > div > div:nth-child(2) > div.header_register > a")]
        public IWebElement btnLoginRegister { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#info-modal > div.pop-up-info_bottom > div > button")]
        public IWebElement btnAdviser { get; set; }


        public void GoToLoginOrRegister()
        {
            btnLoginRegister.Click();
        }


        public void CheckUrlOfPage( string expectedURL)
        {
            // not sure this works completely - ran out of time.
           var URL =PropertiesCollection.driver.Url.Contains(expectedURL);

            Assert.AreEqual(URL, expectedURL);
        }


        public void ClickFinancialAdvisersButton()
        {
            btnAdviser.Click();
        }

        public void CheckPageMenu(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                foreach (string value in row.Values)
                {
                     PropertiesCollection.driver.FindElement(By.LinkText(value)).Click ();

                }
           
            }
        }


    }
}
