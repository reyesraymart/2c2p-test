using UploadTransaction.Importer.Enums;
using UploadTransaction.Importer.Interfaces;

namespace UploadTransaction.Importer.Entities;

public class CsvTransaction : ITransaction
{
	public string TransactionId { get; set; }
	
	public decimal Amount { get; set; }

	public string CurrencyCode { get; set; }
	
	public DateTime TransactionDate { get; set; }
	
	public CsvImporterResponseStatus Status { get; set; }
}