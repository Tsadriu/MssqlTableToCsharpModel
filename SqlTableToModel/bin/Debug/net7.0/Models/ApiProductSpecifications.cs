using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Represents a data table object for the heren.ApiProductSpecifications table.
/// </summary>
[Table("ApiProductSpecifications", Schema = "heren")]
public class ApiProductSpecifications
{
	/// <summary>
	/// Gets or sets the IDProductSpecification.
	/// </summary>
	public byte IDProductSpecification { get; set; }

	/// <summary>
	/// Gets or sets the ProductSpecificationName.
	/// </summary>
	public string ProductSpecificationName { get; set; }

	/// <summary>
	/// Gets or sets the Code.
	/// </summary>
	public string Code { get; set; }

	/// <summary>
	/// Gets or sets the IsConverted.
	/// </summary>
	public bool IsConverted { get; set; }

	/// <summary>
	/// Gets or sets the TimelinessName.
	/// </summary>
	public string TimelinessName { get; set; }

	/// <summary>
	/// Gets or sets the DataSupplierName.
	/// </summary>
	public string DataSupplierName { get; set; }

	/// <summary>
	/// Gets or sets the IDCurrency.
	/// </summary>
	public byte IDCurrency { get; set; }

	/// <summary>
	/// Gets or sets the IDMarket.
	/// </summary>
	public byte IDMarket { get; set; }

	/// <summary>
	/// Gets or sets the IDUnit.
	/// </summary>
	public byte IDUnit { get; set; }
}