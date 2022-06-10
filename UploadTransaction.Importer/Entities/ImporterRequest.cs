using UploadTransaction.Importer.Interfaces;

namespace UploadTransaction.Importer.Entities;

public class ImporterRequest : IImporterRequest
{
	public byte[] File { get; set; }
}