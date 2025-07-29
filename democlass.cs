using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _24SOECE13009_Dhiraj_NB
{
    internal class Time
    {
        int hours;
        int minutes;
        int second;
        public void getdata(int hours, int minutes, int second)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.second = second;
        }

        public void showdata()
        {
            Console.WriteLine("hours:" + hours);
            Console.WriteLine("minutes:" + minutes);
            Console.WriteLine("second:" + second);
            Console.WriteLine("second:" + second + ":" + "minutes" + minutes +":"+ "second" + ":" + second);

        }
    }

    internal class display
    {
        public static void Main(string[] args)
        {
            Time t1= new Time();
            t1.getdata(2,22, 23);
            t1.showdata();
        }

    }


}
