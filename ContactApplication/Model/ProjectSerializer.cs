using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ContactApplication.Model
{
    public static class ProjectSerializer
    {
       public static void SaveToFile(List<Contact> contacts, string filePath)
       {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter($"{filePath}\\contacts.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, contacts);
            }
       }

        public static List<Contact> LoadFromFile(string filePath)
        {

            JsonSerializer serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader($"{filePath}\\contacts.json"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                 return serializer.Deserialize<List<Contact>>(reader) ?? new List<Contact>();
            }
        }
    }
}
