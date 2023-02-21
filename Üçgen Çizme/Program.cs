using System;

namespace Üçgen_Çizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgen Kenar Uzunluğunu Giyiniz: ");
            int kenaruzunlugu=int.Parse(Console.ReadLine());

            for(int i= 1;i <= kenaruzunlugu;i++)
            {
                 for (int j = 1; j <= kenaruzunlugu - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
             Console.ReadKey();
        }
    }
}
