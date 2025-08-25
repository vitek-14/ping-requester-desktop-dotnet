using PingRequester.Data.Base;
using System.Text.Json;

namespace PingRequester.BusinessLayer
{
    public class JsonService<T> where T : DataObject
    {
        private string fileName;

        public JsonService(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException($"Cannot create JsonService intance, file '{fileName}' not found.");

            this.fileName = fileName;
        }

        public T LoadFileContent()
        {
            string content = File.ReadAllText(this.fileName);
            T dataObject = JsonSerializer.Deserialize<T>(content);
            return dataObject;
        }

        public void WriteFileContent(T dataObject)
        {
            string content = JsonSerializer.Serialize(dataObject, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(this.fileName, content);
        }
    }
}
