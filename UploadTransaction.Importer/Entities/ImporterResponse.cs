using UploadTransaction.Importer.Interfaces;

namespace UploadTransaction.Importer.Entities;

public class ImporterResponse : IImporterResponse
{
	public IEnumerable<ITransaction> Transactions { get; set; }
}