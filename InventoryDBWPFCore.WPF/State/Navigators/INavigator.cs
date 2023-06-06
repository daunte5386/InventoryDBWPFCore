using InventoryDBWPFCore.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InventoryDBWPFCore.WPF.State.Navigators
{
    public enum ViewType
    {
        Computer,
        Monitor,
        Printer,
        Server
    }

    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
