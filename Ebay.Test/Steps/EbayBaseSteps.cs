using Ebay.Automation.Common;
using NLog;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Ebay.Test.Steps
{
    public class EbayBaseSteps : IDisposable
    {
        private FeatureContext _context;
        public static IAppDriver AppDriver { get; set; }
        private ChromeDriverService chromeDriverService;
        public IAppLogger Logger { get; private set; }
        public EbayBaseSteps(FeatureContext context)
        {
            _context = context;
            if (context.TryGetValue("_driver", out IAppDriver _) == false)
            {
                Logger = new AppLogger(LogManager.GetLogger("ISelectBaseSteps"), "ISelectBaseSteps");
                InitDriver();
                context.Set(AppDriver, "_driver");
            }
            else
            {
                AppDriver = context.Get<IAppDriver>("_driver");
            }

        }

        public T GetContextValue<T>(string key)
        {
            return _context.Get<T>(key);
        }

        public void SetContextValue<T>(string key,T value)
        {
            _context.Set(value, key);
        }

        private void InitDriver()
        {
            InitChromeDriver();
        }

        public void InitChromeDriver()
        {
            Logger.Info("InitChromeDriver");



            chromeDriverService = ChromeDriverService.CreateDefaultService();

            var options = new ChromeOptions();
            if (System.Environment.GetEnvironmentVariable("USEHEADLESS") == "1")
            {
                Logger.Info("Using Headless browser");

                options.AddArgument("--headless");
            }
            options.AcceptInsecureCertificates = true;
            AppDriver = new AppChromeDriver(chromeDriverService, options);
            AppDriver.Logger = Logger;
            Logger.Info("InitChromeDriver End");
        }

        public void Dispose()
        {
            // AppDriver.Dispose();
        }
    }
}
