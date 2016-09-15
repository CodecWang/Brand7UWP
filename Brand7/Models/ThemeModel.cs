using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Brand7.Models
{
    class ThemeModel : INotifyPropertyChanged
    {
        private ElementTheme _theme = ElementTheme.Light;
        public ElementTheme Theme
        {
            get
            {
                return _theme;
            }
            set
            {
                _theme = value;
                notifyPropertyChanged("Theme");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void notifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
