using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using FacebookTest.Core.Entities;
using OpenQA.Selenium.Firefox;

namespace FacebookTest.Core
{

   public class TestEnvironment
    {
        #region Singleton

        private static TestEnvironment _testEnvironment;

        private TestEnvironment()
        {
        }

        public static TestEnvironment Instance
        {
            get
            {
                if (_testEnvironment == null)
                {
                      if (_testEnvironment == null) _testEnvironment = new TestEnvironment();
                }

                return _testEnvironment;
            }
        }

        #endregion

        public static void Initialize()
        {
             Instance.WaitLongRequestTimeout = int.Parse(Configurator.GetConfiguration("waitLongRequestTimeout"));
             Instance.WaitFastRequestTimeout = int.Parse(Configurator.GetConfiguration("waitFastRequestTimeout"));        
             
             Instance.Host = new Uri(Configurator.GetConfiguration("host"));
             Instance.Browser = Configurator.GetConfiguration("browser");
             Instance.User=new User
            {
                Login = Configurator.GetConfiguration("userlogin"),
                Password = Configurator.GetConfiguration("userpassword")
            };

             Instance.WebDriver = new FirefoxDriver(); 
            
           
        }

        public Uri Host { get; private set; }
        public User User { get; private set; }
        public string Browser { get; private set; }
        public int WaitLongRequestTimeout { get; private set; }
        public int WaitFastRequestTimeout { get; private set; }

        internal IWebDriver WebDriver { get; private set; }

        public static void Exit()
        {
            if (Instance.WebDriver != null)
            {
                Instance.WebDriver.Close();
                Instance.WebDriver.Dispose();
            }
        }
    }
}
