using AdaptiveDMI.Core.Models;

namespace AdaptiveDMI.Core.Contracts.Services;

public interface ISampleDataService
{
    Task<IEnumerable<SampleOrder>> GetListDetailsDataAsync();
}
