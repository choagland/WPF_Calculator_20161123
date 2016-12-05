namespace WpfCalculator_11232016.Helpers
{
   public static class AppendsToDisplayedValue
   {
      public static string Append( string displayedValue, string numberToAppend )
      {
         if ( displayedValue == "0" )
            return numberToAppend;
         if ( numberToAppend == "C" )
            return "0";

         return displayedValue + numberToAppend;
      }
   }
}
