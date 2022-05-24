using System;

namespace biggestofthree
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            Console.WriteLine("Birinci ededi daxil edin:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ucuncu ededi daxil edin:");
            num3 = Convert.ToInt32(Console.ReadLine());

                if(num1>num2)
            {
                if(num1>num3)
                {
                    Console.WriteLine("birinci ci eded en boyukdur");
                }
                else
                {
                    Console.WriteLine("Ucuncu eded en boyukdur");
                }
            }
                else if(num2>num3)
                Console.WriteLine("Ikicni eded en boyukdur");
                else
                Console.WriteLine("Ucuncu eded en boyukdur");
        }
    }
}
