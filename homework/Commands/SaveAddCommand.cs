using homework.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.Commands
{
    public class SaveAddCommand : CommandBase
    {
        AddStudentViewModel _viewModel;
        public SaveAddCommand(AddStudentViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public override void Execute(object parameter)
        {
            _viewModel._globalViewModel.StudentInfos.Add(new Structs.StudentInfo { Group = _viewModel.Groups, 
                FIO = _viewModel.FIOS,
                Birthday = _viewModel.Birthdays });
        }
    }
}
