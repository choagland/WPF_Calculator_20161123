using Microsoft.VisualStudio.TestTools.UnitTesting;
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
      public void Append_DisplayedValueWasNotZero_AppendsValueToString()
      {
         string displayedValue = "1";
         string numberToAppend = "1";
         AppendsToDisplayedValue.Append( displayedValue, numberToAppend ).Should().Be( "11" );
      }

      [TestMethod]
      public void Append_NumberToAppendIsTheClearButton_DisplayedValueIsZero()
      {
         string displayedValue = "1";
         string numbertoAppend = "C";
         AppendsToDisplayedValue.Append( displayedValue, numbertoAppend ).Should().Be( "0" );
      }

   }
}
