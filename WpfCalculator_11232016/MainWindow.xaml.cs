using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfCalculator_11232016.Helpers;

namespace WpfCalculator_11232016
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      private string _currentValue;
      private MainWindowViewModel _mainWindowViewModel;
      public MainWindow()
      {
         InitializeComponent();
         _currentValue = "0";
         DisplayedValue.Text = _currentValue;
         _mainWindowViewModel = new MainWindowViewModel( new MyCalculator.Calculator() );
      }

      private void GridNumberButtons_OnClick( object sender, RoutedEventArgs e )
      {
         var numberButton = e.Source as Button;
         if ( numberButton != null )
         {
            AppendButtonValueToCurrentNumerend( (string) numberButton.Content );
         }
      }

      private void AppendButtonValueToCurrentNumerend( string numberToAppend )
      {
         _currentValue = AppendsToDisplayedValue.Append( _currentValue, numberToAppend );
         DisplayedValue.Text = _currentValue; //this seems dumb but I don't know what to do about it yet
      }

      private void MainWindow_OnTextInput( object sender, TextCompositionEventArgs e )
      {
         AppendButtonValueToCurrentNumerend( e.Text );
      }

      private void GridOperationButtons_OnClick( object sender, RoutedEventArgs e )
      {
         var operationButton = e.Source as Button;
         _mainWindowViewModel.SetCurrentNumber( _currentValue );
         _mainWindowViewModel.SetCurrentOperation( (string) operationButton.Content );
         _currentValue = "0";
      }

      private void EqualsButton_OnClick( object sender, RoutedEventArgs e )
      {
         _mainWindowViewModel.SetCurrentNumber( _currentValue );
         _currentValue = _mainWindowViewModel.GetCurrentResult().ToString( CultureInfo.InvariantCulture );
         DisplayedValue.Text = _currentValue;
         _currentValue = "0";
      }
   }
}
