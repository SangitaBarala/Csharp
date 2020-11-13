using System;

namespace HelloWorld
{
    class sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(3, 5));
            Console.WriteLine(Sum(3, 3));
            Console.ReadLine();
        }
        public static int Sum(int a, int b)
        {
            // Always add 2 lines between methods
            // try to do it like -> if(a == b)
            if(a==b)
            {
                return (a + b) * 3;
            }
            else
            {
                return a + b;
            }
                
        }

    }
}

