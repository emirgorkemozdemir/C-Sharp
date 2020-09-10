using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Console_Else_if2
{
    class Program
    {
        static void Main(string[] args)
        {
            int günsayısı;

            Console.Write("Adını öğrenmek istediğiniz günün sayısını giriniz:");

            günsayısı = Convert.ToInt32(Console.ReadLine());

            if (günsayısı==1)
            {
                Console.Write("Gün Pazartesi");
            }
            else if (günsayısı==2)
            {
                Console.Write("Gün Salı");
            }
            else if (günsayısı == 3)
            {
                Console.Write("Gün Çarşamba");
            }
            else if (günsayısı == 4)
            {
                Console.Write("Gün Perşembe");
            }
            else if (günsayısı == 5)
            {
                Console.Write("Gün Cuma");
            }
            else if (günsayısı == 6)
            {
                Console.Write("Gün Cumartesi");
            }
            else if (günsayısı == 7)
            {
                Console.Write("Gün Pazar");
            }
            else
            {
                Console.Write("7 den büyük sayı girdiniz !");
            }

            Console.Read();
        }
    }
}
