namespace AcademicCircleManagerApp.Model
{
    class Faculty
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }


        public Faculty() { }
        public Faculty(string name, string shortName, string zipCode, string city, string street, string number, int? secondNumber = null)
        {
            Name = name;
            ShortName = shortName;
            ZipCode = zipCode;
            City = city;
            Street = street;
            Number = number;
        }
        public Faculty(Faculty f)
        {
            Name = f.Name;
            ShortName = f.ShortName;
            ZipCode = f.ZipCode;
            City = f.City;
            Street = f.Street;
            Number = f.Number;
        }

        public override string ToString()
        {
            return ShortName;
        }

    }

    
}