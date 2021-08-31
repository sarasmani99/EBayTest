using Ebay.Automation.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebay.Automation.Web.Pages
{
    public class SearchResultsPage : BasePage
    {
        public SearchResultsPage(IAppDriver driver) : base(driver)
        {

        }

        public void ClickOnItem(int itemIndex)
        {
            itemIndex = itemIndex - 1;
            var itemsList = Driver.FindElements(By.XPath("//*[@id='srp-river-results']/ul/li"));
            itemsList[itemIndex].FindElement(By.TagName("h3")).Click();
        }
    }
}
