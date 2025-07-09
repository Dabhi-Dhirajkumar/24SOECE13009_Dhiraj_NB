using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_Dhiraj_NB
{
    internal class maximum
    {
        static void Main(string[] args)
        {
            int[] ary = new int[5];

            Console.WriteLine("Enter array element");

            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());
            }

            int a = 0;
            Console.WriteLine();
            for (int i = 0; i < ary.Length; i++)
            {
                if (a < ary[i])
                {
                    a = ary[i];
                    continue;
                }

            }
            Console.WriteLine("Maximum number is:"+a);



        }
    }
}

