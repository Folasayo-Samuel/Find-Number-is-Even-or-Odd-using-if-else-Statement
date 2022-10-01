using System;

namespace EvenOddNumber
{
	public class Program
	{
		public static void Main(string[]args)
		{
			int n;
			Console.Write("Enter an integer: ");
			n = Int32.Parse(Console.ReadLine());
			
			if(n%2==0)
				Console.WriteLine($"{n} is even");
			else
				Console.WriteLine($"{n} is odd");

            Console.ReadKey();
        }
	}
}