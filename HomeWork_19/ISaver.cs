using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19
{

    interface ISaver
    {
        void SaveAnimal(List<IAnimal> DataBase);
    }
}
