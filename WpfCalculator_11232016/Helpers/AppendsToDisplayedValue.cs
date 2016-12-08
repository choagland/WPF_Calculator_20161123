namespace WpfCalculator_11232016.Helpers
{
   public static class AppendsToDisplayedValue
   {
      public static string Append( string displayedValue, string stringToAppend )
      {
         if ( stringToAppend == "." )
            return AppendADecimal( displayedValue );
         if ( displayedValue == "0" )
            return stringToAppend;
         if ( stringToAppend == "C" )
            return "0";

         if ( ValidatesTextInput.IsValidForCalculator( stringToAppend ) )
         {
            return displayedValue + stringToAppend;
         }
         return displayedValue;
      }

      private static string AppendADecimal( string displayedValue )
      {
         if ( displayedValue.Contains(".") )
         {
            return displayedValue;
         }
         return displayedValue + ".";
      }
   }
}