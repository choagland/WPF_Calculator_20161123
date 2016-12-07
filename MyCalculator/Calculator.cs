using MyCalculator.Operations;

namespace MyCalculator
{
   public class Calculator : ICalculator
   {
      private IMathStrategy _mathStrategy;
      private double _currentResult;

      public Calculator()
      {
         _currentResult = 0;
         _mathStrategy = MathStrategyFactory.SelectMathStrategy( Operation.InitialState );
      }

      public double GetCurrentResult()
      {
         return _currentResult;
      }

      public void SetCurrentNumber( double number )
      {
         _currentResult = _mathStrategy.Calculate( _currentResult, number );
      }

      public void SetCurrentOperation( IMathStrategy mathStrategy )
      {
         _mathStrategy = mathStrategy;
      }
   }
}
