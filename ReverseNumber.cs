using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringassignement
{
    public class ReverseNumber
    {
        //WAP to reverse the array itself, don’t print array in reverse – I want current array reverse. 
        public static void ReverseArray(int[] array)
        {

            int last = array.Length - 1;
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[last];
                array[last] = temp;
                last--;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            ReverseArray(array);
        }
    }
}