﻿using AutoMapper;
using UploadTransaction.Core.Entities;
using UploadTransaction.Core.Interfaces;
using UploadTransaction.Importer.Entities;
using UploadTransaction.Importer.Interfaces;

namespace UploadTransaction.Core.Services;

public class ImportService : IImportService
{
	private readonly IRepository<Transaction> _repository;
	private readonly IMapper _mapper;
	private readonly IImporterFactory _importerFactory;

	public ImportService(
		IRepository<Transaction> repository, 
		IMapper mapper, 
		IImporterFactory importerFactory)
	{
		_repository = repository;
		_mapper = mapper;
		_importerFactory = importerFactory;
	}

	public void Import(string fileName, byte[] file)
	{
		if (string.IsNullOrWhiteSpace(fileName))
			throw new ArgumentException($"Don't set {nameof(fileName)}");
		
		if (file == null || file.Length == 0)
			throw new ArgumentException($"Don't set {nameof(file)}");

		var importer = _importerFactory.Create(fileName);
		
		var data = importer.Process(new ImporterRequest(){ File = file });

		var transactions = _mapper.Map<List<Transaction>>(data.Transactions);
		
		_repository.Add(transactions);
	}
}