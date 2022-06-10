using UploadTransaction.Importer.Enums;

namespace UploadTransaction.Importer.Interfaces;

public interface IImporterFactory
{
	IImporter Create(string fileName);
}