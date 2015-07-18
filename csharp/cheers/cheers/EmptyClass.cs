using System;

namespace ExploringTDD
{
	public interface IDog
	{
		//these are method signatures. 
		string Bark ();
		string Whine ();
		string Scratch ();
	}

	public class Yorkie : IDog // i lets us know it's an interface
	{
		//instance methods
		public virtual string Bark ()
		{
			return "Yip";
		}	

		public virtual string Whine ()
		{
			return "Loud";
		}	

		public virtual string Scratch ()
		{
			return "Lightly";
		}	
	}

}