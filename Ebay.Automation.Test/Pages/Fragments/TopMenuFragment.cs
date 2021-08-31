using Ebay.Automation.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebay.Automation.Web.Pages.Fragments
{
    public class TopMenuFragment : BaseFragment
    {
        public TopMenuFragment(IAppDriver driver) : base(driver)
        {
        }

        public void ClickMyEbay()
        {
            Driver.FindElement(By.XPath("//a[text()='My eBay']")).Click();
        }
    }
}
