using oopfirstclass_program.stringfunc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringassignement
{
    public class revmoveoccarnce
    {
        static void Main(string[] args)
        {
            string str2 =" ";
            string str5 = "good morning";
            char[] strobj = str5.ToCharArray();

            Console.WriteLine("enter a character: ");
            char c = Convert.ToChar(Console.ReadLine());

            for(int i=0;i<strobj.Length;i++)
            {
                if (strobj[i]==c)
                {

                   str2= str5.Replace(strobj[i], ' ');
                    
                }
                

            }
            Console.WriteLine(str2);




        }

    }
}
