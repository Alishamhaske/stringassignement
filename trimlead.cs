using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringassignement
{
    internal class trimlead
    {
        static void Main(string[] args)
        {
            string str1 = "hello world";
            string str2 = "         hello          everyone";
            //4.	Write a C# program to trim leading white space characters in a string.
            Console.WriteLine("without trim first string"+str1);
            Console.WriteLine("trim leading is:"+str1.Trim());
            Console.WriteLine("without trim second string" + str2);
            Console.WriteLine("trim leading is:" + str2.Trim());
        }


    }
}
