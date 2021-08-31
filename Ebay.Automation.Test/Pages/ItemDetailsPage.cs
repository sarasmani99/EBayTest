using Ebay.Automation.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebay.Automation.Web.Pages
{
    public class ItemDetailsPage : BasePage
    {
        public ItemDetailsPage(IAppDriver driver) : base(driver)
        {

        }

        public string GetItemTitle()
        {
            return Driver.FindElement(By.Id("itemTitle")).Text;
        }

        public void ClickAddToCart()
        {
            Driver.FindElement(By.Id("isCartBtn_btn")).Click();
        }

        public void ClickNoThanks()
        {
            Driver.FindElement(By.XPath("//button[text()='No thanks']")).Click();
        }

    }
}
