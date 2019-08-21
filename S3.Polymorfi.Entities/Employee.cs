using System;
using System.Collections.Generic;
using System.Text;

namespace S3.Polymorfi.Entities
{
    public abstract class Employee : Entity, IPayable
    {
        protected string name;

        public Employee(int id,string name)
            :base(id)
        {
            Name = name;
        }

        public Employee(string name)
            :this(default, name)
        {

        }

        public Employee()
        {

        }


        public string Name { get => name; set => name = value; }

        public abstract decimal Earnings();
        public decimal GetPaymentAmount()
        {
            decimal earnings = Earnings();
            return earnings - ((earnings / 100) * 15);
        }
    }
}
