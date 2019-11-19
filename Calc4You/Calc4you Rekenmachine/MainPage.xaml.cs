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
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = "1";
            }
            else
            {
                TextBox.Text = TextBox.Text + "1";
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = "2";
            }
            else
            {
                TextBox.Text = TextBox.Text + "2";
            }
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = "3";
            }
            else
            {
                TextBox.Text = TextBox.Text + "3";
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = "4";
            }
            else
            {
                TextBox.Text = TextBox.Text + "4";
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = "5";
            }
            else
            {
                TextBox.Text = TextBox.Text + "5";
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = "6";
            }
            else
            {
                TextBox.Text = TextBox.Text + "6";
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = "7";
            }
            else
            {
                TextBox.Text = TextBox.Text + "7";
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = "8";
            }
            else
            {
                TextBox.Text = TextBox.Text + "8";
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = "9";
            }
            else
            {
                TextBox.Text = TextBox.Text + "9";
            }
        }
        private void button0_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = "0";
            }
            else
            {
                TextBox.Text = TextBox.Text + "0";
            }
        }
        #region punt en komma onder de cijfer van rekenmachine.
        private void buttonPunt_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "0" && TextBox.Text != null)
            {
                TextBox.Text = ",";
            }
            else
            {
                TextBox.Text = TextBox.Text + ",";
            }
        }
        #endregion
        #endregion

        private void name_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "0";
        }

        private void buttonProcent_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
