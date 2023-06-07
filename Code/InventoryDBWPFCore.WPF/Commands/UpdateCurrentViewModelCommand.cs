using InventoryDBWPFCore.WPF.State.Navigators;
using InventoryDBWPFCore.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InventoryDBWPFCore.WPF.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;

                switch (viewType)
                {
                    case ViewType.Computer:
                        _navigator.CurrentViewModel = new ComputerViewModel();
                        break;
                    case ViewType.Monitor:
                        _navigator.CurrentViewModel = new MonitorViewModel();
                        break;
                    case ViewType.Printer:
                        _navigator.CurrentViewModel = new PrinterViewModel();
                        break;
                    case ViewType.Server:
                        _navigator.CurrentViewModel = new ServerViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
