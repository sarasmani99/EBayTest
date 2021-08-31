using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebay.Automation.Common
{
    public interface IAppDriver : IWebDriver
    {
        IAppLogger Logger { get; set; }
    }
}
