using AcademicCircleManagerApp.Actions;
using AcademicCircleManagerApp.Model;
using AcademicCircleManagerApp.Constants;

namespace AcademicCircleManagerApp.ViewModels
{
    class AddMemberFormVM : MemberEditorFormVM
    {
        public AddMemberFormVM()
        {
            if (MemberEditor != null)
            {
                _loadStoredData();
                MemberEditor = null;
            }
        }

        public override UpdateViewAction Accept
        {
            get
            {
                return new UpdateViewAction
                (
                    arg =>
                    {
                        Store.Members.Add(new Member(FirstName, LastName, Faculty, (int)Year, Subject, (int)Mean, City, Background, Other));
                        Store.SaveMembers();
                        return new MemberListFormVM();
                    },
                    (arg) => _dataOk()
                );
            }
        }



    }
}
