using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringassignement
{
    public class indiareverse
    {
        static void Main(string[] args)
        {
            //reverse word in string
            string str2 = "";
              string st = "india is the best";
              string[] str = st.Split();
              //Console.WriteLine("seperate :");
              for(int i=str.Length-1;i>=0;i--)
              {
                   str2 = str2+" "+ str[i];
                  Console.WriteLine(str[i]);
               
              }
            Console.WriteLine(" ");
            Console.WriteLine(" string after reverse word in string : " +str2);





        }
    }
}
