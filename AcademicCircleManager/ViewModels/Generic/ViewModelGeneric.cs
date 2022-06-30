using AcademicCircleManagerApp.Actions;
using System.ComponentModel;

namespace AcademicCircleManagerApp.ViewModels.VMBase
{
    public class ViewModelGeneric : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(params string[] namesOfProperties)
        {
            if (PropertyChanged != null)
            {
                foreach (var prop in namesOfProperties)
                { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
            }
        }

        virtual public UpdateViewAction GotoAddMember { get => new UpdateViewAction(arg => new AddMemberFormVM()); }
        virtual public UpdateViewAction GotoWelcome { get => new UpdateViewAction(arg => new WelcomeFormVM()); }
        virtual public UpdateViewAction GotoMemberList { get => new UpdateViewAction(arg => new MemberListFormVM()); }
    }
}
