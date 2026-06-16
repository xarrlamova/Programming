using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о контакте (в телефонной книжке).
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Номер.
        /// </summary>
        private string _number;

        /// <summary>
        /// Возвращает и задает имя контакта. Должна состоять только из латинских букв.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }
        /// <summary>
        /// Возвращает и задает фамилию контакта. Должна состоять только из латинских букв.
        /// </summary>
        public string Surname
        {
            get => _surname;
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }

        /// <summary>
        /// Проверяет, состоит ли строка только из латинских букв.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="name">Название свойства.</param>
        /// <exception cref="ArgumentException">Исключение - строка должно состоять только из латинских букв.</exception>
        private void AssertStringContainsOnlyLetters(string value, string name)
        {
            if (Regex.IsMatch(value, "^[a-zA-Z]*$") == false)
            {
                throw new ArgumentException($"value in {name} " +
                    $"is supposed to contain only letters");
            }

        }
        
        /// <summary>
        /// Возвращает и задает строку, содержащую номер контакта. Должна начинаться с +7/7/8,
        /// состоять из десяти символов и содержать только цифры от 0-9.
        /// </summary>
        public string Number
        {
            get { return _number; }
            set 
            {
                if (Regex.IsMatch(value, "^((\\+7|7|8)+([0-9]){10})$") == false)
                {
                    throw new ArgumentException("value in number is supposed to contain only " +
                        "numbers and plus");
                }
                _number = value;
            }
        }

        /// <summary>
        /// Создает объект класса <see cref="Contact"/>
        /// </summary>
        public Contact()
        {
        }
        /// <summary>
        /// Создает объект класса <see cref="Contact"/>
        /// </summary>
        /// <param name="name">Имя. Должно состоять из латинских букв.</param>
        /// <param name="surname">Фамилия. Должна состоять из латинских букв.</param>
        /// <param name="number">Номер контакта. Должна начинаться с +7/7/8,
        /// состоять из десяти символов и содержать только цифры от 0-9.</param>
        public Contact(string name, string surname, string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }
    }
}
