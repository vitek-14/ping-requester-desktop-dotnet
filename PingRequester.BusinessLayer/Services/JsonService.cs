using PingRequester.Data.Base;
using System.Text.Json;

namespace PingRequester.BusinessLayer.Services
{
    /// <summary>
    /// Json service logic instance.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class JsonService<T> where T : DataObject
    {
        private string fileName;

        /// <summary>
        /// Default constructor of JsonService.
        /// </summary>
        /// <param name="fileName"></param>
        /// <exception cref="FileNotFoundException"></exception>
        public JsonService(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException($"Cannot create JsonService intance, file '{fileName}' not found.");

            this.fileName = fileName;
        }

        /// <summary>
        /// Loads content of json file and deserializes it into the data structure of type T.
        /// </summary>
        /// <returns>Content of json file converted to the data structure of type T.</returns>
        public T LoadFileContent()
        {
            string content = File.ReadAllText(this.fileName);
            T dataObject = JsonSerializer.Deserialize<T>(content);
            return dataObject;
        }

        /// <summary>
        /// Writes/overwrites json file from data object of type T.
        /// </summary>
        /// <param name="dataObject"></param>
        public void WriteFileContent(T dataObject)
        {
            string content = JsonSerializer.Serialize(dataObject, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(this.fileName, content);
        }
    }
}
