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
        private string _number;

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        
        public string Number
        {
            get { return _number; }
            set 
            {
                StackTrace stacktrace = new StackTrace();
                if (Regex.IsMatch(value, "^((\\+7|7|8)+([0-9]){10})$") == false)
                {
                    throw new ArgumentException("value in number is suposed to contain only numbers and plus");
                }
                _number = value;
            }
        }

        private void AssertStringContainsOnlyNumbers(string value, string name)
        {
            StackTrace stacktrace = new StackTrace();
            if (Regex.IsMatch(value, "^((\\+7|7|8)+([0-9]){10})$") == false)
            {
                throw new ArgumentException($"value in {name} " +
                    $"is suposed to contain only numbers and plus");
            }

        }

        public Contact()
        {
        }
        public Contact(string firstname, string lastname, string number)
        {
            Firstname = firstname;
            Lastname = lastname;
            Number = number;
        }
    }
}
