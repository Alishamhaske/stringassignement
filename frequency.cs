using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringassignement
{
    public class frequency
    {
        //12.	Write a C# program to find highest frequency character in a string.
        static void Main(string[] args)
        {
            string str1 = "good morning";
            int cnt = 0;
            char c = 'c';

            char[] strarr = str1.ToCharArray();

            for(int i=0;i<strarr.Length;i++)
            {
                if (strarr[i]==c)
                {
                    cnt++;
                }
                
            }
            Console.WriteLine("highest frequncy:: "+cnt);




        }
    }
}
