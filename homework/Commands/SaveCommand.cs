using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homework.ViewModel;
using homework.Model;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace homework.Commands
{
    public class SaveCommand : CommandBase
    {
        GlobalViewModel _globalViewModel;
        public SaveCommand(GlobalViewModel globalViewModel)
        {
            _globalViewModel = globalViewModel;
        }

        public override void Execute(object parameter)
        {
            try
            {
                FileProcess fileProcess = new FileProcess(_globalViewModel);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "*.dat|*.dat";
                saveFileDialog.Title = "Выберите месторасположение файла";
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.ShowDialog();
                fileProcess.SaveToFile(saveFileDialog.FileName);
            }
            catch
            {
                return;
            }
        }
    }
}
