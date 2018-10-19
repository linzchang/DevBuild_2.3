using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOnListOnList
{
    class Program
    {
        static void Main(string[] args)
        {
            //create list of strings
            List<string> bandList = new List<string> { "Pearl Jam", "The Avett Brothers", "Arcade Fire", "Iron and Wine", "The Beatles", "Bon Iver", "Andrew Bird", "Childish Gambino",
                                                        "Maggie Rogers", "Beebs", "The Shins", "Nirvana", "Trampled by Turtles", "Alabama Shakes",};

            while(true)
            {
                string switchAnswer = GetInput("Would you like to 1) view the list 2) add to the list 3) search the list or 4) sort the list?");
                switch (switchAnswer)
                {
                    //View (print) list
                    case "1":
                        //prints each string in List to console, added 1 to index so it doesn't start at 0
                        for (int i = 0; i < bandList.Count; i++)
                        {
                            Console.WriteLine($"{i+1}. {bandList[i]}");
                        }
                        break;

                    //Add to list
                    case "2":
                        AddToList("What would you like to add to the list?", bandList);
                        Console.WriteLine($"You successfully added {bandList[bandList.Count-1]} to the list.");
                        break;

                    //Search list
                    case "3":
                        SearchList("What would you like to search for?", bandList);
                        break;

                    //Sort list
                    case "4":
                        SortList("The list will be shown in alphabetical order.", bandList);
                        break;

                    default:
                        Console.WriteLine("That is not a valid selection, try again.");
                        continue;
                }

                string endProgram = GetInput("Would you like to continue to the main menu?  Press Y to continue");
                if (endProgram != "Y")
                {
                    break;
                }
            }
        }

        public static string GetInput(string message)
        {
            Console.WriteLine(message);
            string response = Console.ReadLine().ToUpper();
            return response;
        }

        public static void AddToList(string message, List<string> selection)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            while (input == "")
            {
                Console.WriteLine("That is not valid, please try again.");
                input = Console.ReadLine();
                continue;
            }

            selection.Add(input);
        }

        public static void SearchList(string message, List<string> selection)
        {
            bool result;
            Console.WriteLine(message);
            string input = Console.ReadLine();

            result = selection.Contains(input);

            if (result)
            {
                Console.WriteLine($"The list does contain '{input}'.");
            }
            else
            {
                Console.WriteLine($"'{input}' was not found in the list.");
            }
        }

        public static void SortList(string message, List<string> selection)
        {
            selection.Sort();

            for (int i = 0; i < selection.Count; i++)
            {
                Console.WriteLine($"{i}. {selection[i]}");
            }

        }
    }
}
