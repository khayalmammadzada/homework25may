using System;

namespace integerindex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers={ 3, 7, 8, 11, 17, 22, 30 };
            int num = 11;
            var index = -1;
            for(int i=0; i<numbers.Length; i++)
            {
                if (numbers[i]== num)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}
