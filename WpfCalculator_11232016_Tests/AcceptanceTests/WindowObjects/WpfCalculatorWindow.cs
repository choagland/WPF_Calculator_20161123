﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WPFUIItems;

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
         var numberButton = (Button) _window.Get( SearchCriteria.ByText( buttonValue ) );
         numberButton.Click();
      }
   }
}
