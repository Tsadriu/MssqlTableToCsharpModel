using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Represents a data table object for the heren.ApiMarkets table.
/// </summary>
[Table("ApiMarkets", Schema = "heren")]
public class ApiMarkets
{
	/// <summary>
	/// Gets or sets the IDMarket.
	/// </summary>
	public byte IDMarket { get; set; }

	/// <summary>
	/// Gets or sets the MarketName.
	/// </summary>
	public string MarketName { get; set; }

	/// <summary>
	/// Gets or sets the Description.
	/// </summary>
	public string Description { get; set; }

	/// <summary>
	/// Gets or sets the Code.
	/// </summary>
	public string Code { get; set; }
}