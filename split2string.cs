using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringassignement
{
    internal class split2string
    {
        static void Main(string[] args)
        {
            //1.	WAP to split string into 3 tokens where string is “HELLO$WORLD”
            string str1 = "hello$world$everyone";

            string[] arr = str1.Split('$');
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
        }
    }
}
