using System;

namespace FizzBuzz
{
	class Program
	{
		public static void Main(string[] args)
		{
			for(int x = 0;x < 100;x++) {
				
				if(x % 5 != 0 && x % 3 != 0) {
					Console.WriteLine(x);
				}
				
				if(x % 5 == 0 && x != 0) {
					Console.WriteLine("Buzz");	
				}
				
				if(x % 3 == 0 && x != 0) {
					Console.WriteLine("Fizz");	
				}
		
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}