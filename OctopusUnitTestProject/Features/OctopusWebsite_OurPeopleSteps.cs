using ConsoleApplicarion1;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;




namespace ConsoleApplicarion1
{
    [Binding]
    public class OctopusWebsite_OurPeopleSteps
    {

        [Given(@"I have navigated to the our-people page")]
        public void GivenIHaveNavigatedToTheOur_PeoplePage()
        {
            PropertiesCollection.driver = new ChromeDriver(); // This is initialised once here and does not subsequently require being passed as a parameter for custom controls.
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/Login.html");

            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("execute", "automation");
        }

        [Then(@"the page should exist")]
        public void ThenThePageShouldExist()
        {
           ;
        }




    }
}
