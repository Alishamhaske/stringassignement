using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringassignement
{
    public class CheckEquality
    {
        //Write a  program to test the equality of two arrays.
        //Means e.g arr1[] = [12, 22, 32, 42, 52, 62] and arr2[] = [52, 22, 62, 12, 42, 22] Here both arrays are equal.


        public static void CheckEuqalarray(int[] array1, int[] array2)
        {
            int count =0;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = i + 1; j < array1.Length; j++)
                {
                    if (array1.Length==array2.Length)
                    {
                        count++;
                    }
                }
            }

            if (count==1)
            {
                Console.WriteLine("Equal!!!");
            }
            else
            {
                Console.WriteLine("not equal");
            }


        }

        public static void Main(string[] args)
        {
            int[] array1 = new int[] { 12, 22, 32, 42, 52, 62 ,77};
            int[] array2 = new int[] { 52, 22, 62, 12, 42, 22 };
            CheckEuqalarray(array1, array2);
        }
    }
}