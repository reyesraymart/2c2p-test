using Microsoft.Extensions.DependencyInjection;
using UploadTransaction.Core.Interfaces;
using UploadTransaction.Core.Services;
using UploadTransaction.Importer.Startup;

namespace UploadTransaction.Core.Startup;

public static class ServiceCollectionExtension
{
	public static IServiceCollection AddCore(this IServiceCollection serviceCollection)
	{
		serviceCollection.AddImporter();
		serviceCollection.AddTransient<IImportService, ImportService>();
		serviceCollection.AddAutoMapper(typeof(ServiceCollectionExtension));
		
		return serviceCollection;
	}
}