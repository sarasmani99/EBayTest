using Ebay.Automation.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebay.Automation.Web.Pages
{
    public class ShoppingCartPage : BasePage
    {
        public ShoppingCartPage(IAppDriver driver) : base(driver)
        {

        }

        public bool IsItemExists(string itemTitle)
        {
            return Driver.FindElement(By.XPath("//span[text()='" + itemTitle + "']")) != null;
        }
    }
}
