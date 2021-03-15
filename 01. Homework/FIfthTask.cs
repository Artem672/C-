using System;

namespace FifthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter password -> ");
            int Password = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Confirm password -> ");
            int ConfirmPassword = int.Parse(Console.ReadLine());
            if(ConfirmPassword == Password)
            {
                double Balance = 0;
                bool Menu = true;
                while(Menu)
                {
                    Console.Clear();
                    Console.WriteLine("0. Exit");
                    Console.WriteLine("1. Add money");
                    Console.WriteLine("2. Withdraw money");
                    Console.WriteLine("3. Check balance");
                    Console.Write("Your choice -> ");
                    string Choice = Console.ReadLine();

                    switch(Choice)
                    {
                        case "0":
                            {
                                Menu = false;
                                Console.WriteLine("Goodbye");
                                break;
                            }
                        case "1":
                            {
                                Console.Clear();
                                Console.WriteLine("Enter cash to add -> ");
                                double Cash = Convert.ToDouble(Console.ReadLine());
                                if(Cash >= 0)
                                {
                                    Console.Clear();
                                    Balance += Cash;
                                    Console.WriteLine($"Cash: {Cash} was added");
                                }
                                else 
                                {
                                    Console.Clear();
                                    Console.WriteLine("Invalid code!");
                                }
                                Console.ReadKey();
                                break;
                            }
                        case "2":
                            {
                                Console.Clear();
                                Console.WriteLine("Enter cash to withdraw-> ");
                                double Cash = Convert.ToDouble(Console.ReadLine());
                                if(Cash <= Balance)
                                {
                                    Balance -= Cash;
                                    Console.WriteLine($"You succesfully withdraw {Cash}$");
                                }
                                else 
                                {
                                    Console.Clear();
                                    Console.WriteLine("Not enough money!");
                                }
                                Console.ReadKey();
                                break;
                            }
                        case "3":
                            {
                                Console.Clear();
                                Console.WriteLine($"Balance: {Balance}");
                                Console.ReadKey();
                                break;
                            }
                    }                  
                }
                Console.ReadKey();
            }
            Console.WriteLine($"Password: {Password}");
        }
    }
}
