using FacebookTest.Utilities.Waiters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookTest.Pages.Objects
{
    public class HomePage : AbstractPage
    {
        public static string GetFacebookLogo()
        {
            WaitExtensions.WaitUntilElementAppears(PageHelpers.HomePage.FacebookLogoLocator);
            return Driver.FindElement(PageHelpers.HomePage.FacebookLogoLocator).Text.ToString();
        }
    }
}
