using S3.Polymorfi.Entities;
using System;
using Xunit;

namespace S3.Polymorfi.EntitiesTest
{
    public class SalesRepresentativeTest
    {
        [Fact]
        public void Earnings_returnsSalary()
        {
            // Arrange
            SalesRepresentative employee = new SalesRepresentative();
            employee.Salary = 15_000;
            employee.CommisionRate = 0.10;
            employee.WeeklySales = 45_000;
            decimal expectedEarning = employee.Salary + (employee.WeeklySales * (decimal)employee.CommisionRate);

            //Act
            decimal ActualEarning = employee.Earnings();

            //Assert
            Assert.Equal(ActualEarning, expectedEarning);
        }

        [Fact]
        public void GetPaymentAmount_GetsEarningMinus15Percent()
        {
            // Arrange
            SalesRepresentative employee = new SalesRepresentative();
            employee.Salary = 15_000;
            employee.CommisionRate = 0.10;
            employee.WeeklySales = 45_000;
            decimal expectedPaymentAmount = employee.Earnings() - ((employee.Earnings() / 100) * 15);

            //Act
            decimal actualPaymentAmount = employee.GetPaymentAmount();

            //Arrange
            Assert.Equal(expectedPaymentAmount, actualPaymentAmount);

        }

        [Theory]
        [InlineData("Jens", 20_000, 45_000, 0.10)]
        [InlineData("Line", 25_000, 50_000, 0.10)]
        [InlineData("Kalle", 12_000, 20_000, 0.05)]
        [InlineData("Tom", 31_000, 65_000, 0.12)]
        [InlineData("Hans", 19_000, 25_000, 0.07)]
        public void GetPaymentAmount_GetsEarningminus15PercentForAll(string name, decimal salary, decimal weeklySales, double commisionRate)
        {
            //Arrange
            SalesRepresentative employee = new SalesRepresentative()
            {
                Name = name,
                Salary = salary,
                WeeklySales = weeklySales,
                CommisionRate = commisionRate
            };
            decimal expectedPaymentAmount = (employee.Salary + (weeklySales * (decimal)commisionRate)) - ((employee.Salary + (weeklySales * (decimal)commisionRate)) / 100) * 15;

            //Act
            decimal actualPaymentAmount = employee.GetPaymentAmount();

            //Assert
            Assert.Equal(expectedPaymentAmount, actualPaymentAmount);
        }
    }

}
