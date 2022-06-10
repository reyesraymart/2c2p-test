using AutoMapper;
using UploadTransaction.Core.Entities;
using UploadTransaction.Core.Filers;
using UploadTransaction.Web.Models;

namespace UploadTransaction.Web.Mappings;

public class CommonMapping : Profile
{
	public CommonMapping()
	{
		CreateMap<Transaction, TransactionModel>();
		CreateMap<TransactionRequest, TransactionSearchRequestData>();
	}
}