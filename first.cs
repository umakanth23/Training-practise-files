using System;
class first
{
	static void Main()
	{
		Console.WriteLine("Please enter your name : ");
		string name = Console.ReadLine();
		Console.WriteLine("Hello " + name);
		string wish = "GoodMoring";
		Console.WriteLine("Hey {0} {1}",name,wish); 
	}
}