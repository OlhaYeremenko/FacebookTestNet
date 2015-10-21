using FacebookTest.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookTest.Utilities.Waiters
{
    public static class WaitExtensions
    {
     
        public static WebDriverWait Wait(this IWebDriver driver, int seconds)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
        }

        #region Element and By extensions


        public static void WaitUntilElementAppears(this By locator)
        {
            var driver = TestEnvironment.Instance.WebDriver;
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, TestEnvironment.Instance.WaitLongRequestTimeout));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public static void WaitUntilElementDisappears(this IWebElement element)
        {
            var driver = TestEnvironment.Instance.WebDriver;
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, TestEnvironment.Instance.WaitLongRequestTimeout));
            wait.Until(d => !element.Displayed);      
        }

      
        public static void WaitUntilElementBecomeClickableAndClick(this IWebElement element)
        {
            var driver = TestEnvironment.Instance.WebDriver;           
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, TestEnvironment.Instance.WaitLongRequestTimeout));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }

        #endregion Element and By extensions

    } 
}
