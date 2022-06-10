using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using UploadTransaction.Core.Startup;

namespace UploadTransaction.UnitTests;

public class AutoMapperTest
{
	[TestCase]
	public void CheckAutoMapper()
	{
		var serviceCollection = new ServiceCollection();
		serviceCollection.AddAutoMapper(typeof(ServiceCollectionExtension));
		serviceCollection.BuildServiceProvider();
		
		var configuration = new MapperConfiguration(
			cfg => cfg.AddMaps(typeof(ServiceCollectionExtension))
		);

		configuration.AssertConfigurationIsValid();
	}
}

