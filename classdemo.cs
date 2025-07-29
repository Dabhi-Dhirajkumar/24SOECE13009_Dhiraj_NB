using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_Dhiraj_NB
{
    internal class Emplyee
    {
        int age;
        string name;
        int salary;
        int id;
        public void getdata(int age,string name,int salary,int  id)
        {

            //id = 22;
            //salary = 10;
            //name = "dhiraj";
            //age = 10;

            this.age = age;
            this.name = name;
            this.salary = salary;
            this.id = id;
        }

        public void showdata()
        {
            Console.WriteLine("age:" + age);
            Console.WriteLine("enmae:" + name);
            Console.WriteLine("salary:" + salary);
            Console.WriteLine("EMPid:" + id);
        }

    }

    internal class ClassDemo1
    {
        public static void Main(string[] args)
        {
            Emplyee e1 = new Emplyee();
            e1.getdata(2,22,"dddd",23);
            e1.showdata();

            Emplyee e2 = new Emplyee();
            e1.getdata();
            e1.showdata();



        }

    }
}

