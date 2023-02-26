using homework.Structs;
using System;
using System.Collections.ObjectModel;
using System.Data;
using homework.Commands;
using System.Windows.Input;

namespace homework.ViewModel
{
    public class GlobalViewModel : ViewModelBase
    {
        public ICommand AddCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand LoadCommand { get; }
        public ICommand ResultCommand { get; }
        public ICommand ClearCommand { get; }

        public GlobalViewModel()
        {
            ClearCommand = new ClearCommand(this);
            ResultCommand = new ResultCommand(this);
            LoadCommand = new LoadCommand(this);
            SaveCommand = new SaveCommand(this);
            AddCommand = new AddCommand(this);
        }

        private ObservableCollection<StudentInfo> studentInfos = new ObservableCollection<StudentInfo>();

        public ObservableCollection<StudentInfo> StudentInfos
        {
            get { return studentInfos; }
            set 
            { 
                studentInfos = value;
                OnPropertyChanged("StudentInfos");
            }
        }

    }
}
