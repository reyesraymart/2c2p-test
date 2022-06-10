using Microsoft.Extensions.DependencyInjection;
using UploadTransaction.Importer.Interfaces;
using UploadTransaction.Importer.Services;

namespace UploadTransaction.Importer.Startup;

public static class ServiceCollectionExtension
{
	public static IServiceCollection AddImporter(this IServiceCollection serviceCollection)
	{
		serviceCollection.AddTransient<IImporterFactory, ImporterFactory>();
		serviceCollection.AddTransient<IImporter, CsvImporter>();
		serviceCollection.AddTransient<IImporter, XmlImporter>();

		return serviceCollection;
	}
}