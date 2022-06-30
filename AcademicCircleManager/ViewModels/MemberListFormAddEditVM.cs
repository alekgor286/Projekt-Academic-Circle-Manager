using AcademicCircleManagerApp.Actions;
using AcademicCircleManagerApp.Model;
using AcademicCircleManagerApp.Constants;
using System.Collections.ObjectModel;

namespace AcademicCircleManagerApp.ViewModels
{
    partial class MemberListFormVM : MainFormVM
    {
        private Member _selectedMember;
        public Member SelectedMember { get => _selectedMember; set { _selectedMember = value; OnPropertyChanged(nameof(MemberDetails));} }
        public ObservableCollection<Member> Members { get => Store.Members; }

        override public UpdateViewAction GotoAddMember { get => new UpdateViewAction(arg => new AddMemberFormVM()); }
        public UpdateViewAction GotoEditMember {
            get => new UpdateViewAction(
                arg => new EditMemberFormVM(SelectedMember),
                arg => SelectedMember != null
                ); }

        private SendAction _deleteMember;
        public SendAction DeleteMember
        {
            get
            {
                if (_deleteMember == null)
                {
                    _deleteMember = new SendAction(
                        arg =>
                        {
                            Store.Members.RemoveAt(Store.Members.IndexOf(SelectedMember));
                            OnPropertyChanged(nameof(Members));
                            Store.SaveMembers();
                        },
                        arg => SelectedMember != null
                        ) ;
                }
                return _deleteMember;
            }
        }
        public string MemberDetails { get
            {
                if (SelectedMember is null) return string.Empty;
                else return SelectedMember.Details;
            }
        }
    }
}
