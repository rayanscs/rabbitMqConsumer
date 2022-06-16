using TPL.RabbitMQ.Consumer;
using TPL.RabbitMQ.Consumer.Configurations;
using TPL.RabbitMQ.Consumer.IoC;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        var configuration = AppSettingsConfiguration.GetConfiguration();
        services.AddSingleton<IConfiguration>(c => configuration);
        services.AddConfigRabbitMq(configuration);
        services.AddConnections();
        services.AddRepositories();
        services.AddServices();
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
