using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DecompositionPowersThree.structure;

namespace DecompositionPowersThree.windows
{
    /// <summary>
    /// Interaction logic for Decompose.xaml
    /// </summary>
    public partial class Decompose : Window
    {
        private int inputInteger;
        public bool IsWindowClosed;

        public Decompose()
        {
            // Intialize instance variables
            this.inputInteger = 0;
            this.IsWindowClosed = false;

            InitializeComponent();

        }

        protected override void OnClosed(EventArgs e)
        {
            // Call parent class method
            base.OnClosed(e);

            // Update boolean
            this.IsWindowClosed = true;
        }

        private void Decompose_Decomposition_Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Not needed, as this field is Read-Only
        }

        private void Decompose_Message_Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Not needed, as this field is Read-Only
        }

        private void Decompose_Integer_Input_Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Whenever the input value is changed
            // Decompose button should be enabled
            // Message should be erased
            Decompose_Decompose_Button.IsEnabled = true;
            Decompose_Message_Box.Text = "";

            // Convert the input Integer for decomposition process, or display appropriate error msg
            try
            {
                this.inputInteger = Convert.ToInt32(Decompose_Integer_Input_Box.Text);

                // Handle situation where input is greater than 121
                if (this.inputInteger > 121)
                {
                    Decompose_Decompose_Button.IsEnabled = false;

                    Decompose_Message_Box.Foreground = Brushes.Red;
                    Decompose_Message_Box.Text = "Input Integer is greater than 121, Please input integer in [-121, 121] range";
                }
                // Handle situation where input is lesser than -121
                else if (this.inputInteger < -121)
                {
                    Decompose_Decompose_Button.IsEnabled = false;

                    Decompose_Message_Box.Foreground = Brushes.Red;
                    Decompose_Message_Box.Text = "Input Integer is lesser than -121, Please input integer in [-121, 121] range";
                }
            }
            catch (Exception)
            {
                // Exclude situation, where input is empty or '-' sign or '+' sign
                if (Decompose_Integer_Input_Box.Text == "") return;
                if (Decompose_Integer_Input_Box.Text == "-") return;
                if (Decompose_Integer_Input_Box.Text == "+") return;

                // Disable Decompose button
                Decompose_Decompose_Button.IsEnabled = false;

                // Display the appropriate message
                Decompose_Message_Box.Foreground = Brushes.Red;
                Decompose_Message_Box.Text = "Please enter an Integer, not alphabets or special characters!!";
            }
        }

        private void Decompose_Decompose_Button_Click(object sender, RoutedEventArgs e)
        {
            // If the input is empty or zero, handle the situation
            if ((Decompose_Integer_Input_Box.Text == "") | (Decompose_Integer_Input_Box.Text == "0"))
            {
                Decompose_Decompose_Button.IsEnabled = false;

                Decompose_Message_Box.Foreground = Brushes.Red;
                Decompose_Message_Box.Text = "Please input non-zero integer in [-121, 121] range";
                return;
            }
            
            // Freeze the input integer field
            Decompose_Integer_Input_Box.IsReadOnly = true;

            // Call Decomposer for decomposition
            string decomposer = Decomposer.GetTheDecomposition(inputNumber: this.inputInteger);

            // Display decomposition in the relevant box
            Decompose_Decomposition_Box.Text = decomposer;

            // Display the appropriate message
            Decompose_Message_Box.Foreground = Brushes.Green;
            Decompose_Message_Box.Text = "Decomposition is complete!!";

        }

        private void Decompose_Repeat_Button_Click(object sender, RoutedEventArgs e)
        {
            Decompose_Decompose_Button.IsEnabled = true;

            Decompose_Integer_Input_Box.Text = "";
            Decompose_Integer_Input_Box.IsReadOnly = false;

            Decompose_Decomposition_Box.Text = "";

            Decompose_Message_Box.Text = "";
        }
    }
}
