using System;

using Windows.UI.Xaml.Controls;

using WtsPrism_v20.ViewModels;

namespace WtsPrism_v20.Views
{
    public sealed partial class TabbedPage : Page
    {
        private TabbedViewModel ViewModel => DataContext as TabbedViewModel;

        public TabbedPage()
        {
            InitializeComponent();
        }
    }
}
