using AcademicCircleManagerApp.Model;
using AcademicCircleManagerApp.Constants;
using AcademicCircleManagerApp.Actions;

namespace AcademicCircleManagerApp.ViewModels
{
    class CircleFormVM : AttributeFormVM
    {
        Member _selectedMember;
        Attributes.Cathegory _selectedCathegory = Attributes.AcademicCircle;
        private int _selectedSubcathegoryIndex = 0;
        public override Member SelectedMember { get => _selectedMember; }
        public string SelectedMemberFullName { get => SelectedMember.FirstName + " " + SelectedMember.LastName; }
        public string SelectedSubcathegoryName { get => Attributes.SubcathegoryName[SelectedSubcathegory]; }
        public string Interests { get => _selectedMember.Interests; set => _selectedMember.Interests = value; }

        public Attributes.Cathegory SelectedCathegory
        {
            get => _selectedCathegory;
            set { _selectedCathegory = value; OnPropertyChanged(nameof(SelectedSubcathegory), nameof(SelectedSubcathegoryName)); }
        }

        public AttributeVM[] SelectedSubcathegory
        {
            get => SelectedCathegory.Subcathegories[_selectedSubcathegoryIndex];
        }
        
        public SendAction ChangeSelectedCathegory
        {
            get
            {
                return new SendAction(
                    arg =>
                    {
                        _selectedSubcathegoryIndex = 0;
                        SelectedCathegory = (Attributes.Cathegory)arg;
                    }
                    );
            }
        }

        public SendAction TraverseSubcathegoriesRight
        {
            get
            {
                return new SendAction(
                    arg =>
                    {
                        _selectedSubcathegoryIndex += 1;
                        if (_selectedSubcathegoryIndex >= _selectedCathegory.Subcathegories.Length) _selectedSubcathegoryIndex -= _selectedCathegory.Subcathegories.Length;
                        OnPropertyChanged(nameof(SelectedSubcathegory), nameof(SelectedSubcathegoryName));
                    }
                    );
            }
        }

        public SendAction TraverseSubcathegoriesLeft
        {
            get
            {
                return new SendAction(
                    arg =>
                    {
                        _selectedSubcathegoryIndex -= 1;
                        if (_selectedSubcathegoryIndex < 0 ) _selectedSubcathegoryIndex += _selectedCathegory.Subcathegories.Length;
                        OnPropertyChanged(nameof(SelectedSubcathegory), nameof(SelectedSubcathegoryName));
                    }
                    );
            }
        }

        public CircleFormVM(Member patient)
        {
            _selectedMember = patient;
            Store.OpenAttributearyForm = this;
        }

        
    }
}
