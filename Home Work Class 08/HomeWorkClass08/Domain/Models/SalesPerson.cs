using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class SalesPerson : Employe
    {
        private double _successSaleRevenue { get; set; }

        public SalesPerson()
        {

        }

        public SalesPerson( string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            Salary = 500;
            Role = RoleEnum.Sales;
        }

        public void AddSuccessRevenue (double revenue)
        {
            _successSaleRevenue += revenue;
        }

        public override double GetSalary()
        {
            if (_successSaleRevenue <= 2000)
            {
                return Salary = 500;
            }
            if (_successSaleRevenue > 200 && _successSaleRevenue <= 5000)
            {
                return Salary + 1000;
            }
            return Salary + 1500;
        }
    }
}
