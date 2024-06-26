using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Stocks;

await Host.CreateDefaultBuilder(args)
    .UseOrleans(
        builder => builder.UseLocalhostClustering())
    .ConfigureServices(
        services => services.AddHostedService<StocksHostedService>())
    .RunConsoleAsync();
