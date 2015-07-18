using NUnit.Framework;
using System;
using cheers;

namespace TestCheers
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TestHowNameSpells ()
		{
			name my_name = new name();  
			Assert.AreEqual ("Bob", my_name.Spelled ()); //We tried assert.equals but this shouldn't be used. throws an error.
		}
			
	}
}

