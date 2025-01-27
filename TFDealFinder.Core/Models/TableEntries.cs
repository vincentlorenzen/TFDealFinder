using System.ComponentModel;

namespace TFDealFinder.Core.Models;

public class TableEntries
{
    public string ItemImage { get; set; }
    public string ItemName { get; set; }
    public string ItemPrice { get; set; }
    public double BPValue { get; set; }

    public TableEntries(string itemImage, string itemName, string itemPrice, double bpValue)
    {
        ItemImage = itemImage;
        ItemName = itemName;
        ItemPrice = itemPrice;
        BPValue = bpValue;
    }
}