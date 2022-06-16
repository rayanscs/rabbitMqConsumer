using TPL.RabbitMQ.Consumer.Configurations;
using TPL.RabbitMQ.Consumer.Domain.Interfaces.RabbitMq;
using TPL.RabbitMQ.Consumer.RabbitPattern;

namespace TPL.RabbitMQ.Consumer.IoC
{
    public static class Injector
    {
        public static IServiceCollection AddConfigRabbitMq(this IServiceCollection services, IConfiguration configuration)
        {
            var rabbitMqConfig = new RabbitMqConfiguration();
            ConfigurationBinder.Bind(configuration, nameof(RabbitMqConfiguration), rabbitMqConfig);
            services.AddSingleton(rabbitMqConfig);
            services.AddSingleton<IMessageBus, RabbitMqBus>();
            return services;
        }

        public static IServiceCollection AddConnections(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddLogs(this IServiceCollection services)
        {
            return services;
        }
    }
}
