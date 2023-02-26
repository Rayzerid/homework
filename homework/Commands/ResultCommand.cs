using System;
using homework.ViewModel;
using homework.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.Commands
{
    public class ResultCommand : CommandBase
    {
        GlobalViewModel _globalViewModel;
        public ResultCommand(GlobalViewModel globalViewModel)
        {
            _globalViewModel = globalViewModel;
        }
        public override void Execute(object parameter)
        {
            try
            {
                FileProcess fileProcess = new FileProcess(_globalViewModel);
                _globalViewModel.StudentInfos = fileProcess.ResultStudent(_globalViewModel.StudentInfos);
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
