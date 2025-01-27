using TFDealFinder.Core.Models;
namespace TFDealFinder.App.API;

public interface IBPApi
{
    public Task<List<HistoryEntry>> BPPrice(string itemName, string effect);
}