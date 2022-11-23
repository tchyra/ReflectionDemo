using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo.Models
{
    // bazowa klasa dla klas mogących powiadomić np. BindingList o zmianie swoich właściwości
    public abstract class NotifyingObject : INotifyPropertyChanged
    {
        public void NotifyAllPropertiesChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
