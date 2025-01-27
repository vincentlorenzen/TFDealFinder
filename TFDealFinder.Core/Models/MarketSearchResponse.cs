using System.Text.Json.Serialization;

namespace TFDealFinder.Core.Models;

public class MarketSearchResponse
{
    [JsonPropertyName("success")]
    private bool Success { get; set; }
    [JsonPropertyName("start")]
    public int Start { get; set; }
    [JsonPropertyName("pagesize")]
    public int PageSize { get; set; }
    [JsonPropertyName("total_count")]
    public int TotalCount { get; set; }
    [JsonPropertyName("searchdata")]
    public MarketSearchResponseSearchData SearchData { get; set; }
    [JsonPropertyName("results")]
    public MarketSearchResponseResults[] Results { get; set; }
}

public class MarketSearchResponseSearchData
{
    [JsonPropertyName("query")]
    public string Query { get; set; }
    [JsonPropertyName("search_descriptions")]
    public bool SearchDescriptions { get; set; }
    [JsonPropertyName("total_count")]
    public int TotalCount { get; set; }
    [JsonPropertyName("pagesize")]
    public int PageSize { get; set; }
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; }
    [JsonPropertyName("class_prefix")]
    public string ClassPrefix { get; set; }
}

public class MarketSearchResponseResults
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("hash_name")]
    public string HashName { get; set; }
    [JsonPropertyName("sell_listings")]
    public int SellListings { get; set; }
    [JsonPropertyName("sell_price")]
    public int SellPrice { get; set; }
    [JsonPropertyName("sell_price_text")]
    public string SellPriceText { get; set; }
    [JsonPropertyName("app_icon")]
    public string AppIcon { get; set; }
    [JsonPropertyName("app_name")]
    public string AppName { get; set; }
    [JsonPropertyName("asset_description")]
    public MarketSearchResponseResultsAssetDescription AssetDescription { get; set; }
    [JsonPropertyName("sale_price_text")]
    public string SalePriceText { get; set; }
}

public class MarketSearchResponseResultsAssetDescription
{
    [JsonPropertyName("appid")]
    public int AppId { get; set; }
    [JsonPropertyName("classid")]
    public string ClassId { get; set; }
    [JsonPropertyName("instanceid")]
    public string InstanceId { get; set; }
    [JsonPropertyName("background_color")]
    public string BackgroundColor { get; set; }
    [JsonPropertyName("icon_url")]
    public string IconURL { get; set; }
    [JsonPropertyName("tradable")]
    public int Tradable { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("name_color")]
    public string NameColor { get; set; }
    [JsonPropertyName("type")]
    public string Type { get; set; }
    [JsonPropertyName("market_name")]
    public string MarketName { get; set; }
    [JsonPropertyName("market_hash_name")]
    public string MarketHashName { get; set; }
    [JsonPropertyName("commodity")]
    public int Commodity { get; set; }
}