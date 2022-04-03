using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Contractor : Employe
    {
        public string Name { get; set; }
        public double WorkHours { get; set; }

        public int PayPerHour { get; set; }

        public Manager Responsible { get; set; }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }
        public Manager CurrentPosition()
        {
            return Responsible;
        }
    }
}
