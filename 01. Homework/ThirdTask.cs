using System;

namespace FirstTask
{
    class FirstTask
    {
        static void Main(string[] args)
        {
			Console.Write("Enter first number -> ");
			double FirstN = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter second number -> ");
			double SecondN = Convert.ToDouble(Console.ReadLine());
			string Result = CalculatorMenu(FirstN,SecondN);
			Console.Clear();
			Console.WriteLine($"Result: {Result}");
			
			Console.ReadKey();
        }
		
		static string CalculatorMenu(double FirstN, double SecondN)
		{			
				Console.Clear();
				Console.WriteLine("\t Menu");
				Console.WriteLine("Enter 0 to exit");
				Console.WriteLine("Enter 1 to add ");
				Console.WriteLine("Enter 2 to subtract");
				Console.WriteLine("Enter 3 to multiply");
				Console.WriteLine("Enter 4 to divide");
				Console.Write("Your choice -> ");
				string Choice = Console.ReadLine();
				
				switch (Choice)
				{
					case "0":
					{
						Console.Clear();
						Console.WriteLine("Goodbye!");
						Console.ReadKey();
						return "Exit";
					}
					case "1":
					{
						Console.Clear();
						double Sum = FirstN + SecondN;
						return Sum.ToString("F6");
					}
					case "2":
					{
						double Minus = FirstN - SecondN;
						return Minus.ToString("F6");
					}
					case "3":
					{
						double Multiply = FirstN * SecondN;
						return Multiply.ToString("F6");
					}
					case "4":
					{
						double Divide = FirstN / SecondN;
						if(SecondN != 0)
						{
							return 	Divide.ToString("F6");	
						}
						else
						{
							return "Can't divide 0";
						}
								
					}
					default:
					{
						Console.Clear();
						return "Invalid code!";
					}		
				}
		}
    }
}