using System;
using System.Diagnostics;
using System.Net;
using MyCalculator.Operations;

namespace MyCalculator.Operations
{
   public static class MathStrategyFactory
   {
      public static IMathStrategy SelectMathStrategy( Operation operation )
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

      public static IMathStrategy SelectMathStrategy( string strategySelection )
      {
         switch ( strategySelection )
         {
            case ( "+" ):
            {
               return SelectMathStrategy(Operation.Add);
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
