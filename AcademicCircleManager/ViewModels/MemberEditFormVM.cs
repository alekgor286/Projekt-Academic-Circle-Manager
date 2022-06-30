using AcademicCircleManagerApp.Actions;
using AcademicCircleManagerApp.Model;
using AcademicCircleManagerApp.Constants;
using System.Collections.Generic;

namespace AcademicCircleManagerApp.ViewModels
{
    abstract class MemberEditorFormVM : MainFormVM
    {
        public static MemberEditorFormVM MemberEditor;
        protected bool _dataOk() =>
        (
            !string.IsNullOrEmpty(FirstName) &&
            !string.IsNullOrEmpty(LastName) &&
            !(Faculty is null) &&
            !(Mean is null) &&
            !string.IsNullOrEmpty(City) &&
            !string.IsNullOrEmpty(Background) &&
            !(Year is null)
        );
        protected virtual void _loadStoredData()
        {
            FirstName = MemberEditor.FirstName;
            LastName = MemberEditor.LastName;
            Faculty = MemberEditor.Faculty;
            Subject = MemberEditor.Subject;
            Year = MemberEditor.Year;
            Mean = MemberEditor.Mean;
            City = MemberEditor.City;
            Background = MemberEditor.Background;
            Other = MemberEditor.Other;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Faculty Faculty { get; set; }
        public List<Faculty> FacultyOptions { get => Store.Facultys; }
        public int? Year { get; set; }
        public string Subject { get; set; }
        public int? Mean { get; set; }
        public string City { get; set; }
        public string Background { get; set; }
        public string Other { get; set; }
        public int[] YearOptions { get => Store.YearOptions; }

        public abstract UpdateViewAction Accept { get; }

        public UpdateViewAction AddFaculty
        {
            get
            {
                return new UpdateViewAction
                (
                    arg => { MemberEditor = this; return new FacultyFormVM(); }
                );
            }
        }
    }
}
