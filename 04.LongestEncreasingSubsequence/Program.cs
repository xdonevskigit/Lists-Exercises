using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LongestEncreasingSubsequence
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var result = WriteLongestIncreasingSubsequence(input);
            
            Console.WriteLine(string.Join(" ", result));
        }

        public static int[] WriteLongestIncreasingSubsequence(int[] input)
        {
            int[] length = new int[input.Length];
            int[] prev = new int[input.Length];
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < input.Length; i++)
            {
                length[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (input[j] < input[i] && length[j] >= length[i])
                    {
                        prev[i] = j;
                        length[i] = length[j] + 1;              
                    }
                }

                if (length[i] > maxLength)
                {
                    lastIndex = i;
                    maxLength = length[i];
                    
                }
            }

            var longestList = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                longestList.Add(input[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            longestList.Reverse();
            return longestList.ToArray();
        }
    }
}