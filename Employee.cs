using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagProj
{
    internal class Employee
    {
        public Employee(int id, string name, string orgMail, string address,int age, int salary,int annualBenefits, int ctc)
        {
            Id = id;
            Name = name;
            OrgMail = orgMail;
            Address = address;
            Age = age;
            Salary = salary;
            AnnualBenefits = annualBenefits;
            CTC = (Salary*12)+AnnualBenefits;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string OrgMail { get; set; }
        public string Address { get; set; } 
        public int Age { get; set; }
        public int Salary { get; set; } 
        public int AnnualBenefits { get; set; }
        public int CTC { get; set; }



    }
}
