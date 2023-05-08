using System;
namespace SamplesAndSnippets {
	class ReadTextFile {
		public static void Main() {
			string contents = System.IO.File.ReadAllText("../assets/text.txt");
			Console.WriteLine(contents);
		}
	}
}
