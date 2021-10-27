using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayı_tahmin_oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int tahminedilensayi;
            Random rnd = new Random();
            int rasgelesayi = rnd.Next(0,101);
            Console.WriteLine("Sayıyı girin");

            for (bool haksayisi = false; haksayisi == false;) //bilene kadar devam etmesi için...
            {
                tahminedilensayi = Convert.ToInt32(Console.ReadLine());

                if (tahminedilensayi < rasgelesayi)
                {
                    Console.WriteLine("Daha büyük bir sayı gir");
                }
                else if (tahminedilensayi > rasgelesayi)
                {
                    Console.WriteLine("Daha küçük bir sayı gir");
                }
                else
                {
                    Console.WriteLine("Tebrikler..");
                }   
            }
            Console.ReadKey();
        }
    }
}
