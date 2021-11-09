using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19
{
    class UnkownAnimal : IAnimal
    {
        public string Name { get; set; }

        public string Say()
        {
            return "cant say I UnkownAnimal";
        }

        public UnkownAnimal()
        {
            Name = "UnkownAnimal";
        }
    }
}
