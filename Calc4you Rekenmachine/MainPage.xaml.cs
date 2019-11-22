using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Calc4you_Rekenmachine
{
    

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        #region Nummer van rekenmachine.
        /// <summary>
        /// Laat de cijfers zien in de textbox achter elkaar.
        /// </summary>
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "1";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "2";
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "3";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "4";
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "5";
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "6";
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "7";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "8";
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "9";
        }
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "0";
        }
        #region punt of komma en procenten onder de cijfer van rekenmachine.
        /// <summary>
        /// Laat de punt en komma zien en laat de gebruiker alleen een keer gebruiken.
        /// </summary>

        private void ButtonPunt_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += ",";
            buttonPunt.IsEnabled = false;
        }
        private void ButtonProcent_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "%";
            buttonProcent.IsEnabled = false;
        }
        #endregion
        #endregion
        #region Delete en undo.
        /// <summary>
        /// Clear knop waar je alles mee kan gaan delete.
        /// </summary>
        private void Name_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "";
            buttonPunt.IsEnabled = true;
            buttonProcent.IsEnabled = true;
        }
        #endregion

        public void ButtonEuroDollar(object sender, RoutedEventArgs e)
        {
            
         try
            {
                public static string _bedragInEuro = TextBox.Text;




    }
            catch
            {

            }
           
        }
    }
}
    
