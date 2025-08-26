//using System;

//namespace _24SOECE13009_Dhiraj_NB
//{
//    internal class sttatic
//    {
//        public class Demo2
//        {
//            int x;
//            static int y = 20;

//            public Demo2() { }

//            public Demo2(int x)
//            {
//                this.x = x;
//            }

//            public static int addNum()
//            {
//                Demo2 ob = new Demo2();
//                return (ob.x + y);   // ob.x will be 0 (default)
//            }

//            public void show()
//            {
//                Console.WriteLine("x is: " + x);
//                Console.WriteLine("y is: " + Demo2.y);
//            }
//        }

//        internal class StaticDemo1
//        {
//            static void Main(string[] args)
//            {
//                Demo2 demo = new Demo2(30);

//                Console.WriteLine("Addition is: " + Demo2.addNum());
//                demo.show();

//            }
//        }
//    }
//}

using System;
using System.Runtime.Remoting.Channels;

public static class Demo2
{
    static int x = 10;
    static Demo2()
    {
        Console.WriteLine("Static Constructor called");
    }
    public static void show()
    {
        Console.WriteLine("x is:" + x);
    }
    internal class sttatic
    {
        static void Main(string[] args)
        {
            Demo2.show();
        }
    }



    