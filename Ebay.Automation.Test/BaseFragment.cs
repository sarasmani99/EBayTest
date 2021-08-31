using Ebay.Automation.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebay.Automation.Web
{
    public class BaseFragment
    {
        public IAppDriver Driver;
        public BaseFragment(IAppDriver driver)
        {
            this.Driver = driver;
        }
    }
}
