using System;
using System.Windows.Input;

namespace AcademicCircleManagerApp.Actions
{
    class SendAction : ICommand
    {
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;

        public SendAction(Action<object> execute, Predicate<object> canExecute = null)
        {
            if (execute == null) throw new ArgumentNullException(nameof(execute));
            else _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => _canExecute == null ? true : _canExecute(parameter);

        public event EventHandler CanExecuteChanged
        {
            add { if (_canExecute != null) CommandManager.RequerySuggested += value; }
            remove { if (_canExecute != null) CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter) { _execute(parameter); }
    }
}
