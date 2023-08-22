using System.Data;

public class Files {
	/// <summary>
	/// Gets or sets the IDFile.
	/// </summary>
	public int IDFile { get; set; }

	/// <summary>
	/// Gets or sets the FilePath.
	/// </summary>
	public string FilePath { get; set; }

	/// <summary>
	/// Gets or sets the FileName.
	/// </summary>
	public string FileName { get; set; }

	/// <summary>
	/// Gets or sets the OriginalFileName.
	/// </summary>
	public string? OriginalFileName { get; set; }

	/// <summary>
	/// Gets or sets the FileSize.
	/// </summary>
	public int FileSize { get; set; }

	/// <summary>
	/// Gets or sets the UploadAt.
	/// </summary>
	public DateTime UploadAt { get; set; }

	/// <summary>
	/// Gets or sets the UploadBy.
	/// </summary>
	public string UploadBy { get; set; }

	/// <summary>
	/// Gets or sets the LastDownloadAt.
	/// </summary>
	public DateTime? LastDownloadAt { get; set; }

	/// <summary>
	/// Gets or sets the LastDownloadBy.
	/// </summary>
	public string? LastDownloadBy { get; set; }
}