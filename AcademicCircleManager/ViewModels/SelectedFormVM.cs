using AcademicCircleManagerApp.Actions;
using AcademicCircleManagerApp.Model;
using System.Linq;
using System.Windows.Controls;

namespace AcademicCircleManagerApp.ViewModels
{
    class SelectedFormVM : MemberSelectFormVM
    {
        public SelectedFormVM() : base(SelectionMode.Single) { }
        public override UpdateViewAction GotoAttributeary
        {
            get {
                if (_gotoAttributeary is null)
                {
                    _gotoAttributeary = new UpdateViewAction
                    (
                       arg => new CircleFormVM(SelectedMembers.Cast<Member>().First()),
                       arg => (SelectedMembers!=null &&  SelectedMembers.Cast<Member>().Count() != 0)
                    );
                }
                return _gotoAttributeary;
             }
        }
        
    }
}
