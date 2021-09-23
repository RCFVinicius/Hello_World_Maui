using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;

namespace MauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = "Hello World";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
    }
}
