using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringassignement
{
    internal class countword
    {
        static void Main(string[] args)
        {
            string str = "HELLO$WORLD$everyone";
            string[] sarray = str.Split('$');
            int cntwords = 0;
            for (int i = 0; i < sarray.Length; i++)
            {
                cntwords++;
            }
            Console.WriteLine($"Total Words in String={cntwords}");//5
        }

    }
}
