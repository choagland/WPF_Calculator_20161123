using TechTalk.SpecFlow;
using TestStack.White;

namespace WpfCalculator_11232016_Tests.AcceptanceTests.Hooks
{
   [Binding]
   public sealed class ScenarioTearDown
   {
      // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

      [BeforeScenario]
      public void BeforeScenario()
      {
         //TODO: implement logic that has to run before executing each scenario
      }

      [AfterScenario]
      public void AfterScenario()
      {
         var application = ScenarioContext.Current.Get<Application>( "subject" );
         application.Close();
      }
   }
}
