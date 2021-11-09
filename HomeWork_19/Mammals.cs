using System;

namespace HomeWork_19
{
    class Mammals : IAnimal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Say() => "i am Mammals";

        public Mammals(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
