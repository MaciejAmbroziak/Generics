using System;
using System.Runtime.CompilerServices;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            string todo = "-1";
            RecentlyUsedList<Project> myList = new RecentlyUsedList<Project>();
            while (todo != "0") 
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("0 - exit program");
                Console.WriteLine("1 - add new project");
                Console.WriteLine("2 - open project");
                todo = Console.ReadLine();
                switch (todo)
                {
                    case "0":
                        {
                            return;
                        }
                    case "1":
                        {
                            string temp;
                            Console.WriteLine("Give me name for new project:");
                            temp = Console.ReadLine();
                            Console.WriteLine("_________________________________________________");
                            myList.Insert(new Project(temp));
                            myList.PrintList();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Which one?");
                            string  line = Console.ReadLine();
                            Project project = myList.Pick(line);
                            myList.Open(project);
                            myList.PrintList();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Podaj prawidłową komendę");
                            Console.ReadLine();
                            break;
                        }
                        

                        
                todo = Console.ReadLine();
            }
                
            }
        }
    }
}
