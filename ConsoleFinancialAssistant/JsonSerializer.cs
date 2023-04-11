using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ConsoleFinancialAssistant
{
    public class JsonSerializer : ISerializer
    {
        public void Serialize<T>(T data, string filePath)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.WriteLine(System.Text.Json.JsonSerializer.Serialize(data));
            }
        }

        public T Deserialize<T>(string filePath)
        {
            string text = File.ReadAllText(filePath);

            T result = System.Text.Json.JsonSerializer.Deserialize<T>(text);

            return result;
        }
    }
}
