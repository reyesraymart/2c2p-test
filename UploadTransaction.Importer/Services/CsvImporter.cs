using System.Globalization;
using Microsoft.VisualBasic.FileIO;
using UploadTransaction.Importer.Entities;
using UploadTransaction.Importer.Enums;
using UploadTransaction.Importer.Interfaces;

namespace UploadTransaction.Importer.Services;

public class CsvImporter : IImporter
{
	public FileFormat FileFormat => FileFormat.Csv;
	
	public IImporterResponse Process(IImporterRequest inputData)
	{
		var transactions = new List<CsvTransaction>();

		var memoryStream = new MemoryStream(inputData.File);
		
		var parser = new TextFieldParser(memoryStream);

		parser.HasFieldsEnclosedInQuotes = true;
		parser.SetDelimiters(",");

		while (!parser.EndOfData)
		{
			var row = parser.ReadFields();

			transactions.Add(new CsvTransaction
			{
				TransactionId = row[0],
				Amount = decimal.Parse(row[1].Replace(",", ""), CultureInfo.InvariantCulture),
				CurrencyCode = row[2],
				TransactionDate = DateTime.SpecifyKind(DateTime.ParseExact(row[3], "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture), DateTimeKind.Utc),
				Status = (CsvImporterResponseStatus)Enum.Parse(typeof(CsvImporterResponseStatus), row[4])
			});
		} 

		parser.Close();

		return new ImporterResponse { Transactions = transactions };
	}
}