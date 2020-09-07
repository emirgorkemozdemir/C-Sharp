using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Console_Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı;

            sayı = Convert.ToInt32(Console.ReadLine());

            bool durum = sayı%2 != 1;

            Console.Write("Sayı çift mi ?" + durum);

            Console.Read();
        }
    }
}
