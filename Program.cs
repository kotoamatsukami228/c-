using System;

namespace Dz_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N: ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Четные число от 1 до "+n+": ");
            int i=2;
        
            while(i<=n)
            {
                Console.WriteLine(i+ " ");
                i+=2;
            }

        }
    }
}
