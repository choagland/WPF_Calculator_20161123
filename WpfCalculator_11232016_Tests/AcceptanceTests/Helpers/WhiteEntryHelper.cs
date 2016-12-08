using TestStack.White;
using WpfCalculator_11232016_Tests.AcceptanceTests.WindowObjects;

namespace WpfCalculator_11232016_Tests.AcceptanceTests.Helpers
{
   class WhiteEntryHelper
   {
      private Application _application;

      public WhiteEntryHelper( Application application )
      {
         _application = application;
      }

      public void PushButton( string buttonValue )
      {
         var calculatorWindow = new WpfCalculatorWindow( _application );
         calculatorWindow.PushButton( buttonValue );
      }

      public void PressKey( string keyPressed )
      {
         var calculatorWindow = new WpfCalculatorWindow( _application );
         calculatorWindow.TypeKey( keyPressed );
      }
   }
}
