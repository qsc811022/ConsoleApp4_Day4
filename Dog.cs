using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
	public class Dog:Animal
	{
		public override void MakeSound()
		{
			Console.WriteLine("Woof!");
		}
	}
	public class Cat : Animal
	{
		public override void MakeSound()
		{
			Console.WriteLine("Meow!");
		}
	}

	public class Bird : Animal
	{
		public override void MakeSound()
		{
			Console.WriteLine("Tweet!");
		}
	}


	public class Animal
	{
		public virtual void MakeSound()
		{
			Console.WriteLine("The animal makes a sound.");
		}
	}
}
