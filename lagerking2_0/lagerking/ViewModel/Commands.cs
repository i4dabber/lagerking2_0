using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Data;
using lagerking.View;

namespace lagerking
{
    public class Commands : CommandBase, INotifyPropertyChanged
    {
        string filename = "";
       

        public Commands()
        {

            Opdater();
           
        }

        #region Clock

        string dato;
        string tid;
        
        public void Opdater()
        {
            Dato = DateTime.Now.ToLongDateString();
            Tid = DateTime.Now.ToLongTimeString();
        }

        public string Dato
        {
            get { return dato; }
            private set
            {
                if (dato != value)
                {
                    dato = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Tid
        {
            get { return tid; }
            private set
            {
                if (tid != value)
                {
                    tid = value;
                    NotifyPropertyChanged();
                    
                }
            }
        }


        #endregion


        #region Commands

        ICommand _newWindow;
        public ICommand NewWindowCommand
        {
            get { return _newWindow ?? (_newWindow = new RelayCommand(AddWindow)); }
        }

        private void AddWindow()
        {
            Medarbejder md = new Medarbejder();
            md.Show();
             
        MediatorImpl.NotifyColleagues("New", true);
          

        }

        ICommand _addCommand;
        public ICommand AddCommand
        {
            get { return _addCommand ?? (_addCommand = new RelayCommand(AddVare)); }
        }

        private void AddVare()
        {
            CurrentAfdelingIndex = 0;
            ProduktIndex newFunc = new ProduktIndex();

            Add(newFunc);
            CurrentVarer = newFunc;
            MediatorImpl.NotifyColleagues("Add", true);

        }


        ICommand _deleteCommand;
        public ICommand DeleteCommand
        {
            get { return _deleteCommand ?? (_deleteCommand = new RelayCommand(DeleteVare, DeleteVare_CanExecute)); }
        }

        private void DeleteVare()
        {
            Remove(CurrentVarer);
            MediatorImpl.NotifyColleagues("Del", true);
        }

        private bool DeleteVare_CanExecute()
        {
            if (Count > 0 && CurrentIndex >= 0)
                return true;
            else
                return false;
        }
        ICommand _nextCommand;
        public ICommand NextCommand
        {
            get
            {
                return _nextCommand ?? (_nextCommand = new RelayCommand(
                    () => ++CurrentIndex,
                    () => CurrentIndex < (Count - 1)));
            }
        }

        ICommand _PreviusCommand;
        public ICommand PreviusCommand
        {
            get { return _PreviusCommand ?? (_PreviusCommand = new RelayCommand(PreviusCommandExecute, PreviusCommandCanExecute)); }
        }

        private void PreviusCommandExecute()
        {
            if (CurrentIndex > 0)
                --CurrentIndex;
        }

        private bool PreviusCommandCanExecute()
        {
            if (CurrentIndex > 0)
                return true;
            else
                return false;
        }

        ICommand _SaveAsCommand;
        public ICommand SaveAsCommand
        {
            get { return _SaveAsCommand ?? (_SaveAsCommand = new RelayCommand<string>(SaveAsCommand_Execute)); }
        }

        private void SaveAsCommand_Execute(string argFilename)
        {
            if (argFilename == "")
            {
                MessageBox.Show("Du skal skrive et fil navn før du gemmer!", "UGYLDIG!",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                filename = argFilename;
                SaveFileCommand_Execute();
            }
        }

        ICommand _SaveCommand;
        public ICommand SaveCommand
        {
            get { return _SaveCommand ?? (_SaveCommand = new RelayCommand(SaveFileCommand_Execute, SaveFileCommand_CanExecute)); }
        }

        private void SaveFileCommand_Execute()
        {
            // Create an instance of the XmlSerializer class and specify the type of object to serialize.
            XmlSerializer serializer = new XmlSerializer(typeof(CommandBase));
            TextWriter writer = new StreamWriter(filename);
            // Serialize all the agents.
            serializer.Serialize(writer, this);
            writer.Close();
        }

        private bool SaveFileCommand_CanExecute()
        {
            return (filename != "") && (Count > 0);
        }

        #endregion 
       
        
        
        #region Properties

        int currentIndex = -1;

        public int CurrentIndex
        {
            get { return currentIndex; }
            set
            {
                if (currentIndex != value)
                {
                    currentIndex = value;
                    NotifyPropertyChanged();
                }
            }
        }

        ProduktIndex currentVarer = null;

        public ProduktIndex CurrentVarer
        {
            get { return currentVarer; }
            set
            {
                if (currentVarer != value)
                {
                    currentVarer = value;
                    NotifyPropertyChanged();
                }
            }
        }
        
        ICommand _NewFileCommand;
        public ICommand NewFileCommand
        {
            get { return _NewFileCommand ?? (_NewFileCommand = new RelayCommand(NewFileCommand_Execute)); }
        }

        private void NewFileCommand_Execute()
        {
            MessageBoxResult res = MessageBox.Show("Er du sikker på at du vil starte en ny fil?", "OBS! Alt data bliver slettet",
                MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (res == MessageBoxResult.Yes)
            {
                Clear();
                filename = "";
            }
        }

        ICommand _OpenFileCommand;
        public ICommand OpenFileCommand
        {
            get { return _OpenFileCommand ?? (_OpenFileCommand = new RelayCommand<string>(OpenFileCommand_Execute)); }
        }

        private void OpenFileCommand_Execute(string argFilename)
        {
            if (argFilename == "")
            {

                MessageBox.Show("Du skal skrive et filnavn på tekstboksen", "Kan ikke gemme filen",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                filename = argFilename;
                CommandBase tempFunc = new CommandBase();

                // Create an instance of the XmlSerializer class and specify the type of object to deserialize.
                XmlSerializer serializer = new XmlSerializer(typeof(CommandBase));
                try
                {
                    TextReader reader = new StreamReader(filename);
                    // Deserialize all the agents.
                    tempFunc = (CommandBase)serializer.Deserialize(reader);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Kan ikke gemme filen", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                // Vi indsætter varerindex ind igen 
                Clear();
                foreach (var varer in tempFunc)
                    Add(varer);
            }
        }

        ICommand _CloseAppCommand;
        public ICommand CloseAppCommand
        {
            get { return _CloseAppCommand ?? (_CloseAppCommand = new RelayCommand(CloseCommand_Execute)); }
        }

        private void CloseCommand_Execute()
        {
            Application.Current.MainWindow.Close();
        }


        public IReadOnlyCollection<string> FilterSpecialities
        {
            get
            {
                ObservableCollection<string> result = new ObservableCollection<string>();
                result.Add("All");
                foreach (var s in new Afdelinger())
                    result.Add(s);
                return result;
            }
        }

        int currentAfdelingIndex = 0;

        public int CurrentAfdelingIndex
        {
            get { return currentAfdelingIndex; }
            set
            {
                if (currentAfdelingIndex != value)
                {
                    ICollectionView cv = CollectionViewSource.GetDefaultView(this);
                    currentAfdelingIndex = value;
                    if (currentAfdelingIndex == 0)
                        cv.Filter = null;
                   
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion
    }
}
