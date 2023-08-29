using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringassignement
{
    internal class specailchar
    {
        //13.	Write a C# program to find total number of alphabets, digits or special character in a string.
        static void Main(string[] args)
        {
            string str = "helllo##12 everyone***123";
            int cnt1 = 0, cnt2 = 0, cnt3 = 0;
            char[] ch = str.ToCharArray();
         

            for (int i=0;i<ch.Length;i++)
            {
                if ((ch[i]>=65 && ch[i]<=90)|| (ch[i]>= 97 && ch[i]<=122))
                {
                    cnt1++;
                }
               
                else if (ch[i] >='0'&& ch[i]<='9')

                {
                    
                    cnt2++;
                }
                else if(ch[i]!=' ')
                {
                    cnt3++;
                }

            }
            Console.WriteLine("total number of alphabet "+cnt1);
            Console.WriteLine("total number of digit "+cnt2);
            Console.WriteLine("total number of specail symbol "+cnt3);



        }
    }
}
