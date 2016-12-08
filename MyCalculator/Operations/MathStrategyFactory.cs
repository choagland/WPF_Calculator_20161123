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
            case Operation.Subtract:
            {
               return new SubtractionStrategy();
            }
            case Operation.Multiply:
            {
               return new MultiplicationStrategy();
            }
            case Operation.Divide:
            {
               return new DivisionStrategy();
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
            case ( "-" ):
            {
               return SelectMathStrategy( Operation.Subtract );
            }
            case ( "*" ):
            {
               return SelectMathStrategy( Operation.Multiply );
            }
            case ( "/" ):
            {
               return SelectMathStrategy( Operation.Divide );
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

   public class SubtractionStrategy : IMathStrategy
   {
      public double Calculate( double x, double y )
      {
         return x - y;
      }
   }

   public class MultiplicationStrategy : IMathStrategy
   {
      public double Calculate( double x, double y )
      {
         return x * y;
      }
   }

   public class DivisionStrategy : IMathStrategy
   {
      public double Calculate( double x, double y )
      {
         return x / y;
      }
   }
}
