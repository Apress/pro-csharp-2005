/** 
 ** NOTE!  +unsafe as been enabled !
 **/

using System;

namespace UnsafeCode
{
    #region structs for testing
    public struct Node
    {
        public int Value;
        public unsafe Node* Left;
        public unsafe Node* Right;
    }

    struct Point
    {
        public int x;
        public int y;
        public override string ToString()
        {
            return string.Format("({0}, {1})", x, y);
        }
    }

    struct MyValueType
    {
        public short s;
        public int i;
        public long l;
    }
    #endregion

    class Program
    {
        #region Unsafe Swap
        unsafe public static void UnsafeSwap(int* i, int* j)
        {
            int temp = *i;
            *i = *j;
            *j = temp;
        }
        #endregion

        #region Safe Swap
        public static void SafeSwap(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
        #endregion

        #region Safe method with unsafe code
        public static void SomeUnsafeCode()
        {
            unsafe
            {
                int myInt;
                int* ptrToMyInt = &myInt;

                // Assign value of myInt using pointer.
                *ptrToMyInt = 123;

                // print out address.
                Console.WriteLine("Value of myInt {0}", myInt);
                Console.WriteLine("Address of myInt {0:X}", (int)ptrToMyInt);
            }
        }
        #endregion

        static void Main(string[] args)
        {
            // Accessing safe field from safe code
            Node n = new Node();
            n.Value = 9;

            Console.WriteLine("***** Calling method with unsafe code *****");
            SomeUnsafeCode();

            // Values for swap.
            int i = 10, j = 20;

            // Swap values 'safely'.
            Console.WriteLine("\n***** Safe swap *****");
            Console.WriteLine("Values before safe swap: i = {0}, j = {1}", i, j);
            SafeSwap(ref i, ref j);
            Console.WriteLine("Values after safe swap: i = {0}, j = {1}", i, j);

            // Swap values 'unsafely'.
            Console.WriteLine("\n***** Unsafe swap *****");
            Console.WriteLine("Values before unsafe swap: i = {0}, j = {1}", i, j);
            unsafe { UnsafeSwap(&i, &j); }
            Console.WriteLine("Values after unsafe swap: i = {0}, j = {1}", i, j);

            // Access members via ->
            Console.WriteLine("\n***** Access members via -> *****");
            unsafe
            {
                Point point;
                Point* p = &point;
                p->x = 100;
                p->y = 200;
                Console.WriteLine(p->ToString());
            }

            // Use pointer indirection and . operator. 
            Console.WriteLine("\n***** Access members via . *****");
            unsafe
            {
                Point point;
                Point* p = &point;
                (*p).x = 100;
                (*p).y = 200;
                Console.WriteLine((*p).ToString());
            }

            // alloate a chuck on the stack.	
            unsafe
            {
                char* p = stackalloc char[256];
                for (int k = 0; k < 256; k++)
                    p[k] = (char)k;
            }

            // How big are you?
            Console.WriteLine("\n***** sizeof operations *****");
            unsafe
            {
                Console.WriteLine("The size of short is {0}", sizeof(short));
                Console.WriteLine("The size of int is {0}", sizeof(int));
                Console.WriteLine("The size of long is {0}", sizeof(long));
                Console.WriteLine("The size of MyValueType is {0}\n", sizeof(MyValueType));
            }
            Console.ReadLine();
        }
    }
}
