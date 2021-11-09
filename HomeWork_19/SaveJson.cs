using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace HomeWork_19
{
    class SaveJson : ISaver
    {
        private string FileName;
        public void SaveAnimal(List<IAnimal> DataBase)
        {
            string json = JsonConvert.SerializeObject(DataBase);
            File.WriteAllText(FileName + ".json", json);
        }
        public SaveJson(string fileName)
        {
            FileName = fileName;
        }
    }
}
