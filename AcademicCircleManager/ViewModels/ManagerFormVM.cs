using AcademicCircleManagerApp.Actions;
using AcademicCircleManagerApp.Model;
using AcademicCircleManagerApp.Constants;

namespace AcademicCircleManagerApp.ViewModels
{
    class ManagerFormVM : MainFormVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FacultyName { get; set; }
        public string ShortFacultyName { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        public UpdateViewAction Accept
        {
            get => new UpdateViewAction(
                arg =>
                {
                    Store.User = new Manager(FirstName, LastName,
                        new Faculty(FacultyName, ShortFacultyName,
                        ZipCode, City, Street, Number));

                    Store.SaveUserData();
                    return new WelcomeFormVM();
                },
                arg => !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName) && !string.IsNullOrEmpty(FacultyName) 
                && !string.IsNullOrEmpty(ShortFacultyName) && !string.IsNullOrEmpty(ZipCode) && !string.IsNullOrEmpty(City) && !string.IsNullOrEmpty(Street) && !string.IsNullOrEmpty(Number)

            );
        }

    }
}
