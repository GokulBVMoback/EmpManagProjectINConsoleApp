using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagProj
{
    internal class EmpManage
    {
        private List<Employee> _employee { set; get; }=new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            _employee.Add(employee);
        }
        public void Details(Employee employee)
        {
            Console.WriteLine($"\t\tEmployee Detail: \nID:{employee.Id}, Name:{employee.Name}, Age:{employee.Age}, Address:{employee.Address}, Organisation Mail:{employee.OrgMail}, CTC:{employee.CTC}");
            //Console.WriteLine($"Employee Detail: { employee.Id}, { employee.Name}, { employee.Age}, { employee.Address}, { employee.OrgMail}, { employee.CTC}");
        }
        public void DisplayEmployeeDetails(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Details(employee);
            }
        }
        public void SearchEmp(string orgMail)
        {
            var employee = _employee.FirstOrDefault(x => x.OrgMail == orgMail);
            if(employee == null)
            {
                Console.WriteLine("Organisation Mail Field must contain value");
            }
            else 
            {
                Details(employee);
            }
        }
        public void DisplayAllEmpDetails()
        {
            DisplayEmployeeDetails(_employee);
        }
        public void DisplayMatchingEmployee(string searchPhrase)
        {
            var matchingEmployee=_employee.Where(x=>x.Name.Contains(searchPhrase)).ToList();
            DisplayEmployeeDetails(matchingEmployee);
        }
    }
}
