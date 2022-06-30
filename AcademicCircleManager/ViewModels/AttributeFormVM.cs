using AcademicCircleManagerApp.Actions;
using AcademicCircleManagerApp.Model;
using AcademicCircleManagerApp.Constants;

namespace AcademicCircleManagerApp.ViewModels
{
    abstract class AttributeFormVM : MainFormVM
    {
        public abstract Member SelectedMember { get; }

        public override UpdateViewAction GotoWelcome
        {
            get => new UpdateViewAction(
                arg =>
                    {
                        Store.SaveMembers();
                        return new WelcomeFormVM();
                    }
                );
        }
    }
}
