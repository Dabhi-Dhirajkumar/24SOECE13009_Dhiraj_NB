using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_Dhiraj_NB
{
    internal class array
    {
        static void Main(string[] args)
        {
            //first way to declare and initialize an array

            //int[] ary = new int[5]; // declaration of array 
            ////initializaton of array element 
            //ary[0] = 10;
            //ary[1] = 20;
            //ary[2] = 30;
            //ary[3] = 40;
            //ary[4] = 50;

            //second way to initialze
            //int[] ary = { 10, 20, 30, 40, 50 };

            //Console.WriteLine(ary[0]);
            //Console.WriteLine(ary[1]);
            //Console.WriteLine(ary[2]);
            //Console.WriteLine(ary[3]);
            //Console.WriteLine(ary[4]);

            //third way using for loop to print array elements
            //for (int i = 0; i < ary.Length; i++)
            //{
            //    Console.WriteLine(ary[i]);
            //}

            ////foreach  using keywod
            //int[]ary =new int[5];   
            //Console.WriteLine("Enter array elements");
            //for (int i = 0; i < ary.Length; i++)
            //{
            //    ary[i]=Int32.Parse (Console.ReadLine());
            //}
            //Console.WriteLine();
            //foreach (int var in ary)
            //{
            //    Console.WriteLine(var);
            //}
            int avg = 0;

            int[] ary = new int[5];
            Console.WriteLine("Enter array element");

            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            foreach (int var in ary)
            {
                Console.WriteLine(var);
            }

            for (int i = 0; i < ary.Length; i++)
            {
                avg = avg + ary[i];
            }
            Console.WriteLine();



            avg = avg / ary.Length;
            Console.WriteLine(avg);



        }
    }
}
