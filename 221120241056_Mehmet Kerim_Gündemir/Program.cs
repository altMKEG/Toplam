using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221120241056_Mehmet_Kerim_Gündemir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = int.Parse(Console.ReadLine());


            int toplam = 0;

            for (int i = 1; i <= sayi1; i++)
            {
                toplam += i;

            }
            Console.WriteLine(toplam);

            Console.Read();
        }
    }
}
