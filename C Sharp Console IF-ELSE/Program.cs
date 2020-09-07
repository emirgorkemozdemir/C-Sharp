using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Console_IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;

            Console.Write("Şifrenizi giriniz:");
            password = Console.ReadLine();

            if (password == "emir123")
            {
                Console.Write("Şifre doğru");
            }
            else
            {
                Console.Write("Şifre yanlış");
            }

            Console.Read();
        }
    }
}
