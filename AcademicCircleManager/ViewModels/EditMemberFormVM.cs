using AcademicCircleManagerApp.Actions;
using AcademicCircleManagerApp.Model;
using AcademicCircleManagerApp.Constants;

namespace AcademicCircleManagerApp.ViewModels
{
    class EditMemberFormVM : MemberEditorFormVM
    {
        private Member _editedMember;

        public override UpdateViewAction Accept
        {
            get
            {
                return new UpdateViewAction(
                    arg =>
                    {
                        _editedMember.FirstName = FirstName;
                        _editedMember.LastName = LastName;
                        _editedMember.Faculty = Faculty;
                        _editedMember.Year = (int) Year;
                        _editedMember.Subject = Subject;
                        _editedMember.Mean = (int) Mean;
                        _editedMember.City = City;
                        _editedMember.Background = Background;
                        _editedMember.Other = Other;
                        Store.SaveMembers();
                        return new MemberListFormVM();
                    },
                    arg => _dataOk()
                    );
            }
        }

        protected override void _loadStoredData()
        {
            base._loadStoredData();
            _editedMember = (MemberEditor as EditMemberFormVM)._editedMember;
        }

        private void _loadMemberData()
        {
            FirstName = _editedMember.FirstName;
            LastName = _editedMember.LastName;
            Faculty = _editedMember.Faculty;
            Subject = _editedMember.Subject;
            Year = _editedMember.Year;
            Mean = _editedMember.Mean;
            City = _editedMember.City;
            Background = _editedMember.Background;
            Other = _editedMember.Other;
        }

        public EditMemberFormVM(Member editedMember)
        {
            _editedMember = editedMember;
            _loadMemberData();
        }
    }
}
