using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Classes
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public string? EmpDept { get; set; }
        public int EmpSalary { get; set; }
    }

    public class EmployeePersonal
    {
        public int EmpId { get; set; }
        public string? personalEmail { get; set; }

        public bool MaritialStatus { get; set; }
        public string HomeTown { get; set; }
    }
}
