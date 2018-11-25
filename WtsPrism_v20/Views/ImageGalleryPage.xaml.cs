using System;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using WtsPrism_v20.ViewModels;

namespace WtsPrism_v20.Views
{
    public sealed partial class ImageGalleryPage : Page
    {
        private ImageGalleryViewModel ViewModel => DataContext as ImageGalleryViewModel;

        public ImageGalleryPage()
        {
            InitializeComponent();
        }

        private async void GridView_Loaded(object sender, RoutedEventArgs e)
        {
            var gridView = sender as GridView;
            await ViewModel.LoadAnimationAsync(gridView);
        }
    }
}
