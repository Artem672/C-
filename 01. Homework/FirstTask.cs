using System;

namespace FirstTask
{
    class FirstTask
    {
        static void Main(string[] args)
        {
			bool Menu = true;
				
			while(Menu)
			{
				Console.Clear();
				Console.WriteLine("\t Menu");
				Console.WriteLine("Enter 0 to exit");
				Console.WriteLine("Enter 1 to convert Celsium to Farengeit");
				Console.WriteLine("Enter 2 to convert Farengeit to Celsium");
				Console.Write("Your choice -> ");
				string Choice = Console.ReadLine();
				
				switch (Choice)
				{
					case "0":
					{
						Console.Clear();
						Console.WriteLine("Goodbye!");
						Menu = false;
						Console.ReadKey();
						break;
					}
					case "1":
					{
						Console.Clear();
						Console.Write("Enter Celsium -> ");
						double Celsium = Convert.ToDouble(Console.ReadLine());
						double Farengeit = (Celsium * 1.8) + 32;
						Console.WriteLine($"{Celsium} TC in TF is {Farengeit} TF");
						Console.ReadKey();
						break;
					}
					case "2":
					{
						Console.Clear();
						Console.Write("Enter Farengeit -> ");
						double Farengeit = Convert.ToDouble(Console.ReadLine());
						double Celsium = (Farengeit - 32) / 1.8;
						Console.WriteLine($"{Farengeit} TF in TC is {Celsium}");
						Console.ReadKey();
						break;
					}
					default:
					{
						Console.Clear();
						Console.WriteLine("Invalid code!");
						Console.ReadKey();
						break;
					}
				}
				
			}
			
        }
    }
}