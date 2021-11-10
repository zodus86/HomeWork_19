using System;

namespace HomeWork_19
{
    class AnimalFactory
    {
        public static IAnimal GetAnimal()
        {
            Random random = new Random();
            switch (random.Next(0,3))
            {
                case 1: 
                    return new Bird("Птичка", random.Next(10, 99));
                case 2: 
                    return new Mammals("Человек", random.Next(1, 99));
                case 3:
                    return new Amphibians("Земноводное", random.Next(1, 99));
                default: 
                    return new UnkownAnimal();
            }
        }


    }
}
