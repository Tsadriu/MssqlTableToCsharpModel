using System.Text.Json.Serialization;

namespace SqlTableToModel.Models
{
    public class AppSettingsJson
    {
        [JsonPropertyName("data")]
        public List<AppSettingsVariablesJson> Data { get; set; } = new List<AppSettingsVariablesJson>();

        public string GetConnectionString(int index = 0)
        {
            AppSettingsVariablesJson settings = Data[index];
            return $"Data Source={settings.DataSource};Initial Catalog={settings.InitialCatalog};User ID={settings.UserId};Password={settings.Password}";
        }
    }

    public class AppSettingsVariablesJson
    {
        [JsonPropertyName("datasource")]
        public string DataSource { get; set; } = string.Empty;

        [JsonPropertyName("initialcatalog")]
        public string InitialCatalog { get; set; } = string.Empty;

        [JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        [JsonPropertyName("password")]
        public string? Password { get; set; }
    }
}
