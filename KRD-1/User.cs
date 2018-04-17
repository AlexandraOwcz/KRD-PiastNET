using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KRD_1
{
    [Serializable()]
    public class User : ICheckCorrectness
    {
        private String name = String.Empty;
        private String surname = String.Empty;
        private String street = String.Empty;
        private Char gender;
        private String country = String.Empty;

        // Properties
        public String Name {
            get { return this.name; }
            set {
                if (value != this.name)
                {
                    if(ContainsOnlyLetters(value))
                        this.name = value;

                }
            }
        }
        public String Surname {
            get { return this.surname; }
            set
            {
                if (value != this.surname)
                {
                    if(ContainsOnlyLetters(value))
                        this.surname = value;
                }
            }
        }
        public String Street {
            get { return this.street; }
            set
            {
                if (value != this.street)
                {
                    if(ContainsOnlyLetters(value))
                        this.street = value;
                }
            }
        }
        public Char Gender {
            get { return this.gender; }
            set
            {
                if (value != this.gender)
                {
                    this.gender = value;
                }
            }
        }
        public String Country {
            get { return this.country; }
            set
            {
                if (value != this.country)
                {
                    if(ContainsOnlyLetters(value))
                        this.country = value;
                }
            }
        }
        
        public bool ContainsNumber(string text)
        {
            bool containsAnyNumber = text.Any(char.IsDigit);
            return containsAnyNumber;
        }

        public bool ContainsOnlyLetters(string text)
        {
            bool containsOnlyLetters = Regex.IsMatch(text, @"^[a-zA-Z]+$");
            return containsOnlyLetters;
        }
    }
}
