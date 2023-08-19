using System;

namespace PractiseADO
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            do
            {

                Console.WriteLine("1.For Adding Employees");
                Console.WriteLine("2.For updating Employees");
                Console.WriteLine("3.Delete Employees");
                Console.WriteLine("4.Display all employees");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter your input");
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    
                    case 1:
                        {
                            Employee e = new Employee();
                            Console.WriteLine("Enter Employee Id");
                            e.ID = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Employee Name");
                            e.Name = Console.ReadLine();
                            Console.WriteLine("Enter Employee Location");
                            e.Loctaion = Console.ReadLine();
                            Console.WriteLine("Enter Employee Salary");
                            e.Salary = float.Parse(Console.ReadLine());

                            EmployeeCRUD.AddEmployee(e);

                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Enter the EmployeeId");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Employee Name");
                            string name = Console.ReadLine();

                            EmployeeCRUD.UpdateEmployee(id, name);



                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Enter the EmploeeID");
                            int id = Convert.ToInt32(Console.ReadLine());
                            EmployeeCRUD.DeleteEmployee(id);
                            break;
                        }

                    case 4:
                        {
                            EmployeeCRUD.DisplayEmployee();
                            break;
                        }

                    case 5:
                        {
                            break;
                        }



                }


            } while (input != 5);
        }
    }
}
