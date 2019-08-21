using System;
using System.Collections.Generic;
using System.Text;

namespace S3.Polymorfi.Entities
{
    public class Product: Entity
    {
        #region Fields
        private string name;
        private decimal price;
        private int quantity;
        #endregion

        #region Constructor
        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public Product()
        {

        }
        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        #endregion
    }
}
