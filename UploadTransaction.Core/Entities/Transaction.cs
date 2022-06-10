using UploadTransaction.Core.Enums;

namespace UploadTransaction.Core.Entities;

public class Transaction : IEntity
{
	public long Id { get; set; }
	
	public string TransactionId { get; set; }
	
	public decimal Amount { get; set; }

	public string CurrencyCode { get; set; }
	
	public DateTime TransactionDate { get; set; }
	
	public TransactionStatus Status { get; set; }
}