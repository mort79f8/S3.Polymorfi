using System;
using System.Collections.Generic;
using System.Text;

namespace S3.Polymorfi.Entities
{
    public class BaseSalariedEmployee: Employee
    {
        
        #region Fields
        private decimal salary;
        #endregion

        #region Constructors
        public BaseSalariedEmployee(int id, string name, decimal salary)
            :base(id, name)
        {
            Salary = salary;
        }

        public BaseSalariedEmployee(string name, decimal salary)
            : this(default, name, salary) { }
        

        public BaseSalariedEmployee()
        {

        }
        #endregion

        #region Properties
        public decimal Salary { get => salary; set => salary = value; }
        #endregion

        #region Methods
        public override decimal Earnings()
        {
            return Salary;
        }
        #endregion
    }
}
