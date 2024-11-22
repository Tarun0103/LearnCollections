using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collections.Classes
{
    public class LINQQueries
    {
        public void linQ()
        {
            List<Employee> emplist = new List<Employee>
            {
                new Employee() {EmpId = 1, EmpName ="Tarun", EmpDept = "IT",EmpSalary = 50000},
                new Employee() {EmpId = 2,EmpName = "Sekhar", EmpDept = "Electrical", EmpSalary = 60000},
                new Employee() {EmpId = 3,EmpName = "Omkar", EmpDept = "HR", EmpSalary = 30000},
                new Employee() {EmpId = 4,EmpName = "Hemanth", EmpDept = "IT", EmpSalary = 70000},
                new Employee() {EmpId = 5, EmpName = "Sai",EmpDept = "Electronics",EmpSalary = 40000}
            };
            List<EmployeePersonal> emppersonal = new List<EmployeePersonal>
            {
                new EmployeePersonal() {EmpId = 1, personalEmail ="Tarun.gamil.com", MaritialStatus = true,HomeTown = "Vizag"},
                new EmployeePersonal() {EmpId = 2,personalEmail = "Sekhar@gmail.com", MaritialStatus = true, HomeTown = "Bobbili"},
                new EmployeePersonal() {EmpId = 3,personalEmail = "Omkar@hotmail.com", MaritialStatus = false, HomeTown = "Vizag"},
                new EmployeePersonal() {EmpId = 4,personalEmail = "Hemanth@authumail.com", MaritialStatus = false, HomeTown = "SteelPlant"}
            };
            var data = from emp in emplist
                       join
                       emppersonals in emppersonal on emp.EmpId equals emppersonals.EmpId
                       select new { emp.EmpId, emp.EmpName, emppersonals.HomeTown };

                
            
            // Where method contains for each loop internally
            //Executes for each object
            // emp => emp.EmpDept == "Condition" // Lamda expression
            emplist.Where(emp=>emp.EmpDept == "IT");
        }
    }
}
