using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApplication.Model
{
    /// <summary>
    /// Представляет метод для проверки данных.
    /// </summary>
    internal class Validator
    {
        /// <summary>
        /// Проверяет, на кол-во символов в строке.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <param name="nameProperty">Имя свойства вызванного метода.</param>
        /// <exception cref="ArgumentException">Возникает при несоответствии условию.</exception>
        public static void AssertCountSymbolsInRange(string value, int min, int max, string nameProperty)
        {
            if (value.Length < min || value.Length > max)
            {
                throw new ArgumentException($"{nameProperty} must be between {min} and {max}");
            }
        }
    }
}
