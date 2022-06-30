namespace AcademicCircleManagerApp.Model
{
    class Manager
    {
        public Manager(string firstname, string lastName, Faculty faculty)
        {
            FirstName = firstname;
            LastName = lastName;
            Faculty = faculty;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Faculty Faculty { get; set; }

        public override string ToString()
        {
            return string.Format($"{FirstName} {LastName} {Faculty.ShortName}");
        }
    }
}
