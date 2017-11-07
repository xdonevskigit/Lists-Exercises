using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            list.Add(0);

            int count = 1;
            int bestCount = 1;
            int theMostCommonElement = list[0];
            if (list.Count == 1)
            {
                Console.WriteLine(list[0]);
                return;
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        theMostCommonElement = list[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }
            list.RemoveRange(0, list.Count);

            for (int i = 0; i < bestCount; i++)
            {
                list.Add(theMostCommonElement);
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
