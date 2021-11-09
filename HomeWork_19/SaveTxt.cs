using System.Collections.Generic;
using System.IO;

namespace HomeWork_19
{
    class SaveTxt : ISaver
    {
        private string FileName;
        public SaveTxt(string fileName)
        {
            FileName = fileName;
        }
        public void SaveAnimal(List<IAnimal> DataBase)
        {
            using (StreamWriter streamWriter = new StreamWriter(FileName + ".txt"))
            {
                foreach(var line in DataBase)
                    streamWriter.WriteLine(line.ToString());
            }
        }
    }
}
