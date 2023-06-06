using InventoryDBWPFCore.WPF.Commands;
using InventoryDBWPFCore.WPF.Models;
using InventoryDBWPFCore.WPF.ViewModels;
using System.Windows.Input;

namespace InventoryDBWPFCore.WPF.State.Navigators
{
    public class Navigator : ObservableObject, INavigator 
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }      

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);

        
    }
}
