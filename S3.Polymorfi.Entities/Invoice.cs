using System;
using System.Collections.Generic;
using System.Text;

namespace S3.Polymorfi.Entities
{
    public class Invoice : Entity, IPayable
    {
        #region Fields
        private List<Product> products;
        #endregion

        #region Constructors
        public Invoice(int id, List<Product> products)
            :base(id)
        {
            Products = products;
        }

        public Invoice(List<Product> products)
            : this(default, products) { }
        #endregion

        #region Properties
        public List<Product> Products { get => products; set => products = value; }
        #endregion

        #region Methods
        public decimal GetPaymentAmount()
        {
            decimal totalPrice = 0;

            foreach (Product product in Products)
            {
                totalPrice += product.Price;
            }

            return totalPrice;
        }
        #endregion
    }
}
