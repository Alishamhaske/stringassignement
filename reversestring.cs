using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringassignement
{
    internal class reversestring
    {
        //10.	Write a C# program to find reverse of a string.
       
        static void Main(string[] args)
        {
            string str = "hello";
            string s = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                s = s + str[i];
            }
            Console.WriteLine(s);

        }
    }
}
