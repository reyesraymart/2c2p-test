using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UploadTransaction.Core.Interfaces;

namespace UploadTransaction.DataLayer.Startup;

public static class ServiceCollectionExtension
{
	public static IServiceCollection AddDataLayer(this IServiceCollection serviceCollection, IConfiguration configuration)
	{
		serviceCollection.AddDbContextFactory<ProcessingDataContext>(builder =>
			{
				builder.UseSqlServer(
					configuration.GetConnectionString("MSSqlConnection"),
					x => x.MigrationsHistoryTable(HistoryRepository.DefaultTableName));
			})
			.AddSingleton<DbContext, ProcessingDataContext>();
		
		serviceCollection.AddSingleton(typeof(IRepository<>), typeof(Repository<>));

		return serviceCollection;
	}
}