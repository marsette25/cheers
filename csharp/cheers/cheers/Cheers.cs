using System;

namespace cheerios
{
	public class Cheering
	{
		public static void Main()
		{
			//declaring methods
			string name; //this will be the user's name
			string letters; //this will be the an loop
			string birthday; //this is the user's birthday

			//user needs to give us the below information
			Console.Write("Enter your name: ");
			name = Console.ReadLine();
			name = name.ToLower();
			Console.Write("Enter your birthday MM/DD: ");
			name = Console.ReadLine();


			//we need to tell the program when to use a or an

			char[] an_characters = new characters[13] { 'a', 'e', 'i', 'o', 'u', 'f', 'h', 'l', 'm', 'n', 'r', 's', 'x' }; 


			//split the birthday up after user enters it
			string [] day = birthday.Split ('/');

			for (int i = 0; i < name.Length; i++)
			{
				// loop over
				letters = Array.IndexOf(an_characters, name[i]) < 0 ? "a" : "an";
				Console.WriteLine("Give me {0}..{1}", letters, name[i]);
			}


			//tell the user the how grand they are
			Console.WriteLine("{0} is.. grand!!!", name);
		
		}

	}
}



