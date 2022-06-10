using UploadTransaction.Importer.Enums;

namespace UploadTransaction.Importer.Interfaces;

public interface IImporter
{
	FileFormat FileFormat { get; }

	IImporterResponse Process(IImporterRequest inputData);
}