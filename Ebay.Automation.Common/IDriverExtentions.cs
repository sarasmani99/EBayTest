using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ebay.Automation.Common
{
    public static class IWebDriverExtentions
    {
        public static IWebElement GetElement(this IWebDriver driver, By by, params Type[] exceptionTypesToIgone)
        {
            return _GetElement(driver, null, by, false, exceptionTypesToIgone);
        }

        private static IWebElement _GetElement(IWebDriver driver, ISearchContext context, By by, bool checkVisible, params Type[] exceptionTypesToIgore)
        {
            if (context == null) context = driver;

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(5));
            wait.IgnoreExceptionTypes(exceptionTypesToIgore);
            return wait.Until<IWebElement>((d) =>
            {
                var element = context.FindElement(by);
                if (element != null)
                {
                    if (checkVisible && element.Displayed)
                    {
                        return element;
                    }
                    else if (!checkVisible)
                    {
                        return element;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }

            });
        }

        public static IWebElement GetElementOrNull(this ISearchContext driver, By by)
        {
            try
            {
                return driver.FindElement(by);
            }
            catch (NoSuchElementException ex)
            {
                return null;
            }
        }

    }

}
