using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringassignement
{
    internal class toggle
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("enter a string:");
            string str1 = Convert.ToString(Console.ReadLine());
            char[] c = str1.ToCharArray();
            //ascii value A=65
            //a=97
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] >= 'A' && c[i] <= 'Z')
                {

                    c[i] = (char)(c[i] + 32);
                    Console.WriteLine(c[i]);

                }
                else if (c[i] >= 'a' && c[i] <= 'z')
                {
                    c[i] = (char)(c[i] - 32);
                    Console.WriteLine(c[i]);
                }
            }

        }



    }
}
