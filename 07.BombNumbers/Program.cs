using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] commArray = new int[2];
            commArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = commArray[0];

            for (int j = 0; j < list.Count; j++)
            {         
                for (int i = 0; i < list.Count; i++)
                {
                    int rightRange = commArray[1];
                    int leftRange = commArray[1];
                    if (list[i] == bomb)
                    {
                        if (i - leftRange < 0)
                        {                           
                            leftRange = 0;
                        }
                        else
                        {
                            leftRange = i - leftRange;
                        }

                        if (i + rightRange > list.Count - 1)
                        {
                            rightRange = list.Count - 1 - i;
                            rightRange = rightRange + i + 1;
                        }
                        else
                        {                            
                            rightRange = i - leftRange + rightRange + 1;
                        }
                                                                      
                        list.RemoveRange(leftRange, rightRange);
                        i = 0;
                    }
                    else if (i == list.Count - 1)
                    {
                        goto END;
                    }
                }
            }
            END:
            int result = list.Sum();
            Console.WriteLine(result);
        }
    }
}
