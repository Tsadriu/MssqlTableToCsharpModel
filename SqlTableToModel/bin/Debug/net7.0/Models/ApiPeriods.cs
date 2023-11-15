using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Represents a data table object for the heren.ApiPeriods table.
/// </summary>
[Table("ApiPeriods", Schema = "heren")]
public class ApiPeriods
{
	/// <summary>
	/// Gets or sets the IDPeriod.
	/// </summary>
	public byte IDPeriod { get; set; }

	/// <summary>
	/// Gets or sets the ReferenceDate.
	/// </summary>
	public DateTime ReferenceDate { get; set; }

	/// <summary>
	/// Gets or sets the DefaultPeriodLabel.
	/// </summary>
	public string DefaultPeriodLabel { get; set; }

	/// <summary>
	/// Gets or sets the StartDate.
	/// </summary>
	public DateTime StartDate { get; set; }

	/// <summary>
	/// Gets or sets the EndDate.
	/// </summary>
	public DateTime EndDate { get; set; }

	/// <summary>
	/// Gets or sets the DisplayOrder.
	/// </summary>
	public decimal DisplayOrder { get; set; }

	/// <summary>
	/// Gets or sets the AbsolutePeriodCode.
	/// </summary>
	public string AbsolutePeriodCode { get; set; }

	/// <summary>
	/// Gets or sets the AbsolutePeriodLabel.
	/// </summary>
	public string AbsolutePeriodLabel { get; set; }

	/// <summary>
	/// Gets or sets the RelativePeriodCode.
	/// </summary>
	public string RelativePeriodCode { get; set; }

	/// <summary>
	/// Gets or sets the RelativePeriodLabel.
	/// </summary>
	public string RelativePeriodLabel { get; set; }

	/// <summary>
	/// Gets or sets the DefaultPeriodCode.
	/// </summary>
	public string DefaultPeriodCode { get; set; }

	/// <summary>
	/// Gets or sets the PeriodType.
	/// </summary>
	public string PeriodType { get; set; }
}