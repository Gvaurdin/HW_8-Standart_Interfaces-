using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW_8_Standart_Interfaces_
{
    internal class Sources
    {
        public static string GetLine()
        {
            string line = "";
            for (int i = 0; i < 75; i++)
            {
                if (i == 0) line += "\n";
                else if (i == 74) line += "\n";
                else line += "=";
            }
            return line;
        }
        public static void Menu()
        {
            Auditory auditory = new Auditory();
            List<string> MenuItems = new List<string>
            {
                "Sorting students in the classroom by first name",
                "Sorting students in the classroom by last name",
                "Sorting students in the classroom by birthday",
                "Sorting students in the classroom by student card`s number",
                "Sorting students in the classroom by student card`s series and number",
                "Exit"
            };
            int selected_item_index = 0;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("\tManager sorting\n" +
                    "Select action :");
                for (int i = 0; i < MenuItems.Count; i++)
                {
                    if (i == selected_item_index)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine(MenuItems[i]);
                }
                Console.BackgroundColor = ConsoleColor.Black;

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (selected_item_index > 0)
                        {
                            selected_item_index--;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (selected_item_index < MenuItems.Count - 1)
                        {
                            selected_item_index++;
                        }
                        break;

                    case ConsoleKey.Enter:
                        if (selected_item_index == MenuItems.Count - 1)
                        {
                            return;
                        }
                        else
                        {
                            switch (selected_item_index)
                            {
                                case 0:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\t\tList students before\n");
                                        foreach (Student item in auditory)
                                        {
                                            Console.WriteLine(item + GetLine());
                                        }
                                        auditory.Sort();
                                        Console.WriteLine("\t\tList students after\n");
                                        foreach (Student item in auditory)
                                        {
                                            Console.WriteLine(item + GetLine());
                                        }
                                        Console.ReadKey();
                                    }
                                    break;
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\t\tList students before\n");
                                        foreach (Student item in auditory)
                                        {
                                            Console.WriteLine(item + GetLine());
                                        }
                                        auditory.Sort(new Last_NameComparer());
                                        Console.WriteLine("\t\tList students after\n");
                                        foreach (Student item in auditory)
                                        {
                                            Console.WriteLine(item + GetLine());
                                        }
                                        Console.ReadKey();
                                    }
                                    break;
                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\t\tList students before\n");
                                        foreach (Student item in auditory)
                                        {
                                            Console.WriteLine(item + GetLine());
                                        }
                                        auditory.Sort(new DateComparer());
                                        Console.WriteLine("\t\tList students after\n");
                                        foreach (Student item in auditory)
                                        {
                                            Console.WriteLine(item + GetLine());
                                        }
                                        Console.ReadKey();
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\t\tList students before\n");
                                        foreach (Student item in auditory)
                                        {
                                            Console.WriteLine(item + GetLine());
                                        }
                                        auditory.Sort(new Student_CardComparer_Number());
                                        Console.WriteLine("\t\tList students after\n");
                                        foreach (Student item in auditory)
                                        {
                                            Console.WriteLine(item + GetLine());
                                        }
                                        Console.ReadKey();
                                    }
                                    break;
                                case 4:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\t\tList students before\n");
                                        foreach (Student item in auditory)
                                        {
                                            Console.WriteLine(item + GetLine());
                                        }
                                        auditory.Sort(new Student_CardComparer_SeriesAndNumber());
                                        Console.WriteLine("\t\tList students after\n");
                                        foreach (Student item in auditory)
                                        {
                                            Console.WriteLine(item + GetLine());
                                        }
                                        Console.ReadKey();
                                    }
                                    break;
                            }
                        }
                        break;
                }
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}
