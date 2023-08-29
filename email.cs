using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringassignement
{
    internal class email
    {
        /*20.	Accept email_id from user and check valid or not(should contain @,.)*/
        static void Main(string[] args)
        {
            Console.WriteLine("enter email id: ");
            string st = Console.ReadLine();
            int cnt = 0;

            char[] c = st.ToCharArray();

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == '@')
                {
                    cnt++;
                }

            }
            if (cnt == 1) 
            {
                Console.WriteLine("Valid mail id");
            }
            else
            {
                Console.WriteLine("Invalid mail Id");
            }
        }


    }
}
