using System;

namespace Dz_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a: ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число с: ");
            int c=Convert.ToInt32(Console.ReadLine());
            int max=a;

            if(b>max)
            {
                max=b;
            }
            if(c>max)
            {
                max=c;
            }
            Console.WriteLine("максимальное число: "+max);
            
        }
    }
}
