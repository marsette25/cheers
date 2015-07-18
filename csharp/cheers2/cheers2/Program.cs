using System;

namespace cheers2
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			string name; //this will be the user's name
			string an_characters =	"halfnorsemix"; //we need to tell the program when to use a or an
			string birthday; //this is the user's birthday

			//user needs to give us the below information
			Console.Write("Enter your name: ");
			name = Console.ReadLine();
			name = name.ToLower();
			Console.Write("Enter your birthday MM/DD: ");
			birthday = Console.ReadLine();


			//split the birthday up after user enters it
			string [] day = birthday.Split ('/');


			foreach (var letter in name)
			{	
				var article = an_characters.IndexOf(letter) == -1 ? "a" : "an";
				Console.WriteLine("Give me {0}..{1}", article, letter);
			}



			//tell the user the how grand they are
			Console.WriteLine("{0} is.. grand!!!", name);
		}
	}
}
