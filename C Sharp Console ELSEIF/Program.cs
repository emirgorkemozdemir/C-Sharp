using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Console_ELSEIF
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı;

            sayı = Convert.ToInt32(Console.ReadLine());

            if (sayı>0)
            {
                Console.WriteLine("Sayı pozitif");
            }
            else if (sayı==0)
            {
                Console.WriteLine("Sayı 0");
            }
            else
            {
                Console.WriteLine("Sayı negatif");
            }

            Console.Read();
        }
    }
}
