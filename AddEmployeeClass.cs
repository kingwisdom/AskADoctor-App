using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeFaceCapure
{
   public class AddEmployeeClass
    {
       

        public string Department { get; set; }
        public string FullName { get; set; }
        public string Sex { get; set; }
        public string Date { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }



        public AddEmployeeClass(string fullName, string sex, string email, string date, int salary, string department)
        {
            this.Department = department;
            this.FullName = fullName;
            this.Sex = sex;
            this.Date = date;
            this.Email = email;
            this.Salary = salary;
        }

        
    }
}
