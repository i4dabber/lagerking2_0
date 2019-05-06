using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Media;
using System.Windows.Data;




namespace lagerking
{
    
    public class CommandBase : ObservableCollection<ProduktIndex>, INotifyPropertyChanged
    {
     
 
        #region INotifyPropertyChanged implementation

        public new event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
