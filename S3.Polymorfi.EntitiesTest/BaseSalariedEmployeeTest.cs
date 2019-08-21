using S3.Polymorfi.Entities;
using System;
using Xunit;

namespace S3.Polymorfi.EntitiesTest
{
    public class BaseSalariedEmployeeTest
    {
        [Fact]
        public void Earnings_returnsSalary()
        {
            // Arrange
            BaseSalariedEmployee employee = new BaseSalariedEmployee();
            employee.Salary = 15_000;

            //Act
            decimal ActualEarning = employee.Earnings();

            //Assert
            Assert.Equal(employee.Salary, ActualEarning);
        }

        [Fact]
        public void GetPaymentAmount_GetsEarningMinus15Percent()
        {
            //Arrange
            BaseSalariedEmployee employee = new BaseSalariedEmployee();
            employee.Salary = 15_000;
            decimal expectedPaymentAmount = employee.Salary - ((employee.Salary / 100) * 15);

            //Act
            decimal actualPaymentAmount = employee.GetPaymentAmount();

            //Assert
            Assert.Equal(expectedPaymentAmount, actualPaymentAmount);
        }

        [Theory]
        [InlineData("Jens", 20_000)]
        [InlineData("Line", 25_000)]
        [InlineData("Kalle", 12_000)]
        [InlineData("Tom", 31_000)]
        [InlineData("Hans", 19_000)]
        public void GetPaymentAmount_GetsEarningminus15PercentForAll(string name, decimal salary)
        {
            //Arrange
            BaseSalariedEmployee employee = new BaseSalariedEmployee() { Name = name, Salary = salary };
            decimal expectedPaymentAmount = employee.Salary - ((employee.Salary / 100) * 15);

            //Act
            decimal actualPaymentAmount = employee.GetPaymentAmount();

            //Assert
            Assert.Equal(expectedPaymentAmount, actualPaymentAmount);
        }
    }
}
