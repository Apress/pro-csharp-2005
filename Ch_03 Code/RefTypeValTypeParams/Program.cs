using System;

namespace MethodsAndParams
{
    #region Person helper class
    // Simple class to demo params keyword.
    class Person
    {
        public string fullName;
        public int age;

        public Person(string n, int a)
        {
            fullName = n;
            age = a;
        }

        public void PrintInfo()
        {
            Console.WriteLine("{0} is {1} years old", fullName, age);
        }
    }
    #endregion

    class Program
    {
        #region Static helper methods.
        public static void ArrayOfObjects(params object[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] is Person)
                {
                    ((Person)list[i]).PrintInfo();
                }
                else
                    Console.WriteLine(list[i]);
            }
            Console.WriteLine();
        }

        public static void SendAPersonByValue(Person p)
        {
            // Change some data of 'p'.
            p.age = 99;

            // This will be forgotten after the call!
            p = new Person("Nikki", 999);
        }

        public static void SendAPersonByReference(ref Person p)
        {
            // Change some data of 'p'.
            p.age = 555;

            // 'p' is now reassigned!
            p = new Person("Nikki", 999);
        }
        #endregion

        public static void Main()
        {
            // Passing ref-types by value.
            Console.WriteLine("***** Passing Person object by value *****");
            Person fred = new Person("Fred", 12);
            Console.WriteLine("Before by value call, Person is:");
            fred.PrintInfo();
            SendAPersonByValue(fred);
            Console.WriteLine("After by value call, Person is:");
            fred.PrintInfo();

            // Passing ref-types by ref.
            Console.WriteLine("\n***** Passing Person object by reference *****");
            Person mel = new Person("Mel", 23);
            Console.WriteLine("Before by ref call, Person is:");
            mel.PrintInfo();
            SendAPersonByReference(ref mel);
            Console.WriteLine("After by ref call, Person is:");
            mel.PrintInfo();

            Console.ReadLine();
        }
    }
}