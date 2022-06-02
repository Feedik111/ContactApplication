using System;

namespace ContactApplication.Model
{
    /// <summary>
    /// Хранит контактные данные человека.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Полное имя,
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Дата рождения.
        /// </summary>
        private DateTime _dateOfBirth;

        /// <summary>
        /// Количество песен.
        /// </summary>
        private static int _allContactCount;

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {
            Id = _allContactCount++;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="fullName">Полное имя. Должно состоять из менее чем 150 символов.</param>
        /// <param name="dateOfBirth">Дата рождения. Не может быть раньше 1900.1.1 и не позже текущего дня.</param>
        /// <param name="number">Номер телефона. Должен начинаться с +7, должен состоять из 11 цифр.</param>
        /// <param name="vk">Социальная сеть.</param>
        public Contact(string fullName,
                      DateTime dateOfBirth,
                      string number,
                      string vk)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Number = number;
            Id = _allContactCount++;
            Vk = vk;
        }

        /// <summary>
        /// Создает копию экземпляра класса <see cref="Contact"/>.
        /// </summary>
        public Contact(Contact other)
        {
            Id = other.Id;
            FullName = other._fullName;
            DateOfBirth = other._dateOfBirth;
        }

        /// <summary>
        /// Возвращает идентификатор .
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает и задает имя контакта. Должно состоять из менее чем 150 символов.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает дату рождения контакта.
        /// </summary>
        public DateTime DateOfBirth
        {
            get => _dateOfBirth;

            set => _dateOfBirth = value;
        }

        /// <summary>
        /// Возвращает номер контакта.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Возвращает ссылку на соц.сеть контакта.
        /// </summary>
        public string Vk { get; set; }
    }
}
