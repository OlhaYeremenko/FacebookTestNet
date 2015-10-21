using FacebookTest.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using FacebookTest.Utilities.Waiters;
using FacebookTest.Core.Entities;

namespace FacebookTest.Pages
{
    public class LoginPage : AbstractPage
    {
        public static void Goto()
        {
            var loginUri = new Uri(TestEnvironment.Instance.Host, "Account/Login");
            Driver.Navigate().GoToUrl(loginUri);
        }

        public static string Title()
        {
            return Driver.Title.ToString();
        }

        public static void Login(User user)
        {
            WaitExtensions.WaitUntilElementAppears(PageHelpers.LoginPage.TextLoginLocator);
            Driver.FindElement(PageHelpers.LoginPage.TextLoginLocator).SendKeys(user.Login);

            WaitExtensions.WaitUntilElementAppears(PageHelpers.LoginPage.TextPasswordLocator);
            Driver.FindElement(PageHelpers.LoginPage.TextPasswordLocator).SendKeys(user.Password);

            WaitExtensions.WaitUntilElementAppears(PageHelpers.LoginPage.LoginButtonLocator);
            var LogInButton = Driver.FindElement(PageHelpers.LoginPage.LoginButtonLocator);
            LogInButton.Click();                       
       }
    }
}
