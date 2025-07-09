using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_Dhiraj_NB
{
    internal class search
    {
        static void Main(string[] args)
        {
            int[] ary = new int[5];
            Console.WriteLine("Enter 5 array elements:");

            for (int i = 0; i < ary.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                ary[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter element to search: ");
            int searchEle = Convert.ToInt32(Console.ReadLine());

            int flag = 0;
            int index = -1;

            for (int i = 0; i < ary.Length; i++)
            {
                if (ary[i] == searchEle)
                {
                    flag = 1;
                    index = i;
                    break;
                }
            }

            if (flag == 1)
            {
                Console.WriteLine($"Element {searchEle} found at index {index} (position {index + 1}).");
            }
            else
            {
                Console.WriteLine($"Element {searchEle} not found in the array.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        } 
    } 
}

