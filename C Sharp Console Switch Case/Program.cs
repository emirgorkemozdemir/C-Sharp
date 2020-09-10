using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Console_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            sayı = Convert.ToInt32(Console.ReadLine());

            switch (sayı)
            {
                case 1:Console.WriteLine("Ocak Ayı");
                    break;

                case 2:
                    Console.WriteLine("Şubat Ayı");
                    break;

                case 3:
                    Console.WriteLine("Mart Ayı");
                    break;

                case 4:
                    Console.WriteLine("Nisan Ayı");
                    break;


                case 5:
                    Console.WriteLine("Mayıs Ayı");
                    break;

                case 6:
                    Console.WriteLine("Haziran Ayı");
                    break;

                case 7:
                    Console.WriteLine("Temmuz Ayı");
                    break;

                case 8:
                    Console.WriteLine("Ağustos Ayı");
                    break;

                case 9:
                    Console.WriteLine("Eylül Ayı");
                    break;

                case 10:
                    Console.WriteLine("Ekim Ayı");
                    break;

                case 11:
                    Console.WriteLine("Kasım Ayı");
                    break;

                case 12:
                    Console.WriteLine("Aralık Ayı");
                    break;

                default:Console.WriteLine("Hatalı sayı girdiniz");
                    break;
            }

            Console.Read();
        }
    }
}
