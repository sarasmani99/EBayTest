using OpenQA.Selenium.Chrome;
using System;

namespace Ebay.Automation.Common
{
    public class AppChromeDriver : ChromeDriver, IAppDriver
    {
        public AppChromeDriver(ChromeDriverService service, ChromeOptions options) : base(service, options)
        { }

        public IAppLogger Logger { get; set; }
    }
}
