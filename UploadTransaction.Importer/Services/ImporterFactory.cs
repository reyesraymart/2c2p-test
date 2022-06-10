﻿using UploadTransaction.Importer.Extensions;
using UploadTransaction.Importer.Interfaces;

namespace UploadTransaction.Importer.Services;

public class ImporterFactory : IImporterFactory
{
	private readonly IEnumerable<IImporter> _importers;

	public ImporterFactory(IEnumerable<IImporter> importers)
	{
		_importers = importers;
	}

	public IImporter Create(string fileName)
	{
		var fileFormat = FileExtension.GetFileFormat(fileName);
		var importer = _importers.Single(x => x.FileFormat == fileFormat);
		return importer;
	}
}