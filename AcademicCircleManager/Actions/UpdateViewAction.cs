using AcademicCircleManagerApp.ViewModels;
using System;
using System.Windows.Input;

namespace AcademicCircleManagerApp.Actions
{
    public class UpdateViewAction : ICommand
    {
        public static MainWindowVM mainWindowVM;
        private Func<object, MainFormVM> _getVM;
        private Predicate<object> _canExecute;

        public UpdateViewAction(Func<object, MainFormVM> getVM, Predicate<object> canExecute = null)
        {
            _getVM = getVM;
            _canExecute = canExecute;
        }

        public void Execute(object parameter)
        {
            mainWindowVM.SelectedViewModel = _getVM(parameter);
        }

        public bool CanExecute(object parameter) => _canExecute == null ? true : _canExecute(parameter);

        public event EventHandler CanExecuteChanged
        {
            add { if (_canExecute != null) CommandManager.RequerySuggested += value; }
            remove { if (_canExecute != null) CommandManager.RequerySuggested -= value; }
        }
    }
}
