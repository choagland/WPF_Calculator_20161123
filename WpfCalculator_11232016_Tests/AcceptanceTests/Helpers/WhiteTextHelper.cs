using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.WindowsAPI;
using WpfCalculator_11232016_Tests.AcceptanceTests.WindowObjects;

namespace WpfCalculator_11232016_Tests.AcceptanceTests.Helpers
{
   class WhiteTextHelper
   {
      public static string DisplayedValue( Application calculator )
      {
         var calculatorWindow = new WpfCalculatorWindow( calculator );
         return calculatorWindow.DisplayedValue();
      }
   }
}
