//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace _24SOECE13009_Dhiraj_NB
//{

//    internal class Book
//    {
//        //default constructor

//        int Bid;
//        string Btitle;
//        string Bauthor;
//        double Bprice;
//        public Book()
//        {
//            Console.WriteLine("Enter bookid");
//            Bid = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter booktitle");
//            Btitle = Console.ReadLine();
//            Console.WriteLine("Enter bookauthor");
//            Bauthor = Console.ReadLine();
//            Console.WriteLine("Enter bookprice");
//            Bprice = Convert.ToInt32(Console.ReadLine());
//        }

//        public void showData()
//        {
//            Console.WriteLine("Enter bookid " + Bid);
//            Console.WriteLine("Enter booktitle " + Btitle);
//            Console.WriteLine("Enter bookauthor" + Bauthor);
//            Console.WriteLine("Enter bookprice" + Bprice);
//        }
//    }
//    public class constructor_exercise
//    {
//        //object initilize with array
//        public static void Main(string[] args)
//        {
//            constructor_exercise[] s = new constructor_exercise[2];
//            for (int i = 0; i < s.Length; i++)
//            {
//                s[i] = new constructor_exercise();
//            }

//            Console.WriteLine("Details of books:");
//            for (int i = 0; i < s.Length; i++)
//            {
//                Console.WriteLine("boks " + (i + 1) + " details:");
//                s[i].showData();
//            }

//        }
//    }
//}

using System;

namespace _24SOECE13009_Dhiraj_NB
{
    public class Employee1
    {
        int eID;
        string eName;
        double eSalary;

        // Constructor that accepts parameters
        public Employee1(int id, string name, double salary)
        {
            eID = id;
            eName = name;
            eSalary = salary;
        }

        public void showData()
        {
            Console.WriteLine("Employee ID is: " + eID);
            Console.WriteLine("Employee Name is: " + eName);
            Console.WriteLine("Employee Salary is: " + eSalary);
        }
    }

    internal class constructor_exercise
    {
        public static void Main(string[] args)
        {

            int id = int.Parse(args[0]);
            string name = args[1];
            string salary = args[2];

            Console.WriteLine();
        }
    }
}
