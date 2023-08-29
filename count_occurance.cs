using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringassignement
{
    public class count_occurance
    {
        //3.	Write a C# program to count occurrences of a character in given string.
        static void Main(string[] args)
        {
            string str3 = "hello world";
            Console.WriteLine(str3.IndexOf('o') +"  first  ocurance of O ");
            char[] ch = str3.ToCharArray();
            int cnt = 0;
        


            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'l')
                {
                    cnt++;
                }
            }
            Console.WriteLine($"Occurance of L={cnt}");



        }
       
        

    }
}
