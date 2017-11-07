using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] threeCommands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int min = Math.Min(inputList.Count, threeCommands[1]);

            for (int i = 0; i < inputList.Count; i++)
            {
                if (i == threeCommands[0])
                {
                    inputList.RemoveAt(i);                   
                }
                if (inputList.Count == 0)
                {
                    goto END;
                }
            }
            for (int i = 0; i < min; i++)
            {
                if (inputList.Count == 0)
                {
                    goto END;
                }
                inputList.RemoveAt(0);
            }
            for (int i = 0; i < inputList.Count; i++)
            {
                if (threeCommands[2] == inputList[i])
                {
                    Console.WriteLine("YES!");
                    return;
                }          
            }
            END:
            Console.WriteLine("NO!");
        }
    }
}
