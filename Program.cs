using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
	class Program
	{
		static void Main(string[] args)
		{
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();

            myAnimal.MakeSound();  // 輸出: "The animal makes a sound."
            myDog.MakeSound();     // 輸出: "Woof!"

            // 使用多型
            Animal anotherDog = new Dog();
            anotherDog.MakeSound();  // 輸出: "Woof!"


            Zoo myZoo = new Zoo();

            myZoo.AddAnimal(new Dog());
            myZoo.AddAnimal(new Cat());
            myZoo.AddAnimal(new Bird());

            // 由於使用了多型，即使我們不知道具體是哪種動物，也能正確地呼叫每種動物的MakeSound方法
            myZoo.MakeAllAnimalsSound();

        }
	}
}
