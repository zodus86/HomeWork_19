using System;

namespace HomeWork_19
{
    class Amphibians : IAnimal
    {
        public int Power { get; set; }
        public string Name { get; set; }
        public string Say() => "i am Amphibians";
        public Amphibians(string name, int power)
        {
            Name = name;
            Power = power;
        }
    }
}
