
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Threading;

namespace ConsoleApplicarion1
{
    [Binding]
    public sealed class StepDefinition1
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given(@"I have navigated to the our-people page")]
        public void GivenIHaveNavigatedToTheOur_PeoplePage()
        {
            PropertiesCollection.driver = new ChromeDriver(); // This is initialised once here and does not subsequently require being passed as a parameter for custom controls.
            PropertiesCollection.driver.Navigate().GoToUrl("https://octopusinvestments.com/adviser/about-us/our-people/");
            PropertiesCollection.driver.Manage().Window.Maximize();
        }

        [Then(@"the page should exist")]
        public void ThenThePageShouldExist()
        {
            OurPeoplePageObject pageOurPeople = new OurPeoplePageObject();
            pageOurPeople.CheckUrlOfPage("https://octopusinvestments.com/adviser/about-us/our-people/");
        }


        [Then(@"I should be able to confirm the following menu (.*)")]
        public void ThenIShouldBeAbleToConfirmTheFollowingMenu(string p0,Table table)
        {
            OurPeoplePageObject pageOurPeople = new OurPeoplePageObject();
            pageOurPeople.ClickFinancialAdvisersButton();
            Thread.Sleep(100);  // This is not the best practice and should be avoided. I just added this temporarily as I have run out of time. [Ola  29/5/2018]  
            pageOurPeople.CheckPageMenu(table);

        }

        [When(@"I click on the login/register button")]
        public void WhenIClickOnTheLoginRegisterButton()
        {
            OurPeoplePageObject pageOurPeople = new OurPeoplePageObject();
            Thread.Sleep(30); // ran out of time, should be removed in due course.
            pageOurPeople.ClickFinancialAdvisersButton();
            pageOurPeople.GoToLoginOrRegister();
           
        }


        [Then(@"a secure login/register page should be displayed\.")]
        public void ThenASecureLoginRegisterPageShouldBeDisplayed_()
        {
            OurPeoplePageObject pageOurPeople = new OurPeoplePageObject();
            pageOurPeople.CheckUrlOfPage("https://secure.octopusinvestments.com");
        }


    }
}
