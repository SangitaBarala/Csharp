using System;

namespace DotnetQuestion
{
    class CHash
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q1:output");
            Console.WriteLine(Sum(20, 20));
            Console.WriteLine(Sum(20, 30));

            Console.WriteLine("Q2:output");
            Console.WriteLine(check(30, 20));
            Console.WriteLine(check(20, 5));
            Console.WriteLine(check(15, 15));

            Console.WriteLine("Q3:output");
            Console.WriteLine(append("else"));
            Console.WriteLine(append("if else"));

            Console.WriteLine("Q4:output");
            Console.WriteLine(Check1("Python", 1));
            Console.WriteLine(Check1("Python", 4));

            Console.WriteLine("Q5:output");
            Console.WriteLine(check2("abcd"));

            Console.WriteLine("Q6:output");
            Console.WriteLine(repeat("Hope"));
            Console.WriteLine(repeat("Happy"));

            Console.WriteLine("Q7:output");
            Console.WriteLine(Addstr("hello"));
            Console.WriteLine(Addstr("sangita"));

            Console.WriteLine("Q8:output");
            Console.WriteLine(checkstr("python"));
            Console.WriteLine(checkstr("JS"));

            Console.WriteLine("Q9:output");
            Console.WriteLine(checkfirststr("C# sharp"));
            Console.WriteLine(checkfirststr("C++"));

            Console.WriteLine("Q10:output");
            Console.WriteLine(RangeTest(11, 34, 10));
            Console.WriteLine(RangeTest(10, 16, 17));
            Console.WriteLine(RangeTest(11, 34, 50));

           }

        /*Q1:.Write a C# Sharp program to compute the sum of the two given integer values. 
         * If the two values are the same, then return triple their sum.
         * 
         * @param int a
         * @param int b
         * @return int
         */
        public static int Sum(int a, int b)
        {
            if (a == b)
            {
                return (a + b) * 3;
            }
            else
            {
                return a + b;
            }
        }

        /*Q2:Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
         
         * @param boolean a
         * @param booeanl b
         * @return boolean
         */
        public static Boolean check(int a, int b)
        {
            if ((a == 30 || b == 30) || (a + b) == 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*Q3: Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. 
         * If the string already begins with 'if', return the string unchanged.
         * 
         * @param string str
         * return string
         */

        public static string append(string str)
        {
            if (str.Length > 2 && str.Substring(0, 2).Equals("if"))
            {
                return str;
            }
            else
            {
                return "if " + str;
            }
        }

        /*Q4;Write a C# Sharp program to remove the character in a given position of a given string. 
         * The given position will be in the range 0.. string length -1 inclusive.
         
         * @param string str
         * @param int n
         * @return string
         */
        public static string Check1(string str, int n)
        {
            return str.Remove(n, 1);
        }

        /*Q5:Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
         
         * @param string s
         * @return string
         */
        public static string check2(string s)
        {
            if (s.Length == 1)
            {
                return s;
            }
            else
            {
                return (s.Substring(s.Length - 1)) + (s.Substring(1, s.Length - 2)) + (s[0]);
            }
        }

        /*Q6:Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string. If the given string
         * length is less than 2 return the original string.
         
         * @param string str
         * @return string
         */
        public static string repeat(string str)
        {
            if (str.Length < 2)
            {
                return str;
            }
            else
            {
                return str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2);
            }
        }

        /*Q7:Write a C# Sharp program to create a new string with the last char added at the front and
            back of a given string of length 1 or more.
        
         * @param string str
         * @return string*/
       public static string Addstr(string str)
        {
            return str.Substring(str.Length - 1) + str + str.Substring(str.Length - 1);
        }


        /*Q8:Write a C# Sharp program to create a new string taking the first 3 characters of a given string and return the string with
         the 3 characters added at both the front and back.If the given string length is less than 3, use whatever characters are there.
        
         * @param string str
         * @return string
         */
        public static string checkstr(string str)
        {
            if (str.Length < 3)
            {
                return str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2);
            }
            else
            {
                return str.Substring(0, 3) + str + str.Substring(0, 3);
            }
        }

        /*Q9:Write a C# Sharp program to check if a given string starts with 'C#' or not.
         
         * @param string str
         * @return Boolean
         */
       public static Boolean checkfirststr(string str)
        {
            if (str.StartsWith("C#"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*Q10:Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive. 
         Return true if 1 or more of them are in the said range otherwise false.
        
         * @param int a
         * @param int b
         * @param int c
         * @return boolean
         */
        public static Boolean RangeTest(int a, int b, int c)
        {
            if ((a >= 20 && a <= 50) || (b >= 20 && b <= 50) || (c >= 20 && c <= 50))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
