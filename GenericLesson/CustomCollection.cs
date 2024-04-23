namespace GenericLesson
{
    internal class CustomCollection<T> where T: Person
    {   
        T[] employees = new T[0];

        public void AddEmployee(T employee)
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
                foreach (T e in employees)
                {
                    if (e.Id == id)
                    {
                        Console.WriteLine($"Id: {e.Id}, Name: {e.Name}, Surname: {e.Surname}, Age: {e.Age}");
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
                foreach (T e in employees)
                {
                    Console.WriteLine($"Id: {e.Id}, Name: {e.Name}, Surname: {e.Surname}, Age: {e.Age}");
                }
            }
        }
    }
}
