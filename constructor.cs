using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_Dhiraj_NB
{
    internal class student
    {
        int rlno;
        string name;

        //default constructor
        public student()
        {
            Console.WriteLine("Enter rollnumber");
            rlno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            name = Console.ReadLine();

        }

        //parameterized constructor
        public student(int rlno, string name)
        {
            this.rlno = rlno;
            this.name = name;
        }

        //copy constructor
        public student(student s)
        {
            rlno = s.rlno;
            name = s.name;
        }

        //static constructor
        static student()
        {
            Console.WriteLine("Static Constructor Called");
        }

        public void showData()
        {
            Console.WriteLine("Roll No: " + rlno);
            Console.WriteLine("Name: " + name);
        }
    }

    internal class Democlass
    {
        public static void Main(string[] args)
        {
            // Using default constructor
            student s1 = new student();
            s1.showData();

            // Using default constructor again to show that it can be reused
            student s2 = new student();
            s2.showData();


            // Using parameterized constructor
            student s3 = new student(110, "dhiraj");
            s3.showData();

            int rollNo = 101;
            string studentName = "Dhiraj Kumar";

            // Using parameterized constructor with different values With initialze the  valriable
            student s4 = new student(rollNo, studentName);
            s4.showData();

            // Using copy constructor
            student s5 = new student(s2);
            s5.showData();
        }
    }

    public class Student
    {
        //object initilize with array
        public static void Main(string[] args)
        {
           student[]s = new student[2];
            for (int i= 0;i<s.Length;  i++)
            {
                s[i] = new student();
            }

            Console.WriteLine("Details of Students:");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Student " + (i + 1) + " details:");
                s[i].showData();
            }

        }
    }
}

