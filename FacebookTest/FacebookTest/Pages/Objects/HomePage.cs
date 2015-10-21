using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookTest.Pages.PageHelpers
{
   public class HomePage
    {
        public static By FacebookLogoLocator
        {
            get { return By.ClassName("_48pw"); }
        }
    }
}
