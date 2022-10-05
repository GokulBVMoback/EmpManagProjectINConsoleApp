using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Management Application");
            Console.WriteLine("Select Operation:");
            Console.WriteLine("1 Add Employee Details");
            Console.WriteLine("2 Display Employee");
            Console.WriteLine("3 View all Employees");
            Console.WriteLine("4 Search for Employee for a given Name");
            Console.WriteLine("Press 'x' key to exit");
            var operation=Console.ReadLine();
            var empManage = new EmpManage();
            while(true)
            {
                switch (operation)
                {
                    case "1":
                        Console.Write("Employee Id:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Employee Name:");
                        string name = Console.ReadLine();
                        Console.Write("Employee Organization Mail:");
                        string orgMail = Console.ReadLine();
                        Console.Write("Employee Address:");
                        string address = Console.ReadLine();
                        Console.Write("Employee Age:");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Employee Salary:");
                        int salary = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Employee Annual Benefits:");
                        int annualBenefits = Convert.ToInt32(Console.ReadLine());
                        int ctc = (salary * 12) + annualBenefits;
                        Console.Write("Employee CTC:" + ctc);

                        var newEmployee = new Employee(id, name, orgMail, address, age, salary, annualBenefits, ctc);
                        empManage.AddEmployee(newEmployee);
                        break;
                    case "2":
                        Console.WriteLine("Enter the Employee Organization Mail Id to search:");
                        string orgMail1=Console.ReadLine();
                        empManage.SearchEmp(orgMail1);
                        break;
                    case "3":
                        empManage.DisplayAllEmpDetails();
                        break;
                    case "4":
                        Console.WriteLine("Enter the Employee Name You want");
                        string search=Console.ReadLine();
                        empManage.DisplayMatchingEmployee(search);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Select valid Operation");
                        break;
                }
                Console.Write("\nSelect Operation:");
                operation = Console.ReadLine();
            }
        }
    }
}
