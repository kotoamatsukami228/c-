using System;

namespace DZ_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int a=Convert.ToInt32(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine("да ");        
            }
            else
            {
                Console.WriteLine("нет ");
            }
        }
    }
}
