using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringassignement
{
    public class anagramstring
    {
        static void Main(string[] args)
        {
            //16.	Write a C# program to check whether two strings are anagram or not?

            //program logic is correct but namespace problem
            Console.WriteLine("enter a string:");

            string str = Console.ReadLine();
            string str1 = Console.ReadLine();


            str = str.ToLower();
            str1 = str1.ToLower();

            char[] c1 = str.ToCharArray();
            char[] c2 = str1.ToCharArray();

            Array.Sort(c1);
            Array.Sort(c2);
            string str3 = new string(c1);
            string str4 = new string(c2);

            if (str3 == str4)
            {
                Console.WriteLine("Anagram string");
            }
            else
            {
                Console.WriteLine("Not an anagram");
            }





        }
    }
}
