using System;
namespace AssetTracker.Models;

public class Asset
{
    public int AssetId { get; set; }   // generated automatically
    public string SystemName { get; set; } = "";
    public string Model { get; set; } = "";
    public string Manufacturer { get; set; } = "";
    public string AssetType { get; set; } = "";
    public string IpAddress { get; set; } = "";
    public DateTime? PurchaseDate { get; set; }
    public string Notes { get; set; } = "";
    public Employee? ResponsibleEmployee { get; set; }
}
