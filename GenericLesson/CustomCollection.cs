using System.Reflection.Metadata;

namespace GenericLesson
{
    internal class CustomCollection<T> where T : Person
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
                    if (id >= Person.Increment)
                    {
                        Console.WriteLine("Id not found");
                        break;
                    }
                    else if (e.Id == id)
                    {
                        var employee = e as Employee;
                        if (employee != null)
                        {
                            Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Surname: {employee.Surname}, Age: {employee.Age}," +
                                $" Salary: {employee.Salary}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Id: {e.Id}, Name: {e.Name}, Surname: {e.Surname}, Age: {e.Age}");
                            break;
                        }
                    }
                   
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
                    var employee = e as Employee;
                    if (employee != null)
                    {
                        Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Surname: {employee.Surname}, Age: {employee.Age}," +
                            $" Salary: {employee.Salary}");
                    }
                    else
                        Console.WriteLine($"Id: {e.Id}, Name: {e.Name}, Surname: {e.Surname}, Age: {e.Age}");
                }
            }
        }
    }
}
