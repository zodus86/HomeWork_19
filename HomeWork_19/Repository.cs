using System.Collections.Generic;
using System.Linq;

namespace HomeWork_19
{

    class Repository
    {
        public List<IAnimal> bd { get; set; }

        public ISaver SaveMode { get; set; }
        
        /// <summary>
        /// mvp
        /// </summary>
        public void Save()
        {
            SaveMode.SaveAnimal(bd);
        }
        public Repository(IEnumerable<IAnimal> list)
        {
            bd = list.ToList<IAnimal>();
        }

    }

}
