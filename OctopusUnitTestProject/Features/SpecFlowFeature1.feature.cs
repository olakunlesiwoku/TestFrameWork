﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ConsoleApplicarion1.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("OctopusWebsite_OurPeople")]
    public partial class OctopusWebsite_OurPeopleFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SpecFlowFeature1.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "OctopusWebsite_OurPeople", "\tIn order to learn about Octopus investments company\'s departments and people\r\n\tA" +
                    "s a visitor\r\n\tI want to be able to visit the site and interact with the \"our-peo" +
                    "ple\" page", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
          testRunner.Given("I have navigated to the our-people page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Ensure that the page is available")]
        public virtual void EnsureThatThePageIsAvailable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ensure that the page is available", ((string[])(null)));
#line 9
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 10
 testRunner.Then("the page should exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Ensure menu items are available")]
        public virtual void EnsureMenuItemsAreAvailable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ensure menu items are available", ((string[])(null)));
#line 12
 this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Home"});
            table1.AddRow(new string[] {
                        "Home"});
            table1.AddRow(new string[] {
                        "Our products"});
            table1.AddRow(new string[] {
                        "What we invest in"});
            table1.AddRow(new string[] {
                        "Adviser centre"});
            table1.AddRow(new string[] {
                        "About us"});
            table1.AddRow(new string[] {
                        "Contact us"});
#line 13
 testRunner.Then("I should be able to confirm the following menu Home", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Ensure menu sub items are available for our products")]
        public virtual void EnsureMenuSubItemsAreAvailableForOurProducts()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ensure menu sub items are available for our products", ((string[])(null)));
#line 22
 this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 23
 testRunner.When("I select <our-products> menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "our-products",
                        "sub-menu-items"});
            table2.AddRow(new string[] {
                        "our products",
                        "Venture Capital trusts"});
            table2.AddRow(new string[] {
                        "our products",
                        "Inheritance Tax Solutions"});
            table2.AddRow(new string[] {
                        "our products",
                        "Enterprise Investment Scheme"});
#line 24
 testRunner.Then("I should be able to confirm the following <sub-menu-items>", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Ensure staff can be searched for by name")]
        public virtual void EnsureStaffCanBeSearchedForByName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ensure staff can be searched for by name", ((string[])(null)));
#line 31
 this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 32
 testRunner.And("I have entered a <staff-member> into the search box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.When("I hit the retrn carriage key", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("the result should be the staff member on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check that team members are displayed when department tick box is ticked")]
        public virtual void CheckThatTeamMembersAreDisplayedWhenDepartmentTickBoxIsTicked()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check that team members are displayed when department tick box is ticked", ((string[])(null)));
#line 36
 this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 37
 testRunner.When("I  tick <department>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "department",
                        "result"});
            table3.AddRow(new string[] {
                        "Tax Efficient Investments team",
                        "Jess Franks"});
            table3.AddRow(new string[] {
                        "Tax Efficient Investments team",
                        "Diana French"});
            table3.AddRow(new string[] {
                        "Tax Efficient Investments team",
                        "Richard Payne"});
            table3.AddRow(new string[] {
                        "Tax Efficient Investments team",
                        "Richard Barnes"});
#line 38
 testRunner.Then("the <result> should be displayed on the screen", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Ensure that staff members are sorted by ascending alphabetical order")]
        public virtual void EnsureThatStaffMembersAreSortedByAscendingAlphabeticalOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ensure that staff members are sorted by ascending alphabetical order", ((string[])(null)));
#line 45
 this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 46
 testRunner.When("I select the sort in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then("the display of staff on the page should be in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Ensure that staff members are sorted by descending alphabetical order")]
        public virtual void EnsureThatStaffMembersAreSortedByDescendingAlphabeticalOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ensure that staff members are sorted by descending alphabetical order", ((string[])(null)));
#line 49
 this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 50
 testRunner.When("I select the sort in descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.Then("the display of staff on the page should be in descending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Ensure disclaimer is displayed at bottom of page")]
        public virtual void EnsureDisclaimerIsDisplayedAtBottomOfPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ensure disclaimer is displayed at bottom of page", ((string[])(null)));
#line 53
 this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 54
 testRunner.Then("the disclaimer should be displayed in the page footer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Ensure links at bottom of page are displayed and function")]
        public virtual void EnsureLinksAtBottomOfPageAreDisplayedAndFunction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ensure links at bottom of page are displayed and function", ((string[])(null)));
#line 56
 this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "links"});
            table4.AddRow(new string[] {
                        "About us"});
            table4.AddRow(new string[] {
                        "Site map"});
            table4.AddRow(new string[] {
                        "Terms and conditions"});
            table4.AddRow(new string[] {
                        "What we invest in"});
            table4.AddRow(new string[] {
                        "Modern Slavery Act"});
            table4.AddRow(new string[] {
                        "Privacy policy"});
            table4.AddRow(new string[] {
                        "Adviser centre"});
#line 57
 testRunner.Then("menu <links> should be displayed in the page footer", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Ensure that user can switch to investments page")]
        public virtual void EnsureThatUserCanSwitchToInvestmentsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ensure that user can switch to investments page", ((string[])(null)));
#line 67
 this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 68
 testRunner.When("I click on the switch to investor button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.Then("the investor page should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Ensure user can navigate to log in or register page")]
        public virtual void EnsureUserCanNavigateToLogInOrRegisterPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ensure user can navigate to log in or register page", ((string[])(null)));
#line 71
 this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 72
 testRunner.When("I click on the login/register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
 testRunner.Then("a secure login/register page should be displayed.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
