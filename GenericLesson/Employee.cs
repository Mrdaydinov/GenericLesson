namespace GenericLesson
{
    internal class Employee : Person
    {
        public decimal Salary { get; set; }

        public Employee(string name, string surname, byte age, decimal salary) : base (name, surname, age)
        {
            Salary = salary;
        }
    }
}