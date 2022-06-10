using UploadTransaction.Importer.Enums;
using UploadTransaction.Importer.Interfaces;

namespace UploadTransaction.Importer.Entities;

public class XmlTransaction : ITransaction
{
	public string TransactionId { get; set; }
	
	public decimal Amount { get; set; }

	public string CurrencyCode { get; set; }
	
	public DateTime TransactionDate { get; set; }
	
	public XmlImporterResponseStatus Status { get; set; }
}