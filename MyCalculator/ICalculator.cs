﻿using MyCalculator.Operations;

namespace MyCalculator
{
   public interface ICalculator
   {
      double GetCurrentResult();
      void SetCurrentNumber( double number );
      void SetCurrentOperation( IMathStrategy mathStrategy );
   }
}