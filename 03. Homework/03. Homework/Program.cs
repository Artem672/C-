using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            EventService events = new EventService();

            char key;
            do
            {
                Console.Write("Event menu:\n1: Add event\n2: Remove event\n3: Remove all events\n4: Show all events\n5: Search event on special date\n6: Show event between to dates\n7: Show event by client\n8: Exit\n->");
                key = char.Parse(Console.ReadLine());

                switch (key)
                {
                    case '1':
                        Console.Clear();
                        events.AddEvent();
                        Console.Clear();
                        events.Print();
                        break;
                    case '2':
                        Console.Clear();
                        events.RemoveEvent();
                        break;
                    case '3':
                        Console.Clear();
                        events.RemoveAllEvents();
                        break;
                    case '4':
                        Console.Clear();
                        events.Print();
                        break;
                    case '5':
                        {
                            Console.Clear();
                            DateTime date;
                            int month, day;

                            Console.Write("Enter month: ");
                            month = int.Parse(Console.ReadLine());
                            Console.Write("Enter day: ");
                            day = int.Parse(Console.ReadLine());

                            date = new DateTime(2021, month, day);

                            events.Print(date);

                            break;
                        }
                    case '6':
                        {
                            Console.Clear();
                            DateTime date1, date2;
                            int month, day;

                            Console.Write("Enter date 1 month: ");
                            month = int.Parse(Console.ReadLine());
                            Console.Write("Enter date 1 day: ");
                            day = int.Parse(Console.ReadLine());

                            date1 = new DateTime(2021, month, day);

                            Console.Write("Enter date 2 month: ");
                            month = int.Parse(Console.ReadLine());
                            Console.Write("Enter date 2 day: ");
                            day = int.Parse(Console.ReadLine());

                            date2 = new DateTime(2021, month, day);

                            events.Print(date1, date2);

                            break;
                        }
                    case '7':
                        {
                            Console.Clear();
                            string name;

                            Console.Write("Enter client name: ");
                            name = Console.ReadLine();

                            events.Print(name);

                            break;
                        }
                    default:
                        break;
                }

                Console.ReadKey();
                Console.Clear();

            } while (key != '8');


        }
    }
}
