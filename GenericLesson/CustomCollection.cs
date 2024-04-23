namespace GenericLesson
{
    internal class CustomCollection<Person> where Person : class
    {
        Employee[] employees = new Employee[0];

        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref employees, employees.Length + 1);
            employees[^1] = employee;
        }

        public void PrintEmployeeInfoById(int id)
        {
            if (employees.Length == 0)
                Console.WriteLine("Employees not exist");
            else
            {
                foreach (Employee e in employees)
                {
                    if (e.Id == id)
                    {
                        Console.WriteLine($"Id: {e.Id}, Name: {e.Name}, Surname: {e.Surname}, Age: {e.Age}, Salary: {e.Salary}");
                        break;
                    }
                    else
                        Console.WriteLine("Not found");
                }
            }
        }

        public void PrintAllEmployeesInfo()
        {
            if (employees.Length == 0)
                Console.WriteLine("Employees not exist");
            else
            {
                foreach (Employee e in employees)
                {
                    Console.WriteLine($"Id: {e.Id}, Name: {e.Name}, Surname: {e.Surname}, Age: {e.Age}, Salary: {e.Salary}");
                }
            }
        }
    }
}
