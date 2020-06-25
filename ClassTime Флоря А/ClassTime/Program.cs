using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTime
{
    class Myclass
    {
        static void Main(string[] args)
        {

            Time x = new Time(14, 20, 01),
                y = new Time(22, 03, 42);
            Console.WriteLine("x = {0}", x.ToString());
            Console.WriteLine("y = {0}\n", y.ToString());
            Console.WriteLine($"Время x в часах = {x.ToHour()}");
            Console.WriteLine($"Время x в минутах = {x.ToMinute()}");
            Console.WriteLine($"Время x в секундах = {x.ToSecond()}");
            Console.WriteLine("x + y = {0}", (x + y).ToString());
            Console.WriteLine("x - y = {0}\n", (x - y).ToString());
            x.Add_Hour(7);
            Console.WriteLine("x + 7 hours = {0}", x.ToString());
            x.Add_Minute(83);
            Console.WriteLine("x + 83 minutes = {0}", x.ToString());
            x.Add_Second(41);
            Console.WriteLine("x + 41 seconds = {0}\n", x.ToString());
            x.Sub_Hour(20);
            Console.WriteLine("x - 20 hours = {0}", x.ToString());
            x.Sub_Minute(53);
            Console.WriteLine("x - 53 minutes = {0}", x.ToString());
            x.Sub_Second(39);
            Console.WriteLine("x - 39 seconds = {0}", x.ToString());
            Console.ReadKey();
        }
    }
}