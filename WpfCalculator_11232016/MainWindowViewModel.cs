using MyCalculator;
using MyCalculator.Operations;

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
         _calculator.SetCurrentOperation( MathStrategyFactory.SelectMathStrategy( content ) );
      }

      public void SetCurrentNumber( string number )
      {
         double parsedNumber;
         double.TryParse( number, out parsedNumber );
         _calculator.SetCurrentNumber( parsedNumber );
      }

      public double GetCurrentResult()
      {
         return _calculator.GetCurrentResult();
      }
   }
}
