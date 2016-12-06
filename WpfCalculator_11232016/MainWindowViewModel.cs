using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCalculator;

namespace WpfCalculator_11232016
{
   class MainWindowViewModel
   {
      private double _currentResult;
      private readonly ICalculator _calculator;

      public MainWindowViewModel( ICalculator calculator )
      {
         _calculator = calculator;
         _currentResult = 0;
      }

      public void SetCurrentOperation( string content )
      {
         _calculator.SetCurrentOperation( content );
      }
   }
}
