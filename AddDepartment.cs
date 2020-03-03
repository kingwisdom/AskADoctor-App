using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeFaceCapure
{
    public class AddDepartments
    {
        //public int ID { get; set; }
        public string Name { get; set; }
        public string TimeOpen { get; set; }
        public string TimeClose { get; set; }

        public AddDepartments(string name, string opentime, string closetime)
        {
            //this.ID = id;
            this.Name = name;
            this.TimeOpen = opentime;
            this.TimeClose = closetime;
        }
    }
}
