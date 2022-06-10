namespace UploadTransaction.Core.Interfaces;

public interface IImportService
{
	void Import(string fileName, byte[] file);
}