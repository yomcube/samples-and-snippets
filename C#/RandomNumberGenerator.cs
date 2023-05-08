using System;
namespace SamplesAndSnippets {
	class RandomNumberGenerator {
		public static void Main() {
			Random rand = new Random();
			Console.WriteLine("Random number 0-4");
			Console.WriteLine(rand.Next(5));
			Console.WriteLine("Random number 8-16");
			Console.WriteLine(rand.Next(8, 17));
		}
	}
}