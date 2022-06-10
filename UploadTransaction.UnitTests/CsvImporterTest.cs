﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using UploadTransaction.Importer.Entities;
using UploadTransaction.Importer.Enums;
using UploadTransaction.Importer.Interfaces;
using UploadTransaction.Importer.Services;

namespace UploadTransaction.UnitTests;

public class CsvImporterTest : BaseTest
{
	[TestCase("example.csv")]
	public void Import_Imported(string fileName)
	{
		// Arrange
		var path = Path.Combine(DirectoryName, fileName);
		var file = File.ReadAllBytes(path);
		IImporter importService = new CsvImporter();
		
		// Act
		var result = importService.Process(new ImporterRequest { File = file });
		
		// Assert
		result.Transactions.GetType().Should().Be(typeof(List<CsvTransaction>));
		
		var transactions = result.Transactions as List<CsvTransaction>;
		
		transactions.ToList()[0].TransactionId.Should().Be("Invoice0000001");
		transactions.ToList()[0].Amount.Should().Be(1000);
		transactions.ToList()[0].CurrencyCode.Should().Be("USD");
		transactions.ToList()[0].TransactionDate.Should().Be(new DateTime(2019, 02, 20, 00, 33, 16));
		transactions.ToList()[0].Status.Should().Be(CsvImporterResponseStatus.Approved);
		
		transactions.ToList()[1].TransactionId.Should().Be("Invoice0000002");
		transactions.ToList()[1].Amount.Should().Be(300);
		transactions.ToList()[1].CurrencyCode.Should().Be("USD");
		transactions.ToList()[1].TransactionDate.Should().Be(new DateTime(2019, 02, 21, 02, 04, 59));
		transactions.ToList()[1].Status.Should().Be(CsvImporterResponseStatus.Failed);
	}
}