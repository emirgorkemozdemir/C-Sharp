using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Console_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for (int i = 1;   i <= 100;    i++) 
            {
                toplam += i;
            }

            Console.WriteLine(toplam);
            Console.Read();
        }
    }
}
