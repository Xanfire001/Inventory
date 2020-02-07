using System;
using System.Collections.Generic;
using System.Text;
using Inventar_Verwaltung.BLL;
using Xunit;

namespace Inventar_Verwaltung.BLL.Test
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4,3,3)]
        [InlineData(21,5.25,26.25)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange   

            // Act
            double actual = Calculator.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
            
        }

        [Theory]
        [InlineData(8,4,2)]
        public void Divide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            double actual = Calculator.Divide(x, y);

            Assert.Equal(expected, actual);
        }
    }
}
