using System;
using System.Collections.Generic;
using System.Text;


namespace EmployeeFaceCapure
{
    public class AttendanceManager : IEmployee
    {
        public List<AddEmployeeClass> addemployee = new List<AddEmployeeClass>();
        public List<AddDepartments> adddepartment = new List<AddDepartments>();

        public void AddDepartment(AddDepartments departments)
        {
            adddepartment.Add(departments);
        }

        public void AddEmployee(AddEmployeeClass employee)
        {
            addemployee.Add(employee);
        }
    }
}
