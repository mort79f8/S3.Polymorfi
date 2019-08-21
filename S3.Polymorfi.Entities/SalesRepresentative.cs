using System;
using System.Collections.Generic;
using System.Text;

namespace S3.Polymorfi.Entities
{
    public class SalesRepresentative : BaseSalariedEmployee
    {
        #region Fields
        private decimal weeklySales;
        private double commisionRate;
        #endregion

        #region Constructors
        public SalesRepresentative(int id, string name, decimal salary,double commisionRate, decimal weeklySales)
            :base(id, name, salary)
        {
            CommisionRate = commisionRate;
            WeeklySales = weeklySales;
        }

        public SalesRepresentative(string name, decimal salary, double commisionRate, decimal weeklySales)
            : this(default, name, salary, commisionRate, weeklySales) { }
        
        public SalesRepresentative()
        {
        }
        #endregion

        #region Properties
        public double CommisionRate { get => commisionRate; set => commisionRate = value; }
        public decimal WeeklySales { get => weeklySales; set => weeklySales = value; }
        #endregion

        #region Methods
        public override decimal Earnings()
        {      
            return base.Earnings() + (WeeklySales * (decimal)CommisionRate);
        }
        #endregion
    }
}
