using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Console_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal euro = 8.7642m;

            decimal dolar = 7.3827m;

            int dolaradet;

            int euroadet;

            Console.Write("Hesaplamak istediğiniz dolar miktarını giriniz:");

            dolaradet = Convert.ToInt32( Console.ReadLine() );

            Console.Write("Hesaplamak istediğiniz euro miktarını giriniz:");

            euroadet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Doların Türk Lirası değeri :" + dolar * dolaradet);

            Console.WriteLine("Euro Türk Lirası değeri :" + euro * euroadet);

            Console.Read();

        }
    }
}
