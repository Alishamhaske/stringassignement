using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringassignement
{
    internal class vowel
    {
        static void Main(string[] args)
        {
            //9.	Write a C# program to count total number of vowels and consonants in a string.

            string str1 = "GOod night";
          
            char[] strobj = str1.ToCharArray();
            int cnt1 = 0;
            int cnt2 = 0;
            for(int i=0; i<strobj.Length;i++)
            {
                if (strobj[i] =='a'|| strobj[i]== 'e' || strobj[i] == 'i' || strobj[i] == 'o' || strobj[i] == 'u'||
                    strobj[i] == 'A' || strobj[i] == 'E' || strobj[i] == 'I' || strobj[i] == 'O' || strobj[i] == 'U')
                {
                    cnt1++;
                    
                }
                else if(strobj[i]!=' ')
                {
                    cnt2++;

                }
              

            }
            Console.WriteLine("number of vowel is: " + cnt1);
            Console.WriteLine("number of constant is: " + cnt2);
           
        }
    }
}
