using AcademicCircleManagerApp.Actions;
using AcademicCircleManagerApp.Model;
using AcademicCircleManagerApp.Constants;

namespace AcademicCircleManagerApp.ViewModels
{
    class FacultyFormVM : MainFormVM
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }


        public UpdateViewAction Accept
        {
            get =>
                new UpdateViewAction(
                    arg => {
                        Store.Facultys.Add(new Faculty(Name, ShortName, ZipCode, City, Street, Number));
                        Store.SaveFacultys();
                        return MemberEditorFormVM.MemberEditor; },
                    arg => !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(ShortName)
            );
        }
        public UpdateViewAction Cancel
        {
            get =>
                new UpdateViewAction(
                    arg => MemberEditorFormVM.MemberEditor
            );
        }
    }
}
