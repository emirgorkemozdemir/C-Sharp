using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Console_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı1;

            Console.Write("Birinci sayıyı giriniz:");

            sayı1 =Convert.ToInt32(Console.ReadLine());

            int sayı2;

            Console.Write("İkinci sayıyı giriniz:");

            sayı2 = Convert.ToInt32(Console.ReadLine());

            int toplam;
            toplam = sayı1 + sayı2;

            int çarpım;
            çarpım = sayı1 * sayı2;

            int fark;
            fark = sayı1 - sayı2;

            int bölüm;
            bölüm = sayı1 / sayı2;

            Console.Write("Toplam:{0} Çarpım:{1} Fark{2} Bölüm {3}", toplam, çarpım, fark, bölüm);

            Console.Read();
        }
    }
}
