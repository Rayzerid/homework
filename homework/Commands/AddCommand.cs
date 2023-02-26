using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using homework.ViewModel;

namespace homework.Commands
{
    public class AddCommand : CommandBase
    {
        GlobalViewModel _globalViewModel;
        public AddCommand(GlobalViewModel globalViewModel)
        {
            _globalViewModel = globalViewModel;
        }
        public override bool CanExecute(object parameter)
        {
            return true;
        }
        public override async void Execute(object parameter)
        {
            var displayRootRegistry = (Application.Current as App).displayRootRegistry;

            var dialogWindowViewModel = new AddStudentViewModel(_globalViewModel);
            await displayRootRegistry.ShowModalPresentation(dialogWindowViewModel);

        }
    }
}
