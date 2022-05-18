using ClothingCatalog.Data;
using Microsoft.Extensions.Logging;

[assembly: FunctionsStartup(typeof(Startup))]

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        builder.Services
      .AddDbContext<ProductContext>((s, o) => o.UseCosmos(Environment.GetEnvironmentVariable("CosmosDBConnection"), databaseName: "products_db")
      .UseLoggerFactory(s.GetRequiredService<ILoggerFactory>()))
       .AddGraphQLFunction()
          .AddQueryType<Query>()
          .AddProjections()
          .AddFiltering()
          .AddSorting()
          .RegisterDbContext<ProductContext>(kind: DbContextKind.Synchronized);
    }
}
