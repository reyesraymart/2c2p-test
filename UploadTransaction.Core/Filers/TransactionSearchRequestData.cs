using UploadTransaction.Core.Enums;
using UploadTransaction.Core.Interfaces.Filters;

namespace UploadTransaction.Core.Filers;

public class TransactionSearchRequestData : IRequestData
{
	public string? CurrencyCode { get; set; }
	
	public DateTime? From { get; set; }
	
	public DateTime? To { get; set; }
		
	public TransactionStatus? Status { get; set; }
}