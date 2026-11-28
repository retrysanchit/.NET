using System;

class Program {
	static void Main(string[] args){
		// Console.WriteLine("Hi Sanchit");
		Console.WriteLine(args[0] + " " + args[1]+ " Length: " + args.Length);

		foreach(string arg in args) {
			Console.WriteLine(arg);
		}
	}
}
