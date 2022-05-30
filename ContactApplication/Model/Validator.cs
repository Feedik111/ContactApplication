using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApplication.Model
{
    internal class Validator
    {
        public static void AssertCountSymbolsInRange(string value, int min, int max, string nameProperty)
        {
            if (value.Length < min || value.Length > max)
            {
                throw new ArgumentException($"{nameProperty} must be between {min} and {max}");
            }
        }
    }
}
