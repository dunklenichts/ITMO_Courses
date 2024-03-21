using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine(Name);
            Say();
        }
    }

    class Cat : Animal
    {
        int isBreed;
        string name;
        public override string Name { get => name; set => name = value; }

        public Cat(string name, int isBreed)
            :base(name)
        {
            this.isBreed = isBreed;
        }

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }

    class Dog : Animal
    {
        // живет дома или на улице
        string living;
        string name;
        public override string Name { get => name; set => name = value; }

        public Dog(string name, string living)
            : base(name)
        {
            this.living = living;
        }

        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
