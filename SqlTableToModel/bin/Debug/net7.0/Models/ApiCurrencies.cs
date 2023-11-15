using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Represents a data table object for the heren.ApiCurrencies table.
/// </summary>
[Table("ApiCurrencies", Schema = "heren")]
public class ApiCurrencies
{
	/// <summary>
	/// Gets or sets the IDCurrency.
	/// </summary>
	public byte IDCurrency { get; set; }

	/// <summary>
	/// Gets or sets the CurrencyName.
	/// </summary>
	public string CurrencyName { get; set; }

	/// <summary>
	/// Gets or sets the Code.
	/// </summary>
	public string Code { get; set; }
}