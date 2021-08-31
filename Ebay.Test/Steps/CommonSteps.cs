using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Ebay.Test.Steps
{
    [Binding]
    public class CommonSteps : EbayBaseSteps
    {
        public CommonSteps(FeatureContext context) : base(context)
        { }

        [Given(@"I launched ebay application")]
        public void GivenILanuchedEbayApplication()
        {
            AppDriver.Navigate().GoToUrl("https://www.ebay.com.au/");
            AppDriver.Manage().Window.Maximize();
        }
    }
}
