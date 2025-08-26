using System;

namespace _24SOECE13009_Dhiraj_NB
{
    public class Demo1
    {
        int x;          // private members of class 
        int y;

        public Demo1(int x, int y) // Constructor added to fix the error
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }             // read-only property
        }

        public int Y
        {
            get { return y; }             // read-only property
        }
    }

    class property
    {
        static void Main()
        {
            Demo1 ob = new Demo1(10, 20);

            Console.WriteLine("x= " + ob.X);
            Console.WriteLine("y= " + ob.Y);
            Console.WriteLine("Sum= " + (ob.X + ob.Y));
        }
    }
}