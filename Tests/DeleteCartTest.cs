using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Tests
{
    public class DeleteCartTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            //Logovanje na stranici
            Pages.LoginPage.Login(TestData.TestData.Login.username, TestData.TestData.Login.password);
        }
        [Test]
        public void DeleteFromCart()
        {
            Pages.HomePage.NavigateToItem(TestData.TestData.AddToCart.categoryName, TestData.TestData.AddToCart.itemName);
            Pages.HomePage.AddToCart();

            //uporedjuje odgovor sa odgovorom iz alertboxa
            string alertBoxMessage = Pages.HomePage.ReadTextFromAlertBox();
            Assert.AreEqual(alertBoxMessage, TestData.TestData.AlertBoxMessages.ProductAdded);

            //Klikce ok u alertBoxu
            Pages.HomePage.AcceptAlertBox();
            
            //klik na cart
            Pages.HomePage.ClickOnCartLink();

            //brisanje prvog elementa u korpi
            Pages.HomePage.DeleteFirstRow();
        }
    }
}
