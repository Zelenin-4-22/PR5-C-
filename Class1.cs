namespace NameManager
{
    public class Person
    {
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public Person(string surname, string firstName, string middleName)
        {
            Surname = surname;
            FirstName = firstName;
            MiddleName = middleName;
        }

        public override string ToString()
        {
            return $"{Surname} {FirstName} {MiddleName}";
        }
    }
}

