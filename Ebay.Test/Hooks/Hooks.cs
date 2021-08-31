using Ebay.Test.Steps;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Ebay.Test.Hooks
{
    [Binding]
    public class Hooks : EbayBaseSteps
    {
        public Hooks(FeatureContext context) : base(context)
        {
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            if (AppDriver != null)
                AppDriver.Dispose();
        }
    }
}
