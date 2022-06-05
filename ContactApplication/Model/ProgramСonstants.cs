using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ContactApplication.Model;
using ContactApplication.Properties;
using static System.Environment;
using Contact = ContactApplication.Model.Contact;

///
/// \\Contacts Application"
/// contacts.json
/// AppDataFolder
namespace ContactApplication.Model
{
    /// <summary>
    /// Хранит данные о цветах программы.
    /// </summary>
    public static class ProgramСonstants
    {
        /// <summary>
        /// Хранит имя папки для хранения данных.
        /// </summary>
        public const string NameStorageFolder = "\\Contacts Application";

        /// <summary>
        /// Хранит названия json файла.
        /// </summary>
        public const string NameJsonFile = "\\contacts.json";

        /// <summary>
        /// Хранит путь до папки AppData.
        /// </summary>
        public static readonly string AppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        /// <summary>
        /// Хранит путь до папки хранения.
        /// </summary>
        public static string FilePath = AppDataFolder + NameStorageFolder;
    }
}
