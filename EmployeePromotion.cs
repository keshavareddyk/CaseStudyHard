using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyHard
{
    class EmployeePromotion
    {
        List<Employee> employeesList = new List<Employee>();

        public EmployeePromotion()
        {
            do
            {
                AddEmployee();
                Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
            }
            while (Convert.ToInt32(Console.ReadLine()) == 1);

        }
        public void Menu()
        {
            do
            {
                Console.WriteLine("Please enter the option \n1.Add an employee \n2.Modify an employee detail \n3.Print all employee's details \n4.Print an employee detail \n5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        ModifyEmployee();
                        break;
                    case 3:
                        PrintAllEmployees();
                        break;
                    case 4:
                        Console.WriteLine("Please enter the Employee ID");
                        int id = Convert.ToInt32(Console.ReadLine());
                        PrintEmployeeWithId(id);
                        break;
                    case 5: return;
                    // break;
                    default:
                        Console.WriteLine("Enter the valid input");
                        break;
                }
            } while (true);
        }
        public void ModifyEmployee()
        {
            Console.WriteLine("Please enter the Employee ID");
            int id = Convert.ToInt32(Console.ReadLine());
            PrintEmployeeWithId(id);
            Console.WriteLine("Please enter the updated Employee Details:");
            Console.WriteLine("Please enter the employee name");
            String name = Console.ReadLine();
            Console.WriteLine("Please enter the employee age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            IEnumerable<Employee> emp = from employee in employeesList where employee.Id == id select employee;
            foreach (var em in emp)
            {
                em.Name = name;
                em.Age = age;
                em.Salary = salary;
            }
        }
        public void PrintEmployeeWithId(int id)
        {
            Console.WriteLine("Employee Details:");
            IEnumerable<Employee> emp = from employee in employeesList where employee.Id == id select employee;
            foreach (var em in emp)
                Console.WriteLine(em);
        }
        public void PrintAllEmployees()
        {
            Console.WriteLine("Employee details: ");
            foreach (Employee employee1 in employeesList)
            {
                Console.WriteLine(employee1);
                Console.WriteLine("--------------------");

            }
        }
        public void AddEmployee()
        {
            Employee employee = new Employee();
            employee.TakeEmployeeDetailsFromUser();
            employeesList.Add(employee);
        }
    }
}
