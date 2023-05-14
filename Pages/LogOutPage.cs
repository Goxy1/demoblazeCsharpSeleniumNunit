using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Pages
{
    public class LogOutPage:BasePage
    {

        /// <summary>
        /// Konstruktor bez parametra
        /// </summary>
        public LogOutPage()
        {
            driver = null;
        }
        /// <summary>
        /// Konstruktor sa parametrima
        /// </summary>
        /// <param name="webDriver">Driver</param>
        public LogOutPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Locators

        By logOutField = By.Id("logout2");

        /// <summary>
        /// Metoda koja ce kliknuti logout link
        /// </summary>
        private void ClickOnLogOutLink()
        {
            ClickOnElement(logOutField);
        }
        /// <summary>
        /// Metoda koja vrsti logout
        /// </summary>
        public void LogOut()
        {
            ClickOnLogOutLink();
        }
    }
}
