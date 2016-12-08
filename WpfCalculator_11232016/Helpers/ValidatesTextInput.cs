namespace WpfCalculator_11232016.Helpers
{
   public static class ValidatesTextInput
   {
      public static bool IsValidForCalculator( string textToValidate )
      {
         int temp;
         return int.TryParse( textToValidate, out temp );
      }
   }
}
