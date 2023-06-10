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
    public class Contact
    {
        private string _name;
        private string _surname;
        private string _number;

        public string Name
        {
            get => _name;
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }
        public string Surname
        {
            get => _surname;
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }

        private void AssertStringContainsOnlyLetters(string value, string name)
        {
            StackTrace stacktrace = new StackTrace();
            if (Regex.IsMatch(value, "^[a-zA-Z]*$") == false)
            {
                throw new ArgumentException($"value in {name} " +
                    $"is suposed to contain only letters");
            }

        }

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


        public Contact()
        {
        }
        public Contact(string name, string surname, string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }
    }
}
