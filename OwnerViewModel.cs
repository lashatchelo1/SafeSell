using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SafeSell.Classes
{
    class OwnerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string personalId = string.Empty;

        string fullName = string.Empty;

        public string PersonalId
        {
            get
            {
                return personalId;
            }
            set
            {
                personalId = value;

                OnPropertyChanged("PersonalId");
            }
        }

        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;

                OnPropertyChanged("Fullname");
            }
        }

        private void OnPropertyChanged(string Value)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Value));
        }
    }
}
