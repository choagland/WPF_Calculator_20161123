using System;
using System.Collections.Generic;
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
      private string _displayedValue;
      public MainWindow()
      {
         InitializeComponent();
         _displayedValue = "0";
         DisplayedValue.Text = _displayedValue;
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
         _displayedValue = AppendsToDisplayedValue.Append( _displayedValue, numberToAppend );
         DisplayedValue.Text = _displayedValue; //this seems dumb but I don't know what to do about it yet
      }

      private void MainWindow_OnTextInput( object sender, TextCompositionEventArgs e )
      {
         AppendButtonValueToCurrentNumerend( e.Text );
      }
   }
}
