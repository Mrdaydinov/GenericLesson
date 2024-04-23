namespace GenericLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            CustomCollection<Employee> employees = new CustomCollection<Employee>();
            while (true)
            {
            startLabel:
                Console.WriteLine("Choose: add employee (type add), find employee by id (type id), show all employee (type all)");
            chooseLabel:
                string input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Wrong");
                    goto chooseLabel;
                }

                
                switch (input)
                {
                    case "add":
                    nameLabel:
                        Console.WriteLine("Enter name:");
                        string name = Console.ReadLine();
                        if (name == null)
                        {
                            Console.WriteLine("Wrong name");
                            goto nameLabel;
                        }
                    surnameLabel:
                        Console.WriteLine("Enter surname:");
                        string surname = Console.ReadLine();
                        if (surname == null)
                        {
                            Console.WriteLine("Wrong surname");
                            goto surnameLabel;
                        }
                    ageLabel:
                        Console.WriteLine("Enter age:");
                        bool checkAge = byte.TryParse(Console.ReadLine(), out byte age);
                        if (!checkAge)
                        {
                            Console.WriteLine("Wrong age");
                            goto ageLabel;
                        }
                    salaryLabel:
                        Console.WriteLine("Enter salary:");
                        bool checkSalary = int.TryParse(Console.ReadLine(), out int salary);
                        if (!checkSalary)
                        {
                            Console.WriteLine("Wrong salary:");
                            goto salaryLabel;
                        }

                        employees.AddEmployee(new Employee(name, surname, age, salary));
                        Console.WriteLine("\nWant to continue? (yes or no)");
                    yesOrNoLabel1:
                        string yesOrNo1 = Console.ReadLine();
                        switch (yesOrNo1.ToLower())
                        {
                            case "yes":
                                goto startLabel;
                            case "no":
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Not yes or no");
                                goto yesOrNoLabel1;
                        }
                        break;

                    case "id":
                        Console.WriteLine("\nEnter id:");
                    idLabel:
                        bool checkId = int.TryParse(Console.ReadLine(), out int id);
                        if (!checkId)
                        {
                            Console.WriteLine("Wrong id");
                            goto idLabel;
                        }

                        employees.PrintEmployeeInfoById(id);
                        Console.WriteLine("\nWant to continue? (yes or no)");
                    yesOrNoLabel2:
                        string yesOrNo2 = Console.ReadLine();
                        switch (yesOrNo2.ToLower())
                        {
                            case "yes":
                                goto startLabel;
                            case "no":
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Not yes or no");
                                goto yesOrNoLabel2;
                        }
                        break;

                    case "all":
                        employees.PrintAllEmployeesInfo();
                        Console.WriteLine("\nWant to continue? (yes or no)");
                    yesOrNoLabel3:
                        string yesOrNo3 = Console.ReadLine();
                        switch (yesOrNo3.ToLower())
                        {
                            case "yes":
                                goto startLabel;
                            case "no":
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Not yes or no");
                                goto yesOrNoLabel3;
                        }
                        break;
                }
            }
        }
    }
}
