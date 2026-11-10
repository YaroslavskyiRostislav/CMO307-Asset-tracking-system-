using MySql.Data.MySqlClient;
using System.Text.Json;
namespace AssetTracker.Data;

public static class Database
{
    private static readonly string connectionString = LoadConnectionString();

    private static string LoadConnectionString()
    {
        string path = Path.Combine(AppContext.BaseDirectory, "Data", "appsetings.json");
        string json = File.ReadAllText(path);

        using (JsonDocument doc = JsonDocument.Parse(json))
        {
            return doc.RootElement.GetProperty("ConnectionString").GetString();
        }
    }

    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }
}
