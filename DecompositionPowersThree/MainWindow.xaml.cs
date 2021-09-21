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
using DecompositionPowersThree.windows;

namespace DecompositionPowersThree
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool IsAboutOpen;
        private bool IsDecomposeOpen;
        private About aboutWindow;
        private Decompose decomposeWindow;

        public MainWindow()
        {
            InitializeComponent();

            // Initialize instance variables
            this.IsAboutOpen = false;
            this.IsDecomposeOpen = false;
            this.aboutWindow = new About();
            this.decomposeWindow = new Decompose();
        }

        protected override void OnClosed(EventArgs e)
        {
            // Call parent class method
            base.OnClosed(e);

            // Shutdown app to close all windows
            Application.Current.Shutdown();
        }

        private void Decompose_Click(object sender, RoutedEventArgs e)
        {
            // If Decompose window is closed, create instance of it for displaying
            if (this.decomposeWindow.IsWindowClosed)
            {
                this.IsDecomposeOpen = false;
                this.decomposeWindow = new Decompose();
            }

            // If Decompose window is not open at all, just display it
            if (!this.IsDecomposeOpen)
            {
                this.decomposeWindow.Show();
                this.IsDecomposeOpen = true;
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            // Execute close function
            Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            // If About window is closed, create instance of it for displaying
            if (this.aboutWindow.IsWindowClosed)
            {
                this.IsAboutOpen = false;
                this.aboutWindow = new About();
            }

            // If About window is not open at all, just display it
            if (!this.IsAboutOpen)
            {
                this.aboutWindow.Show();
                this.IsAboutOpen = true;
            }

        }

        private void Instructions_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Not needed, as this field is Read-Only
        }

    }

}
