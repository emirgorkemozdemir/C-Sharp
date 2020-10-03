using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Console_Date_Time_Funcs
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime zaman1 = DateTime.Now;

            DateTime zaman2 = new DateTime(2018,12,25,19,50,50);

            double fark = zaman1.Subtract(zaman2).TotalSeconds;

            Console.WriteLine(zaman1);

            Console.WriteLine(zaman2);

            Console.WriteLine(fark);

            Console.Read();
        }
    }
}
