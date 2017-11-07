using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = new string[3];
            int firstNumber = 0;
            int secondNumber = 0;
            

            while (true)
            {
                command = Console.ReadLine().Split().ToArray();
                if (command[0] == "Odd" || command[0] == "Even")
                {
                    break;
                }
                if (command.Count() == 2)
                {
                    firstNumber = int.Parse(command[1]);
                }
                if (command.Count() == 3)
                {
                    firstNumber = int.Parse(command[1]);
                    secondNumber = int.Parse(command[2]);
                }
                
                switch (command[0])
                {
                    case "Delete":

                        for (int i = 0; i < list.Count; i++)
                        {
                         if (list[i] == firstNumber)
                           {                              
                                list.Remove(firstNumber);
                                i--;
                           }
                        }
                           
                        
                        break;
                    case "Insert":
                        list.Insert(secondNumber, firstNumber);
                        break;
                    default:
                        break;
                }
            }
            if (command[0] == "Odd")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0)
                    {
                        list.RemoveAt(i);
                        i--;
                    }
                }
                Console.WriteLine(String.Join(" ", list));
            }
            else if(command[0] == "Even")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 != 0)
                    {
                        list.RemoveAt(i);
                        i--;
                    }
                }
                Console.WriteLine(String.Join(" ", list));
            }
        }
    }
}
