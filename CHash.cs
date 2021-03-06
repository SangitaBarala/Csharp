using System;
using System.Linq;
using System.Text;

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

            Console.WriteLine("Q11:output");
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine("array is " + string.Join(",", array));
            Console.WriteLine("new array is " + string.Join(",", (rotate(array, 2))));

            Console.WriteLine("Q12:output");
            Console.Write(substr("HelloWorld", "3 7"));

            Console.WriteLine("Q13:output");
            string[] name = {"julia","1julia","samantha","samantha_21","samatha-21"};
            /*Console.WriteLine(Validate(name));*/

            Console.WriteLine("Q14:output");
            int n = Convert.ToInt32(Console.ReadLine());
            StringBuilder s = new StringBuilder(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            string result = Cipher(s, k);
            Console.WriteLine(result);

            Console.WriteLine("Q15:output");
            string[] values = {"lmnop","bcxz","acxz"};
            string[] result1 = funnyStr(3,values);
            for(int i=0; i<result1.Length; i++)
            {
                Console.WriteLine(result1[i]);
            }

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

        /*Q11:Array rotation. 
                
         * @param int[] array
         * @param int d
         * @return int[] array
         */
        public static int[] rotate(int[] array, int d)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int arrIndex = i - d;
                int rotation = array.Length + arrIndex;

                if (arrIndex >= 0)
                {
                    newArray[arrIndex] = array[i];
                }
                else
                {
                    newArray[rotation] = array[i];
                }
            }
            return newArray;
        }

        /*Q12 grab a substring that lies in given range of start and end.
          
         * @param string str
         * @param string value
         * return string
         */
        public static string substr(string str, string value)
        {
            string[] names = (value.Split(" "));
            int s = Convert.ToInt32(names[0]);
            int e = Convert.ToInt32(names[1]);

            foreach (char c in str)
            {
                if (!char.IsLetter(c))
                {
                    Console.WriteLine("enter a valid string");
                }

            }
            if (s < 0 || s >= e || e > str.Length)
            {
                Console.WriteLine("value is out of bound");
            }

            int Strlength = e - s;
            return str.Substring(s, Strlength);
        }

        /*Q13 Based on certain conditions check whether given string is valid or invalid.
         
         * @param string name
         * @return string
         */
        public static void Validate(string[] name)
        {
            
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].Length < 8 || name[i].Length > 30)
                {
                    Console.WriteLine(name[i]+"invalid");
                }
                else
                {
                    string temp = name[i];
                    int validation = 0;
                    if (!char.IsLetter(temp[0]))
                    {
                        Console.WriteLine(temp + "invalid");
                    }
                    else
                    {
                        for (int j = 1; j < temp.Length - 1; j++)
                        {
                            if (((int)temp[j] >= 65 && (int)temp[j] <= 90) || ((int)temp[j] >= 97 && (int)temp[j] <= 122) || (int)temp[j] == 95)
                            {
                                validation = 0;
                            }
                            else
                            {
                                validation += 1;
                            }
                            Console.WriteLine(validation != 0 ? temp + "invalid" : temp + "valid");
                            Console.ReadKey();
                        }
                    }
                }
            }
        }

        /*Q14 Convert plaintext into ciphertext.
         
         * @param int n
         * @param string s
         * @param int k
         * @return string
         */
        public static string Cipher(StringBuilder s, int k)
        {
            k %= 26;
            for (int i = 0; i < s.Length; i++)
            {
                int a = Convert.ToInt32(s[i]);

                if ((a >= 65 && a <= 90))
                {
                    if (a + k > 90)
                    {
                        s[i] = (char)(k - Math.Abs(a - 90) + 64);
                    }
                    else
                    {
                        s[i] = (char)(a + k);
                    }
                }
                else if ((a >= 97 && a <= 122))
                {
                    if (a + k > 122)
                    {
                        s[i] = (char)(k - Math.Abs(a - 122) + 96);
                    }
                    else
                    {
                        s[i] = (char)(a + k);
                    }
                }   
            }
            return s.ToString();
        }

        /*Q14 Based on the absolute diffrence between ASCII value of string's letter check whether string is funny or not funny.
         
         * @param int q
         * @param string s
         * @return string
         */
        public static string[] funnyStr(int q, string[] s)
        {
            string[] result= new string [q];
            for(int i = 0; i < s.Length; i++)
            {
                char[] strArray = s[i].ToCharArray();
                Array.Reverse(strArray);
                string rev = new string(strArray);
                int temp = 0;
                for(int j = 1; j < strArray.Length; j++)
                {
                    int orgStr = Math.Abs((int)s[i][j]-(int)s[i][j-1]);
                    int revStr = Math.Abs((int)rev[j] - (int)rev[j - 1]);
                    if(orgStr != revStr)
                    {
                        temp = temp + 1;
                    }
                }
                result[i] = (temp != 0 ? "Not Funny" : "Funny");
            }
            return result;
        }
    }
}

