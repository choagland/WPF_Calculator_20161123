using TestStack.White;

namespace WpfCalculator_11232016_Tests.AcceptanceTests.Helpers
{
   class WhiteApplicationHelper
   {
      public static Application LaunchAndGetReferenceToApplication()
      {
         var application = Application.Launch( @"D:\Projects\Git\WPF_Calculator_20161123\WpfCalculator_11232016\bin\Debug\WpfCalculator_11232016.exe" );
         return application;
      }
   }
}
