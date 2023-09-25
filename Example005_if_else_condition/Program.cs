using System;

namespace Example005_if_else_condition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя пользователя: ");
            string username=Console.ReadLine();

            if(username.ToLower()=="маша")
            {
                Console.WriteLine("ЁМАЕ, этоже, МаХА");
            }
            else
            {
                Console.Write("ООО БЛЯЯ, А МЫ И НЕ ДУМАЛИ ");
                Console.WriteLine(username);
            }
        }
    }
}
