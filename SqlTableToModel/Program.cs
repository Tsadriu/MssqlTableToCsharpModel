using System.Data;
using System.Data.SqlClient;
using SqlTableToModel;
using SqlTableToModel.Helpers;

static class Program
{
    public static async Task Main()
    {
        await AppSettingsManager.CheckAppSettings(false);
        await AppSettingsManager.ConnectToDatabase();
        string schemaTable = "sem.Files";

        // DataTable dt = await AppSettingsManager.SqlConnection.GetSchemaAsync("Tables");

        string modelClass = string.Empty;
        await using (SqlCommand command = AppSettingsManager.SqlConnection.CreateCommand())
        {
            command.CommandText = $"SELECT TOP 0 * FROM {schemaTable}";

            await using (SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.SchemaOnly))
            {
                DataTable tableSchema = reader.GetSchemaTable() !;
                modelClass = ModelCreatorHelper.CreateCsharpModel(tableSchema, schemaTable.Split('.')[1]);
            }
        }
        bool useMeAsABreakPoint = default;
        await ModelCreatorHelper.SaveModelClass(modelClass, schemaTable.Split('.')[1]);
        await AppSettingsManager.SqlConnection.CloseAsync();
    }
}
