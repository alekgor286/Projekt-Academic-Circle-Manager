using Newtonsoft.Json;
using AcademicCircleManagerApp.Constants;

namespace AcademicCircleManagerApp.Model
{
    class Member
    {
        [JsonProperty]
        private int _facultyIndex;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [JsonIgnore]
        public Faculty Faculty { get => Store.Facultys[_facultyIndex]; set => _facultyIndex=Store.Facultys.IndexOf(value); }
        public int Year { get; set; }
        public string Subject { get; set; }
        public int Mean { get; set; }
        public string City { get; set; }
        public string Background { get; set; }
        public string Other { get; set; }
        public bool?[] SelectedAttributes { get; set; } = new bool?[40];
        public string Interests { get; set; }
        public string Details
        {
            get
            {
                string details = $"{FirstName} {LastName}\n" +
                    $"Rok studiów: {Year}\nKierunek: {Subject}\n" +
                    $"Wydział: {Faculty.Name}\nŚrednia: {Mean}\nMiasto: {City}\n" +
                    $"Narodowość: {Background}";

                if (!string.IsNullOrEmpty(Other)) details += $"\nInne: {Other}";

                return details;
            }
        }

        public Member() { }
        public Member(string firstName, string lastName, Faculty faculty, int year, string subject, int mean, string city, string background, string other = null)
        {
            FirstName = firstName;
            LastName = lastName;
            Faculty = faculty;
            Year = year;
            Subject = subject;
            Mean = mean;
            City = city;
            Background = background;
            Other = other;
        }

        public Member(Member m)
        {
            FirstName = m.FirstName;
            LastName = m.LastName;
            Faculty = m.Faculty;
            Year = m.Year;
            Subject = m.Subject;
            Mean = m.Mean;
            City = m.City;
            Background = m.Background;
            Other = m.Other;
        }

        public override string ToString()
        {
            return string.Format($"{FirstName} {LastName}");
        }
    }
}
