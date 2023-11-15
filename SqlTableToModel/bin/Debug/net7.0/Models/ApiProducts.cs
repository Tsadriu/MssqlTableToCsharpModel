using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Represents a data table object for the heren.ApiProducts table.
/// </summary>
[Table("ApiProducts", Schema = "heren")]
public class ApiProducts
{
	/// <summary>
	/// Gets or sets the IDProduct.
	/// </summary>
	public string IDProduct { get; set; }

	/// <summary>
	/// Gets or sets the CreatedForDate.
	/// </summary>
	public string CreatedForDate { get; set; }

	/// <summary>
	/// Gets or sets the ModifiedDateTime.
	/// </summary>
	public string ModifiedDateTime { get; set; }

	/// <summary>
	/// Gets or sets the Bid.
	/// </summary>
	public decimal Bid { get; set; }

	/// <summary>
	/// Gets or sets the Offer.
	/// </summary>
	public decimal Offer { get; set; }

	/// <summary>
	/// Gets or sets the Midpoint.
	/// </summary>
	public decimal Midpoint { get; set; }

	/// <summary>
	/// Gets or sets the DiffToPrevMid.
	/// </summary>
	public decimal? DiffToPrevMid { get; set; }

	/// <summary>
	/// Gets or sets the ChangePct.
	/// </summary>
	public decimal? ChangePct { get; set; }

	/// <summary>
	/// Gets or sets the DataUsed.
	/// </summary>
	public string DataUsed { get; set; }

	/// <summary>
	/// Gets or sets the IsEstimate.
	/// </summary>
	public bool IsEstimate { get; set; }

	/// <summary>
	/// Gets or sets the VolatilityIndex.
	/// </summary>
	public decimal VolatilityIndex { get; set; }

	/// <summary>
	/// Gets or sets the VolatilityIndexReason.
	/// </summary>
	public string? VolatilityIndexReason { get; set; }

	/// <summary>
	/// Gets or sets the BasisBid.
	/// </summary>
	public decimal BasisBid { get; set; }

	/// <summary>
	/// Gets or sets the BasisOffer.
	/// </summary>
	public decimal BasisOffer { get; set; }

	/// <summary>
	/// Gets or sets the BasisMidpoint.
	/// </summary>
	public decimal BasisMidpoint { get; set; }

	/// <summary>
	/// Gets or sets the DiffToPrevBasisMid.
	/// </summary>
	public decimal? DiffToPrevBasisMid { get; set; }

	/// <summary>
	/// Gets or sets the BasisChangePct.
	/// </summary>
	public decimal? BasisChangePct { get; set; }

	/// <summary>
	/// Gets or sets the IDPeriod.
	/// </summary>
	public byte IDPeriod { get; set; }

	/// <summary>
	/// Gets or sets the IDProductSpecification.
	/// </summary>
	public byte IDProductSpecification { get; set; }
}