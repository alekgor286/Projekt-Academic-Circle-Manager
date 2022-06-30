using AcademicCircleManagerApp.Actions;

namespace AcademicCircleManagerApp.ViewModels
{
    class WelcomeFormVM : MainFormVM
    {
        public UpdateViewAction GotoMember { get => new UpdateViewAction(arg => new SelectedFormVM()); }

    }
}
