using S3.Polymorfi.Entities;
using System;
using Xunit;
using System.Collections.Generic;
namespace S3.Polymorfi.EntitiesTest
{
    public class GetPaymentAmountInterfaceTest
    {
        List<IPayable> payables = new List<IPayable>();
        List<Product> fruit = new List<Product>();
        List<Product> cars = new List<Product>();
        List<Product> pop = new List<Product>();

        public decimal GetTotalPaymentAmount(List<IPayable> iPayables)
        {
            decimal total = 0;
            foreach (IPayable payable in iPayables)
            {
                total += payable.GetPaymentAmount();
            }

            return total;
        }

        
        public GetPaymentAmountInterfaceTest()
        {

            // invoice
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

            Invoice invoice1 = new Invoice(fruit);
            Invoice invoice2 = new Invoice(cars);
            Invoice invoice3 = new Invoice(pop);
            
            payables.Add(invoice1);
            payables.Add(invoice2);
            payables.Add(invoice3);

            // BaseSalarieEmployee
            BaseSalariedEmployee employee1 = new BaseSalariedEmployee()
            {
                Name = "Jens",
                Salary = 15_000
            };
            BaseSalariedEmployee employee2 = new BaseSalariedEmployee()
            {
                Name = "Hans",
                Salary = 25_000
            };
            BaseSalariedEmployee employee3 = new BaseSalariedEmployee()
            {
                Name = "Line",
                Salary = 20_000
            };
            BaseSalariedEmployee employee4 = new BaseSalariedEmployee()
            {
                Name = "Klaus",
                Salary = 40_000
            };
            BaseSalariedEmployee employee5 = new BaseSalariedEmployee()
            {
                Name = "Lise",
                Salary = 37_000
            };

            payables.Add(employee1);
            payables.Add(employee2);
            payables.Add(employee3);
            payables.Add(employee4);
            payables.Add(employee5);

            SalesRepresentative representative1 = new SalesRepresentative()
            {
                Name = "Jens",
                Salary = 15_000,
                WeeklySales = 20_000,
                CommisionRate = 0.10
            };

            SalesRepresentative representative2 = new SalesRepresentative()
            {
                Name = "Line",
                Salary = 25_000,
                WeeklySales = 24_000,
                CommisionRate = 0.12
            };

            SalesRepresentative representative3 = new SalesRepresentative()
            {
                Name = "Klaus",
                Salary = 27_000,
                WeeklySales = 28_000,
                CommisionRate = 0.09
            };

            SalesRepresentative representative4 = new SalesRepresentative()
            {
                Name = "Helene",
                Salary = 35_000,
                WeeklySales = 45_000,
                CommisionRate = 0.15
            };

            SalesRepresentative representative5 = new SalesRepresentative()
            {
                Name = "Hans",
                Salary = 55_000,
                WeeklySales = 120_000,
                CommisionRate = 0.16
            };

            payables.Add(representative1);
            payables.Add(representative2);
            payables.Add(representative3);
            payables.Add(representative4);
            payables.Add(representative5);

        }

        [Fact]
        public void GetTotalPaymentAmount_ShouldBeEqual()
        {
            //Arrange
            decimal expectedTotalAmount = 0;
            foreach (IPayable payable in payables)
            {
                expectedTotalAmount += payable.GetPaymentAmount();
            }

            //Act
            decimal acutalTotalAmount = GetTotalPaymentAmount(payables);

            //Assert
            Assert.Equal(expectedTotalAmount, acutalTotalAmount);
        }

    }
}
