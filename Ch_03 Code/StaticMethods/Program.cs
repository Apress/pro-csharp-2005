#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace StaticMethods
{
    #region Teenager Class
    class Teenager
    {
        private static Random r = new Random();
        private static int GetRandomNumber(short upperLimit)
        { return r.Next(upperLimit); }

        public static string Complain()
        {
            string[] messages = new string[5]{  "Do I have to?",
               "He started it!", "I'm too tired...",
               "I hate school!", "You are sooo wrong." };
            return messages[GetRandomNumber(5)];
        }

        // OK, Teens are not always upset ;-)
        public static string BeAgreeable()
        {
            string[] messages = new string[3]{  "Sure!  No problem!", 
               "Uh uh.", "I guess so." };
            return messages[GetRandomNumber(3)];
        }
    } 
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Ahh, Youth... *****\n");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-> {0}", Teenager.Complain());
                Console.WriteLine("-> {0}", Teenager.BeAgreeable());
            }
            Console.ReadLine();
        }
    }
}
