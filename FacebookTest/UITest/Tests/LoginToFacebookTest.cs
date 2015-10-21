using System;

using NUnit.Framework;
using FacebookTest.Core;
using FacebookTest.Pages;
using FacebookTest.Pages.Objects;

namespace FacebookTest
{
    [TestFixture]
    public class LoginToFacebookTest
    {
        [SetUp]
        public void TestInitialize()
        {
            TestEnvironment.Initialize();
        }


        [Test(Description = "Sholud login to Facebook")]
        public void ShouldLoginToFacebook()
        {
            var facebook = "Facebook";

            LoginPage.Goto();
            Assert.IsTrue(LoginPage.Title().Contains(facebook));

            LoginPage.Login(TestEnvironment.Instance.User);

            Assert.IsTrue(HomePage.GetFacebookLogo().Contains(facebook));
        }

        [TearDown]
        public void TestCleanup()
        {
          TestEnvironment.Exit();
        }
    }
}
