using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeFaceCapure
{
   public class Attendance
    {
        public int ID { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public Attendance(int id, string time, string date)
        {
            this.ID = id;
            this.Time = time;
            this.Date = date;
        }
    }
}
