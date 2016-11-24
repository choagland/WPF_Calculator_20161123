using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace WpfCalculator_11232016_Tests.AcceptanceTests.WindowObjects
{
   class WpfCalculatorWindow
   {
      private Application _application;
      private Window _window;

      public WpfCalculatorWindow( Application application )
      {
         _application = application;
         _window = application.GetWindows()[0];
      }

      public string DisplayedValue()
      {
         WPFLabel displayedValue =  (WPFLabel) _window.Get( SearchCriteria.ByAutomationId( "DisplayedValue" ) );
         return displayedValue.Text;
      }
   }
}
