using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfCalculator_11232016;
using FluentAssertions;
using WpfCalculator_11232016.Helpers;

namespace WpfCalculator_11232016_Tests.UnitTests
{
   [TestClass]
   public class AppendsToDisplayedValueTests
   {
      [TestMethod]
      public void Append_DisplayedValueWasZero_ReplacesDisplayedeValue()
      {
         string displayedValue = "0";
         string numberToAppend = "1";
         AppendsToDisplayedValue.Append( displayedValue, numberToAppend ).Should().Be( "1" );
      }

      [TestMethod]
      public void Apped_DisplayedValueWasNotZero_AppendsValueToString()
      {
         string displayedValue = "1";
         string numberToAppend = "1";
         AppendsToDisplayedValue.Append( displayedValue, numberToAppend ).Should().Be( "11" );
      }
   }
}
