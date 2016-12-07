using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MyCalculator;
using MyCalculator.Operations;
using FluentAssertions;

namespace MyCalculatorTests
{
   [TestClass]
   public class CalculatorTests
   {
      [TestMethod]
      public void Calculation_CallsMathStrategy_ReturnsResult()
      {
         var mockMathStrategy = new Mock<IMathStrategy>();
         var calculator = new Calculator();

         mockMathStrategy.Setup( x => x.Calculate( 1.1, 2.2 ) ).Returns( 12 );

         calculator.SetCurrentNumber( 1.1 );
         calculator.SetCurrentOperation( mockMathStrategy.Object );
         calculator.SetCurrentNumber( 2.2 );
         calculator.GetCurrentResult().Should().Be( 12 );
      }
   }
}
