using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ContactApplication.Model
{
    /// <summary>
    /// Представляет реализацию сериализации и десериализации.
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Проводить сериализацию данных.
        /// </summary>
        /// <param name="contacts">Список контактов.</param>
        /// <param name="filePath">Путь файла.</param>
        public static void SaveToFile(List<Contact> contacts)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(ProgramСonstants.FilePath + ProgramСonstants.NameJsonFile))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, contacts);
            }
        }

        /// <summary>
        /// Проводить десириализацию данных.
        /// </summary>
        /// <returns></returns>
        public static List<Contact> LoadFromFile()
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader(ProgramСonstants.FilePath + ProgramСonstants.NameJsonFile))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return serializer.Deserialize<List<Contact>>(reader) ?? new List<Contact>();
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="CreateFilesToAppData"/>.
        /// </summary>
        public static void CreateFilesToAppData()
        {
            try
            {
                var directory = ProgramСonstants.FilePath;

                if (Directory.Exists(directory)) return;
                Directory.CreateDirectory(directory);

                if (File.Exists(ProgramСonstants.FilePath+ProgramСonstants.NameJsonFile)) return;
                File.Create(ProgramСonstants.FilePath + ProgramСonstants.NameJsonFile);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}