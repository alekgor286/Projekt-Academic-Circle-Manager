using AcademicCircleManagerApp.Model;
using AcademicCircleManagerApp.Constants;
using System.Collections.ObjectModel;
using System.Collections;
using System.Windows.Controls;
using AcademicCircleManagerApp.Actions;

namespace AcademicCircleManagerApp.ViewModels
{
    abstract class MemberSelectFormVM : MainFormVM
    {
        protected UpdateViewAction _gotoAttributeary;
        public SelectionMode Selection { get; protected set; }
        public IList SelectedMembers { get; set; }
        public abstract UpdateViewAction GotoAttributeary { get; }
        public ObservableCollection<Member> Members
        { 
            get => Store.Members;
        }
        public MemberSelectFormVM(SelectionMode selectionMode) { Selection = selectionMode; }
    }
}
