using System.Reflection;
using System.Data.SqlClient;
using SqlTableToModel.Helpers;
using SqlTableToModel.Models;

namespace SqlTableToModel
{
    public static class AppSettingsManager
    {

        private static readonly string AppSettingsFullFileName = Path.Combine(ModelCreatorHelper.ExecutingDirectory, "appsettings.json");

        private static AppSettingsJson AppSettings = new AppSettingsJson();
        public static SqlConnection SqlConnection { get; private set; } = null!;

        public static async Task CheckAppSettings(bool useDefaultSettings = false)
        {
            if (File.Exists(AppSettingsFullFileName))
            {
                return;
            }

            // TODO: Save the JSON locally for future uses.
            if (useDefaultSettings)
            {
                var appSettingsJson = new AppSettingsVariablesJson
                {
                    DataSource = "",
                    InitialCatalog = "",
                    UserId = "",
                    Password = "",
                };

                AppSettings.Data.Add(appSettingsJson);
                return;
            }
            PromptUserForData();
            // await JsonSerializer.SerializeAsync(new AppSettingsJson());
        }

        public static async Task ConnectToDatabase()
        {
            SqlConnection = new SqlConnection(AppSettings.GetConnectionString());
            await SqlConnection.OpenAsync();
            Console.WriteLine("Connection established successfully.");
        }

        private static void PromptUserForData()
        {
            var appSettingsJson = new AppSettingsVariablesJson();

            Console.WriteLine("Data Source:");
            appSettingsJson.DataSource = Console.ReadLine() !;

            Console.WriteLine("Initial Catalog:");
            appSettingsJson.InitialCatalog = Console.ReadLine() !;

            Console.WriteLine("User ID:");
            appSettingsJson.UserId = Console.ReadLine() !;

            Console.WriteLine("Password:");
            appSettingsJson.Password = Console.ReadLine() !;
            AppSettings.Data.Add(appSettingsJson);
        }
    }
}
