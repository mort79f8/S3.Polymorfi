using S3.Polymorfi.Entities;
using System;
using System.Collections.Generic;
using Xunit;

namespace S3.Polymorfi.EntitiesTest
{
    public class InvoiceTest
    {
        List<Product> fruit = new List<Product>();
        List<Product> cars = new List<Product>();
        List<Product> pop = new List<Product>();
        public InvoiceTest()
        {
            Product product1 = new Product()
            {
                Name = "æble",
                Price = 3,
                Quantity = 30
            };
            Product product2 = new Product()
            {
                Name = "pære",
                Price = 4,
                Quantity = 10
            };
            Product product3 = new Product()
            {
                Name = "banan",
                Price = 2,
                Quantity = 15
            };
            fruit.Add(product1);
            fruit.Add(product2);
            fruit.Add(product3);

            Product car1 = new Product()
            {
                Name = "lada",
                Price = 120_000,
                Quantity = 3
            };
            Product car2 = new Product()
            {
                Name = "toyota",
                Price = 250_000,
                Quantity = 4
            };
            Product car3 = new Product()
            {
                Name = "skoda",
                Price = 95_000,
                Quantity = 10
            };
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);

            Product pop1 = new Product()
            {
                Name = "Coca-Cola",
                Price = 18,
                Quantity = 12
            };
            Product pop2 = new Product()
            {
                Name = "squash",
                Price = 20,
                Quantity = 10
            };
            Product pop3 = new Product()
            {
                Name = "Harbo gude drink",
                Price = 9,
                Quantity = 3
            };
            pop.Add(pop1);
            pop.Add(pop2);
            pop.Add(pop3);
        }


        [Fact]
        public void GetPaymentAmount_fruit()
        {
            //Arrange
            Invoice invoice = new Invoice(fruit);
            decimal expectedAmount = 0;
            foreach (Product product in fruit)
            {
                expectedAmount += product.Price * product.Quantity;
            }

            //Act
            decimal actualAmount = invoice.GetPaymentAmount();

            //Assert
            Assert.Equal(expectedAmount, actualAmount);
        }

        [Fact]
        public void GetPaymentAmount_cars()
        {
            //Arrange
            Invoice invoice = new Invoice(cars);
            decimal expectedAmount = 0;
            foreach (Product product in cars)
            {
                expectedAmount += product.Price * product.Quantity;
            }

            //Act
            decimal actualAmount = invoice.GetPaymentAmount();

            //Assert
            Assert.Equal(expectedAmount, actualAmount);
        }

        [Fact]
        public void GetPaymentAmount_pop()
        {
            //Arrange
            Invoice invoice = new Invoice(pop);
            decimal expectedAmount = 0;
            foreach (Product product in pop)
            {
                expectedAmount += product.Price * product.Quantity;
            }

            //Act
            decimal actualAmount = invoice.GetPaymentAmount();

            //Assert
            Assert.Equal(expectedAmount, actualAmount);
        }
    }
}
