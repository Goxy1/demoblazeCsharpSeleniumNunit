using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class LogOutTest:BaseTest
    {
        [SetUp]
        public void Setup()
        {
            //Logovanje na stranici
            Pages.LoginPage.Login(TestData.TestData.Login.username, TestData.TestData.Login.password);
        }
        [Test]
        public void LogOut() 
        {
            Pages.LogOutPage.LogOut();
        }
    }
}
