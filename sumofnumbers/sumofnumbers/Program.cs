using System;

namespace sumofnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            int remainder;

                Console.WriteLine("Ededi daxil edin");
            num = Convert.ToInt32(Console.ReadLine());
            while(num!=0)
            {
                remainder = num % 10;
                num = num / 10;
                sum += remainder;
            }
            Console.WriteLine("Ededin reqemlerinin cemi:" + sum);
            Console.ReadLine();
        }
    }
}
