using TFDealFinder.Core;
using TFDealFinder.Core.Models;

namespace TFDealFinder.App.API;

public interface ISCMApi
{
    public Task<MarketSearchResponseResults[]> SCMEffectSearch(string query);
}