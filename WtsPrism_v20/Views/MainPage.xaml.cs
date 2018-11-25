using System;

using Windows.UI.Xaml.Controls;

using WtsPrism_v20.ViewModels;

namespace WtsPrism_v20.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
