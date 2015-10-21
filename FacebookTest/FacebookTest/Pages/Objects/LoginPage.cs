using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookTest.Pages.PageHelpers
{
    public  class LoginPage
    {
        public static By TextLoginLocator
        {
            get { return By.Id("email"); }
        }

        public static By TextPasswordLocator
        {
            get { return By.Id("pass"); }
        }

        public static By LoginButtonLocator
        {
            get { return By.Id("loginbutton"); }
        }
    }
}
