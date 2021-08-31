using Ebay.Automation.Web.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Xunit;

namespace Ebay.Test.Steps
{
    [Binding]
    public class LogInSteps : EbayBaseSteps
    {
        public LogInSteps(FeatureContext context) : base(context)
        { 
        }

        [When(@"I clicked on MyEbay link")]
        public void WhenIClickedOnMyEbayLink()
        {
            var homePage = new HomePage(AppDriver);
            homePage.TopMenuFragment.ClickMyEbay();
        }

        [When(@"I enter user name as '(.*)'")]
        public void WhenIEnterUserNameAs(string userName)
        {
            var loginPage = new LoginPage(AppDriver);
            loginPage.SetUserName(userName);
        }

        [When(@"I click on continue button")]
        public void WhenIClickOnContinueButton()
        {
            var loginPage = new LoginPage(AppDriver);
            loginPage.ClickContinue();
        }

        [Then(@"I should see error message ""(.*)""")]
        public void ThenIShouldSeeErrorMessage(string message)
        {
            var loginPage = new LoginPage(AppDriver);

            Assert.True(loginPage.HasErrorMessage(message), "Expected error message not found");
        }

    }
}
