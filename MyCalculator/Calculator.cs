using System;
using MyCalculator.Operations;

namespace MyCalculator
{
    public class Calculator : ICalculator
    {
       public double GetCurrentResult()
       {
          throw new NotImplementedException();
       }

       public void SetCurrentNumber( double number )
       {
          throw new NotImplementedException();
       }

       public void SetCurrentOpetation( Operation operation )
       {
          throw new NotImplementedException();
       }
    }
}
