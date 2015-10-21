using FacebookTest.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookTest.Pages
{
    public abstract class AbstractPage
    {
        protected static IWebDriver Driver
        {
            get { return TestEnvironment.Instance.WebDriver; }
        }

        protected static bool IsElementPresentOnPage(By locator)
        {
            return Driver.FindElements(locator).Any(e => e.Displayed);
        }
    }
}
