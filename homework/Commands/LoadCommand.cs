using homework.ViewModel;
using Microsoft.Win32;
using homework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homework.Structs;

namespace homework.Commands
{
    [Serializable]
    public class LoadCommand : CommandBase
    {
        GlobalViewModel _globalViewModel;
        public LoadCommand(GlobalViewModel globalViewModel)
        {
            _globalViewModel = globalViewModel;
        }
        public override void Execute(object parameter)
        {
            try
            {
                FileProcess fileProcess = new FileProcess(_globalViewModel);
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "*.dat|*.dat";
                ofd.Title = "Выберите месторасположение файла";
                ofd.RestoreDirectory = true;
                ofd.ShowDialog();

                _globalViewModel.StudentInfos = fileProcess.ReadFromFile(ofd.FileName);
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
