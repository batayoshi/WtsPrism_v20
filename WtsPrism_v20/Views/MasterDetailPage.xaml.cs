using System;

using Windows.UI.Xaml.Controls;

using WtsPrism_v20.ViewModels;

namespace WtsPrism_v20.Views
{
    public sealed partial class MasterDetailPage : Page
    {
        private MasterDetailViewModel ViewModel => DataContext as MasterDetailViewModel;

        public MasterDetailPage()
        {
            InitializeComponent();
        }
    }
}
