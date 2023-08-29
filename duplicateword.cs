using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringassignement
{
    internal class duplicateword
    {
        static void Main(string[] args)
        {
            // 15.Write a C# program to find the duplicate words and their number of occurrences in a string  
           
            Console.WriteLine("enetr a string");
            string st = Convert.ToString(Console.ReadLine());
            string[] str = st.Split();
            //Console.WriteLine("seperate :");
          
            for (int i =0;i<str.Length;i++)

            {
               for(int j=i+1;j<str.Length;j++)
                {
                    if (str[i] == str[j])
                    {
                        Console.WriteLine(str[i]);
                    }
                }

            }
        }
    }
}
