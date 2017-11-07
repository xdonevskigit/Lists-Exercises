using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                int reversedNumber = 0;
                while (list[i] > 0)
                {
                    int temp = list[i] % 10;
                    reversedNumber = (reversedNumber * 10) + temp;
                    list[i] = list[i] / 10;
                }
                sum = sum + reversedNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
