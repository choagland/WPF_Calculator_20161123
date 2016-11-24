using TechTalk.SpecFlow;
using FluentAssertions;
using TestStack.White;
using WpfCalculator_11232016_Tests.AcceptanceTests.Helpers;

namespace WpfCalculator_11232016_Tests.AcceptanceTests.StepDefinitions
{
   [Binding]
   public sealed class CalculatorSteps
   {
      [Given( @"I have launched the calculator" )]
      public void GivenIHaveLaunchedTheCalculator()
      {
         Application calculator = WhiteApplicationHelper.LaunchAndGetReferenceToApplication();
         ScenarioContext.Current.Add( "subject", calculator );
      }

      [Then( @"the calculators window title is ""(.*)""" )]
      public void ThenTheCalculatorsWindowTitleIs( string name )
      {
         var calculator = ScenarioContext.Current.Get<Application>("subject");
         calculator.GetWindows()[0].Title.Should().Be( name );
      }

      [Then( @"the displayed value is ""(.*)""" )]
      public void ThenTheDisplayedValueIs( int expectedValue )
      {
         var calculator = ScenarioContext.Current.Get<Application>( "subject" );
         //WhiteTextHelper.DisplayedValue( calculator ).Should().Be( 0 );
         ScenarioContext.Current.Pending();
      }


   }
}
