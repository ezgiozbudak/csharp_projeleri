using System;

namespace proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            // hangi sayıdan kaç adet olduğunu yazan uygulama


            int[] dizi = new int[50];
            int count = 0;
            for (int i = 0; i < 50; i++)
            {
                Random rdn = new Random();
                int sayi = rdn.Next(1, 11);
                dizi[i] = sayi;

            }


            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < dizi.Length; k++)
                {
                    if (dizi[k] == i)
                    {
                        count++;
                    }
                }

                Console.Write("{0} sayısından {1} adet var", i, count);
                for (int z = 0; z < count; z++)
                {
                    Console.Write(" *");
                }
                Console.Write("\n");
                count = 0;

            }
        }
    }
}
