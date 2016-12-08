using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfCalculator_11232016.Helpers;

namespace WpfCalculator_11232016_Tests.UnitTests
{
   [TestClass]
   public class ValidatesTextInputTests
   {
      [TestMethod]
      public void Validate_Numbers_AllAreValid()
      {
         var allTheNumbers = new List<string>
         {
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
         };

         foreach ( var number in allTheNumbers )
         {
            ValidatesTextInput.IsValidForCalculator( number ).Should().BeTrue();
         }
      }

      [TestMethod]
      public void Validate_LettersThatShouldBeDisallowed_AllAreInvalid()
      {
         var lettersThatShouldBeDisallowed = new List<string>
         {
            "a", "b", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "m", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
         };

         foreach ( var letter in lettersThatShouldBeDisallowed )
         {
            ValidatesTextInput.IsValidForCalculator( letter ).Should().BeFalse();
         }
      }
   }
}
