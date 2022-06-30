using AcademicCircleManagerApp.Actions;
using AcademicCircleManagerApp.Constants;
using AcademicCircleManagerApp.ViewModels.VMBase;

namespace AcademicCircleManagerApp.ViewModels
{
	public class MainWindowVM : ViewModelGeneric
	{
		private MainFormVM _selectedViewModel;

		public MainFormVM SelectedViewModel
		{
			get { return _selectedViewModel; }
			set 
			{ 
				_selectedViewModel = value;
				OnPropertyChanged(nameof(SelectedViewModel));
			}
		}

		public MainWindowVM()
		{
            UpdateViewAction.mainWindowVM = this;
			if (Store.TryLoadUserData())
				_selectedViewModel = new WelcomeFormVM();
			else _selectedViewModel = new ManagerFormVM();
		}
	}
}
