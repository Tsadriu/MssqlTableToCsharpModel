using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Represents a data table object for the heren.ApiUnits table.
/// </summary>
[Table("ApiUnits", Schema = "heren")]
public class ApiUnits
{
	/// <summary>
	/// Gets or sets the IDUnit.
	/// </summary>
	public byte IDUnit { get; set; }

	/// <summary>
	/// Gets or sets the UnitName.
	/// </summary>
	public string UnitName { get; set; }

	/// <summary>
	/// Gets or sets the Description.
	/// </summary>
	public string Description { get; set; }

	/// <summary>
	/// Gets or sets the Symbol.
	/// </summary>
	public string Symbol { get; set; }

	/// <summary>
	/// Gets or sets the UnitType.
	/// </summary>
	public string UnitType { get; set; }

	/// <summary>
	/// Gets or sets the Code.
	/// </summary>
	public string Code { get; set; }
}