using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KRD_1
{
    [Serializable()]
    public class User : INotifyPropertyChanged
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
                    this.name = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public String Surname {
            get { return this.surname; }
            set
            {
                if (value != this.surname)
                {
                    this.surname = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public String Street {
            get { return this.street; }
            set
            {
                if (value != this.street)
                {
                    this.street = value;
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
                }
            }
        }
        public String Country {
            get { return this.country; }
            set
            {
                if (value != this.country)
                {
                    this.country = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
