using System.Collections.Immutable;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using TFDealFinder.Core.Models;

namespace TFDealFinder.App.API;

public class SCMApi : ISCMApi
{
    private HttpClient _httpClient;

    public SCMApi(HttpClient _httpClient)
    {
        Debug.WriteLine("hjaelp");
        this._httpClient = _httpClient;
    }

    public async Task<MarketSearchResponseResults[]> SCMEffectSearch(string query)
    {
        string URL =
            $"https://steamcommunity.com/market/search/render?query={query}&appid=440&count=25&search_descriptions=1&norender=1";
        using HttpResponseMessage response = await _httpClient.GetAsync(URL);
        MarketSearchResponse responseConverted = await response.Content.ReadFromJsonAsync<MarketSearchResponse>();
        Debug.WriteLine("hej");
        return responseConverted.Results;
    }
    
}
