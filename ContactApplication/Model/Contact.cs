using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApplication.Model
{
    public class Contact
    {
        private string _fullName;

        private DateTime _dateOfBirth;

        private readonly int _id;

        private string _telegram;

        private static int _allContactCount;

        public Contact()
        {
            _id = _allContactCount++;
        }

        public Contact(string fullName,
                      DateTime dateOfBirth,
                      string number,
                      string telegram)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Number = number;
            _allContactCount++;
            _id = _allContactCount;
            Telegram = telegram;
        }

        public Contact(Contact other)
        {
            _id = other._id;
            FullName = other._fullName;
            DateOfBirth = other._dateOfBirth;
            Telegram = other._telegram;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public static int AllContactCount
        {
            get
            {
                return _allContactCount;
            }
        }

        public string FullName
        {
            get
            {
                return _fullName;
            }

            set
            {
                Validator.AssertCountSymbolsInRange(value, 0, 150, nameof(FullName));
                _fullName = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }

            set
            {
                _dateOfBirth = value;
            }
        }

        public string Number { get; set; }

        public string Telegram { get; set; }
    }
}
