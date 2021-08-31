using Ebay.Automation.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebay.Automation.Web.Pages.Fragments
{
    public class SearchBarFragment : BaseFragment
    {
        public SearchBarFragment(IAppDriver driver) : base(driver)
        {
        }

        public void SetSearchText(string text)
        {
            var searchBox = Driver.FindElement(By.Id("gh-ac"));
            searchBox.SendKeys(text);
        }

        public void ClickSearch()
        {
            Driver.FindElement(By.Id("gh-btn")).Click();
        }
    }
}
