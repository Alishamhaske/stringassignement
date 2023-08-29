using oopfirstclass_program.stringfunc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringassignement
{
    internal class longestword
    {
        static void Main(string[] args)
        {
            //incomplete
            Console.WriteLine("enter a string:");
            string str1 = Console.ReadLine();
            int max=0;
            string[] arr = str1.Split(' ');
            string longelement = " ";
            for(int i=0;i<arr.Length;i++)
            {
                int a = arr[i].Length;
                if(a>max)
                {
                    max = a;
                    longelement = arr[i];
                     
                }
               
            }
            Console.WriteLine("longest element:" + longelement);

        }
    }
}
