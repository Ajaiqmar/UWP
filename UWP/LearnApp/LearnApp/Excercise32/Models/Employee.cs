using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnApp.Excercise32.Models
{
    class Employee : INotifyPropertyChanged
    {
        private string _name;
        private string _fullname;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public String Name
        {
            get { return _name; }
            set{ 
                _name = value;
                OnPropertyChanged("FullName");
            }
        }

        public String FullName
        {
            get { return "Mr "+_name; }
            set { _fullname = value; }
        }
    }
}
