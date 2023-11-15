using System.Data;
using System.Data.SqlClient;
using SqlTableToModel;
using SqlTableToModel.Helpers;

static class Program
{
    public static async Task Main()
    {
        await AppSettingsManager.CheckAppSettings("enet");
        await AppSettingsManager.ConnectToDatabase();
        // DataTable dt = await AppSettingsManager.SqlConnection.GetSchemaAsync("Tables");
        List<string> tablesToGather = new List<string>()
        {
            "heren.ApiCurrencies",
            "heren.ApiMarkets",
            "heren.ApiPeriods",
            "heren.ApiProducts",
            "heren.ApiProductSpecifications",
            "heren.ApiUnits",
        };

        for (int i = 0; i < tablesToGather.Count; i++)
        {
            var schemaTable = tablesToGather[i];
            string modelClass = string.Empty;
            await using (SqlCommand command = AppSettingsManager.SqlConnection.CreateCommand())
            {
                command.CommandText = $"SELECT TOP 0 * FROM {schemaTable}";

                await using (SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.SchemaOnly))
                {
                    DataTable tableSchema = reader.GetSchemaTable() !;
                    modelClass = ModelCreatorHelper.CreateCsharpModel(tableSchema, schemaTable);
                }
            }
            bool useMeAsABreakPoint = default;
            await ModelCreatorHelper.SaveModelClass(modelClass, schemaTable.Split('.')[1]);
        }

        await AppSettingsManager.SqlConnection.CloseAsync();
    }
}
