using Ebay.Automation.Common;
using Ebay.Automation.Web.Pages.Fragments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebay.Automation.Web
{
    public class BasePage : BaseFragment
    {
        public BasePage(IAppDriver driver):base(driver)
        {
            TopMenuFragment = new TopMenuFragment(driver);
            SearchBarFragment = new SearchBarFragment(driver);
        }

        public TopMenuFragment TopMenuFragment { get; set; }
        public SearchBarFragment SearchBarFragment { get; set; }
        public void Navigate(string Url)
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(Url);
        }
    }
}
