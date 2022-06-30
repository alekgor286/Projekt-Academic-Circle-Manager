using AcademicCircleManagerApp.Model;
using AcademicCircleManagerApp.ViewModels.VMBase;
using AcademicCircleManagerApp.Constants;

namespace AcademicCircleManagerApp.ViewModels
{
    class AttributeVM : ViewModelGeneric
    {
        private Model.Attribute _checkedAttribute;

        public AttributeVM(Model.Attribute question)
        {
            _checkedAttribute = question;
        }

        private Member _selectedMember { get => Store.OpenAttributearyForm.SelectedMember; }
        private bool? _status { get => _selectedMember.SelectedAttributes[ID - 1]; set => _selectedMember.SelectedAttributes[ID - 1] = value; }


        public bool YesOptionChecked
        {
            get
            {
                return _status ?? false;
            }
            set
            {
                if (value == false && _status == true) _status = null;
                else _status = value;
                OnPropertyChanged(nameof(YesOptionChecked), nameof(NoOptionChecked));
            }
        }
        public bool NoOptionChecked {
            get => !_status ?? false;
            set
            {
                if (value == false && _status == false) _status = null;
                else _status = !value;
                OnPropertyChanged(nameof(YesOptionChecked), nameof(NoOptionChecked));
            }
        }

        public int ID { get => _checkedAttribute.ID; }
        public string Text { get => _checkedAttribute.Text; }
        public string Label { get => $"{Text}"; }

        public void RaiseSelectedMemberChanged()
        {
            OnPropertyChanged(nameof(YesOptionChecked), nameof(NoOptionChecked));
        }
    }
}
