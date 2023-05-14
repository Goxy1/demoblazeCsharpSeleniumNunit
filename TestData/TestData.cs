using System;

namespace AutomationFramework.TestData
{
    public class TestData
    {
        public static class AlertBoxMessages
        {
            public const string ProductAdded = "Product added.";
        }

        public static class PopUpMessages
        {
            public const string PurchaseComplete = "Thank you for your purchase!";
        }

        public static class Login
        {
            public const string username = "test",
                                password = "test",
                                invalidUsername = "wrong user name ctsi",
                                invalidPassword = "invalidpassword";
        }

        public static class Contact
        {
            public const string email = "nekifensiemail@gmail.com",
                                name = "neko fensi ime sa sufiksom iphone",
                                message = "iphone je MOZDA najbolji telefon";
        }
        /// <summary>
        /// Metoda koja ce generisati random username iq200 move
        /// </summary>
        public static class SignUpUser
        {
            public static string GenerateRandomUsername()
            {
                var random = new Random();
                return "user" + random.Next(10000, 99999);
            }
            public const string password = "fensiusernamekojinosiiphone12";
        }

        public static class AddToCart
        {
            public const string categoryName = "Phones",
                                itemName = "Iphone 6 32gb";
        }

        public static class PurchaseItem
        {
            public const string name = "Vuk",
                country = "Banglades",
                city = "Madrid",                
                month = "12",
                year = "1947";
            public const long creditCard = 2050000001234533;
        }
    }
}

