using System;

namespace Exercise5
{
    class Program
    {
        public class Animals
        {
            public int Age;
            public string Name { get; protected set; }
            public string Gender;

            public Animals()
            {
                Age = 0;
                Name = "No name";
                Gender = "Unknown gender";
            }
               

            public Animals(int Age, string Name, string Gender)
            {
                this.Age = Age;
                this.Name = Name;
                this.Gender = Gender;
            }

            public virtual string Voice()
            {
                return "No sound";
            }
        }
        public class Dog : Animals
        {
            public Dog(int Age, string Name, string Gender) : base(Age, Name, Gender)
            {
            }
            public override string Voice()
            {
                return "Woof";
            }
        }

        public class Cat : Animals
        {
            public Cat(int Age, string Name, string Gender) : base(Age, Name, Gender)
            {
            }

            public override string Voice()
            {
                return "Meow";
            }
        }

        public class Lion : Animals
        {
            public Lion(int Age, string Name, string Gender) : base(Age, Name, Gender)
            {
            }

            public override string Voice()
            {
                return "Roar";
            }
        }

        static void Main(string[] args)
        {
            Animals[] AnimalArray = new Animals[]
                {
                    new Dog(12, "Jack", "Male"),
                    new Cat(5, "Bobo", "Male"),
                    new Lion(18, "Lisa", "Female"),
                    new Animals()
                };

            for (int i = 0; i<AnimalArray.Length; i++)
            {
                Console.WriteLine(AnimalArray[i].Name + " says \"" + AnimalArray[i].Voice() + "\" .It is " + AnimalArray[i].Age + " years old and it is " + AnimalArray[i].Gender+".");
            }
            Console.ReadKey();
        }
    }
}
