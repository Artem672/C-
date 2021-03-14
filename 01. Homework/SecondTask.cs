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
				Console.WriteLine("Enter 1 to convert centimeter to inch");
				Console.WriteLine("Enter 2 to convert inch to centimeter");
				Console.Write("Your choice -> ");
				string Choice = Console.ReadLine();
				const double ConvertInch = 2.54;
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
						Console.Write("Enter centimeter -> ");
						double Centimeter = Convert.ToDouble(Console.ReadLine());
						double Inch = Centimeter * ConvertInch;
						Console.WriteLine($"{Centimeter} centimeter = {Inch} inch");
						Console.ReadKey();
						break;
					}
					case "2":
					{
						Console.Clear();
						Console.Write("Enter inch -> ");
						double Inch = Convert.ToDouble(Console.ReadLine());
						double Centimeter = Inch / ConvertInch;
						Console.WriteLine($"{Inch} inch = {Centimeter} centimeter");
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