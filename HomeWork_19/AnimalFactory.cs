using System;
using System.Collections.Generic;

namespace HomeWork_19
{
    class AnimalFactory
    {
        public static Repository GetRepository()
        {
            Random random = new Random();
            List<IAnimal> list = new List<IAnimal>();

            for (int i = 0; i < random.Next(10,100); i++)
            {
                switch (random.Next(4))
                {
                    case 1: list.Add(new Bird("Птичка", random.Next(10,99))); break;
                    case 2: list.Add(new Mammals("Человек", random.Next(1,99))); break;
                    case 3: list.Add(new Amphibians("Земноводное", random.Next(1,99))); break;
                    default:  list.Add(new UnkownAnimal()); break;
                }
            }

            return new Repository(list);
        }



    }
}
