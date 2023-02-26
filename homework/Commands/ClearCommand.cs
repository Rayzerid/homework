using System;
using System.CodeDom;
using homework.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.Commands
{
    public class ClearCommand : CommandBase
    {
        GlobalViewModel _globalViewModel;
        public ClearCommand(GlobalViewModel globalViewModel)
        {
            _globalViewModel = globalViewModel;
        }
        public override void Execute(object parameter)
        {
            _globalViewModel.StudentInfos = new System.Collections.ObjectModel.ObservableCollection<Structs.StudentInfo>();
        }
    }
}
