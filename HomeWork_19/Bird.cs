using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19
{
    class Bird : IAnimal
    {
        public int FlySpeed { get; set; }
        public string Name { get; set; }
        public string Say() => "i am Bird"; 

        public Bird (string name, int flySpeed)
        {
            Name = name;
            FlySpeed = flySpeed;
        }
    }
}
