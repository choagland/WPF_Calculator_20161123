using System;

namespace MyCalculator.Operations
{
   public class MathStrategyFactory
   {
      public IMathStrategy SelectMathStrategy( Operation operation )
      {
         switch ( operation )
         {
            case Operation.InitialState:
            {
               return new InitialMathStrategy();
            }
            case Operation.Add:
            {
               return new AdditionStrategy();
            }
            default:
            {
               throw new NotImplementedException();
            }
         }
      }
   }

   public class InitialMathStrategy : IMathStrategy
   {
      public double Calculate( double x, double y )
      {
         return y;
      }
   }

   public class AdditionStrategy: IMathStrategy
   {
      public double Calculate( double x, double y )
      {
         return x + y;
      }
   }
}
