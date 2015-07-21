using System;
using System.Collections.Generic;
using System.Linq;

namespace cheers2
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			string name; //this will be the user's name
			string an_characters =	"halfnorsemix"; //we need to tell the program when to use a or an

			//user needs to give us the below information
			Console.Write("Enter your name: ");
			name = Console.ReadLine();
			name = name.ToLower();


			//by using foreach, we do not have to write a loop. which is so nice. this says, for each letter in name, do the below. i like foreach better than for loops
			foreach (var letter in name)
			{	
				//use a ternary to decrease code. this says, are any of the letters in "half norsemix"? if not, use a. if they are use "an"
				var article = an_characters.IndexOf(letter) == -1 ? "a" : "an";
				Console.WriteLine("Give me {0}..{1}", article, letter);

			}

			//tell the user the how grand they are
			Console.WriteLine("{0} is.. grand!!!", name);

			//get the user's birthday 
			Console.Write("Enter your birthday MM/DD: ");
			string birthday = Console.ReadLine ();

			//parse the birthdate
			DateTime startDate = DateTime.Parse (birthday);
//			Console.WriteLine (startDate);

			//get the day's date
			DateTime now = DateTime.Now;

		
			//this is suppsed to give me days until but it is giving me days ago.
			TimeSpan elapsed = startDate.Subtract (now);
//				Console.Write (elapsed);

		

			var daysFromNow = elapsed.TotalDays;

			TimeSpan span1 = TimeSpan.FromDays (365);
			TimeSpan span2 = span1.Add(elapsed);
//				Console.Write (span2);

			Console.WriteLine ("{0} is {1} days from now", startDate, span2.ToString ());


//			Console.WriteLine ("Please enter" + " a positive integer: ");
//			int upperLimit = int.Parse(Console.ReadLine ());
//			List<int> evenintegers = new List<int>();
//
//			for (var i = 1; i < upperLimit; i++) 
//			{
//				if (i % 2 == 0) {
//				}
//				evenintegers.Add(i);
//				Console.WriteLine (i);
//				}

		}
		
	}
}
