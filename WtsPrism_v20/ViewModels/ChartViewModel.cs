using System;
using System.Collections.ObjectModel;

using Prism.Windows.Mvvm;

using WtsPrism_v20.Models;
using WtsPrism_v20.Services;

namespace WtsPrism_v20.ViewModels
{
    public class ChartViewModel : ViewModelBase
    {
        private readonly ISampleDataService _sampleDataService;

        public ChartViewModel(ISampleDataService sampleDataServiceInstance)
        {
            _sampleDataService = sampleDataServiceInstance;
        }

        public ObservableCollection<DataPoint> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return _sampleDataService.GetChartSampleData();
            }
        }
    }
}
