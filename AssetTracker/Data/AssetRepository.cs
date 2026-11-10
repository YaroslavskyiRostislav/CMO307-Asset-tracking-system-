using System;
using System.Collections.Generic;
using System.Text;
namespace AssetTracker.Data;
using AssetTracker.Models;
using MySql.Data.MySqlClient;

public class AssetRepository
{
    public void Add(Asset asset)
    {
        string sql = @"INSERT INTO asset
            (system_name, model, manufacturer, asset_type, ip_address, purchase_date, notes, employee_id)
            VALUES
            (@systemName, @model, @manufacturer, @type, @ip, @purchaseDate, @notes, @employeeId)";

        using (var conn = Database.GetConnection())
        using (var cmd = new MySqlCommand(sql, conn))
        {
            cmd.Parameters.AddWithValue("@systemName", asset.SystemName);
            cmd.Parameters.AddWithValue("@model", asset.Model);
            cmd.Parameters.AddWithValue("@manufacturer", asset.Manufacturer);
            cmd.Parameters.AddWithValue("@type", asset.AssetType);
            cmd.Parameters.AddWithValue("@ip", asset.IpAddress);
            cmd.Parameters.AddWithValue("@purchaseDate", asset.PurchaseDate);
            cmd.Parameters.AddWithValue("@notes", asset.Notes);
            cmd.Parameters.AddWithValue("@employeeId", asset.ResponsibleEmployee!.EmployeeId);

            conn.Open();
            cmd.ExecuteNonQuery();
            asset.AssetId = (int)cmd.LastInsertedId;
        }
    }
}
