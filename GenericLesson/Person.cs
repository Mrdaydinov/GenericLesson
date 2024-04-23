namespace GenericLesson
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public static int Increment { get; private set; } = 1;

        public Person(string name, string surname, byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Id = Increment++;
        }
    }
}