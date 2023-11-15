using System.Data;
using System.Reflection;

namespace SqlTableToModel.Helpers
{
    /// <summary>
    /// This is a helper class for creating C# models.
    /// </summary>
    public static class ModelCreatorHelper
    {
        /// <summary>
        /// The directory where the executing assembly is located.
        /// </summary>
        public static readonly string ExecutingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) !;

        /// <summary>
        /// The directory where the models should be stored.
        /// </summary>
        private static readonly string ModelDirectory = Path.Combine(ExecutingDirectory, "Models");

        /// <summary>
        /// Gets the tab character '\t'.
        /// </summary>
        private static string Tab => "\t";

        /// <summary>
        /// Gets the new line character '\r\n';
        /// </summary>
        private static string NewLine => "\r\n";

        /// <summary>
        /// This method creates a C# model from a given DataTable.
        /// </summary>
        /// <param name="table">The DataTable to convert to a C# model.</param>
        /// <param name="schemaTable">The name of the table.</param>
        /// <returns>Returns a string representation of the C# model.</returns>
        public static string CreateCsharpModel(DataTable table, string schemaTable)
        {
            string tableName = schemaTable.Split('.')[1];
            string schemaName = schemaTable.Split('.')[0];
            
            string modelClass = $"using System.Data;{NewLine}";
            modelClass += $"using System.ComponentModel.DataAnnotations.Schema;{NewLine}{NewLine}";
            modelClass += $"/// <summary>{NewLine}";
            modelClass += $"/// Represents a data table object for the {schemaTable} table.{NewLine}";
            modelClass += $"/// </summary>{NewLine}";
            modelClass += $"[Table(\"{tableName}\", Schema = \"{schemaName}\")]{NewLine}";
            modelClass += $"public class {tableName}{NewLine}{{{NewLine}";
            for (int index = 0; index < table.Rows.Count; index++)
            {
                DataRow row = table.Rows[index];
                bool allowNull = (bool)row["AllowDBNull"];
                modelClass += $"{Tab}/// <summary>{NewLine}";
                modelClass += $"{Tab}/// Gets or sets the {row["ColumnName"]}.{NewLine}";
                modelClass += $"{Tab}/// </summary>{NewLine}";
                modelClass += $"{Tab}public {ConvertSqlTypeToCSharp($"{row["DataTypeName"]}", allowNull)} {row["ColumnName"]} {{ get; set; }}{NewLine}";

                if (index + 1 < table.Rows.Count)
                {
                    modelClass += $"{NewLine}";
                }
            }

            modelClass += "}";
            return modelClass;
        }

        /// <summary>
        /// This method saves the C# model class to an appropriate file.
        /// </summary>
        /// <param name="modelClass">The C# model class to save.</param>
        /// <param name="tableName">The name of the table.</param>
        public static async Task SaveModelClass(string modelClass, string tableName)
        {
            if (!Directory.Exists(ModelDirectory))
            {
                Directory.CreateDirectory(ModelDirectory);
            }

            string fullFileName = Path.Combine(ModelDirectory, tableName + ".cs");
            await File.WriteAllTextAsync(fullFileName, modelClass);
        }

        /// <summary>
        /// This method converts SQL type to C# type.
        /// </summary>
        /// <param name="sqlType">The SQL type to convert.</param>
        /// <param name="allowNull">Specifies if null is allowed.</param>
        /// <returns>Returns a string representation of the C# type.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the sql type has not been mapped.</exception>
        private static string ConvertSqlTypeToCSharp(string sqlType, bool allowNull)
        {
            string value = sqlType switch
            {
                "binary" or "image" or "varbinary" => "byte[]",
                "bit" => "bool",
                "char" or "nchar" or "ntext" or "nvarchar" or "text" or "varchar" => "string",
                "date" or "datetime" or "datetime2" or "smalldatetime" => "DateTime",
                "datetimeoffset" => "DateTimeOffset",
                "decimal" or "money" or "smallmoney" or "numeric" => "decimal",
                "float" => "double",
                "int" => "int",
                "real" => "float",
                "smallint" => "short",
                "time" => "TimeSpan",
                "timestamp" or "bigint" => "long",
                "tinyint" => "byte",
                "uniqueidentifier" => "Guid",
                _ => throw new ArgumentOutOfRangeException(nameof(sqlType), $"The case {sqlType} has not been mapped in the switch."),
            };

            return allowNull ? $"{value}?" : value;
        }
    }
}
