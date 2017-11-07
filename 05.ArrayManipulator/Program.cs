using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ArrayManipulator
{
    class Program
    {
        //TOOP EXERCISE xD

        public static List<int> list = Console.ReadLine()
            .Split().Select(int.Parse).ToList();
        public static List<int> containList = new List<int>();

        static void Main(string[] args)
        {
            Start:
            List<string> commands = Console.ReadLine().Split().ToList();
            
            switch (commands[0])
            {
                case "add":
                    int index = int.Parse(commands[1]);
                    int number = int.Parse(commands[2]);
                    InsertSomeNumber(index, number);
                    goto Start;

                case "addMany":
                    index = int.Parse(commands[1]);
                    
                    for (int i = 0; i < commands.Count - 2; i++)
                    {
                        number = int.Parse(commands[2 + i]);
                        InsertSomeNumber(index + i,number);
                    }                  
                    goto Start;

                case "contains":
                    number = int.Parse(commands[1]);
                    SearchForSomeNumber(number);
                    goto Start;

                case "remove":
                    index = int.Parse(commands[1]);
                    RemoveNumberFromIndex(index);
                    goto Start;

                case "shift":
                    int shift = int.Parse(commands[1]);
                    MoveElementsOnTheLeft(shift);
                    goto Start;

                case "sumPairs":
                    SumPairsOfTheList();
                    goto Start;
                case "print":
                    PrintTheList();
                    return;

                default:
                    break;
            }
        }

        private static void PrintTheList()
        {
            if (containList.Count != 0)
            {
                Console.WriteLine(String.Join("\n",containList));
            }
            Console.WriteLine("[" + String.Join(", ",list) + "]");
            return;
        }

        private static void SumPairsOfTheList()
        {
            List<int> twinList = new List<int>();
 
                for (int i = 0; i < list.Count; i++)
                {
                    if (i % 2 == 1)
                    {
                        twinList.Add(list[i] + list[i - 1]);
                    }
                }
            if (list.Count % 2 != 0)
            {
                twinList.Add(list[list.Count - 1]);
            }
            list = twinList;
            return;
        }

        private static void MoveElementsOnTheLeft(int shift)
        {
            for (int i = 0; i < shift; i++)
            {
                int firstNumber = list[0];
                for (int j = 0; j < list.Count - 1 ; j++)
                {
                    list[j] = list[j + 1];
                }
                list[list.Count - 1] = firstNumber;
            }
            return;
        }

        private static void RemoveNumberFromIndex(int index)
        {
            list.RemoveAt(index);
            return;
        }

        private static void SearchForSomeNumber(int number)
        {      
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(number))
                {
                    containList.Add(i);
                    return;
                }
            }
            containList.Add(-1);
            return;
        }

        public static void InsertSomeNumber(int index, int number)
        {
            list.Insert(index, number);
            return;
        }
    }
}
