﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringassignement
{
    internal class reverseword
    {
        static void Main(string[] args)
        {
            //reverse word in string
            string str2 = "";
            Console.WriteLine("enetr a string");
            string st = Convert.ToString(Console.ReadLine());
            string[] str = st.Split();
            //Console.WriteLine("seperate :");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                str2 = str2 + " " + str[i];
                Console.WriteLine(str[i]);

            }
            Console.WriteLine(" ");
            Console.WriteLine(" string after reverse word in string : " + str2);





        }
    }
}
