using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using WtsPrism_v20.Models;

namespace WtsPrism_v20.Services
{
    public interface ISampleDataService
    {
        ObservableCollection<DataPoint> GetChartSampleData();

        ObservableCollection<SampleImage> GetGallerySampleData();

        Task<IEnumerable<SampleOrder>> GetSampleModelDataAsync();
    }
}
