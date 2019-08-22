using System;
using System.Collections.Generic;
using System.Text;

namespace S3.Polymorfi.Entities
{
    public interface IPayable
    {
        decimal GetPaymentAmount();
    }
}
