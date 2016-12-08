using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace WpfCalculator_11232016_Tests.AcceptanceTests.WindowObjects
{
   class WpfCalculatorWindow
   {
      private readonly Window _window;

      public WpfCalculatorWindow( Application application )
      {
         _window = application.GetWindows()[0];
      }

      public string DisplayedValue()
      {
         var displayedValue =  (WPFLabel) _window.Get( SearchCriteria.ByAutomationId( "DisplayedValue" ) );
         return displayedValue.Text;
      }

      public void PushButton( string buttonValue )
      {
         var button = (Button) _window.Get( SearchCriteria.ByText( buttonValue ) );
         button.Click();
      }

      public void TypeKey( string keyPressed )
      {
         _window.Focus();
         _window.Keyboard.Enter( keyPressed );
      }
   }
}
