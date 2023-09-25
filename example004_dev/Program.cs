using System;

namespace example004_dev
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberA=new Random().Next(1,10);// 1234...9
            Console.WriteLine(numberA);            
            double numberB=new Random().Next(1,10);
            Console.WriteLine(numberB);
            Console.WriteLine(numberA/numberB);

        }
    }
}
