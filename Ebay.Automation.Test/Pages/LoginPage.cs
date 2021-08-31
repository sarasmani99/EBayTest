using Ebay.Automation.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebay.Automation.Web.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IAppDriver driver) : base(driver)
        {

        }

        public void SetUserName(string userName)
        {
            Driver.FindElement(By.Id("userid")).SendKeys(userName);
        }

        public void ClickContinue()
        {
            Driver.FindElement(By.Id("signin-continue-btn")).Click();
        }

        public bool HasErrorMessage(string message)
        {
            return Driver.GetElement(By.Id("errormsg")).Text == message;
        }
    }
}
