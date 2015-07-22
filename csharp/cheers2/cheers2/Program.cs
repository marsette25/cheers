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

			//get the user's birthday 
			Console.Write("Enter your birthday MM/DD: ");
			string birthday = Console.ReadLine ();

			//by using foreach, we do not have to write a loop. which is so nice. this says, for each letter in name, do the below. i like foreach better than for loops
			foreach (var letter in name)
			{	
				//use a ternary to decrease code. this says, are any of the letters in "half norsemix"? if not, use a. if they are use "an"
				var article = an_characters.IndexOf(letter) == -1 ? "a" : "an";
				Console.WriteLine("Give me {0}..{1}", article, letter);

			}

			//tell the user the how grand they are
			Console.WriteLine("{0} is.. grand!!!", name);

			//get birthday dates parsed 
			TimeSpan conversion = DateTime.Now.Subtract(DateTime.Parse(birthday));
			double daysFromNow = conversion.TotalDays;


			int difference = 0; 

			//tell the user happy birthday or how many days away their birthday is
			DateTime lastDay = new DateTime(2015,12,31);
			if (DateTime.Today < DateTime.Parse(birthday)) {
				difference = DateTime.Parse(birthday).DayOfYear - DateTime.Today.DayOfYear;

			} else {
				difference = lastDay.DayOfYear - DateTime.Today.DayOfYear + DateTime.Parse(birthday).DayOfYear;
			}

			Console.WriteLine("Your birthday is in {0} days ", difference);


			// this is an integer app
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
