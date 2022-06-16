using System.Globalization;

namespace TPL.RabbitMQ.Consumer.Configurations
{
    public static class AppSettingsConfiguration
    {
        public static IConfigurationRoot GetConfiguration()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("pt-BR");
            var ambiente = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")?.Trim();

            if (string.IsNullOrEmpty(ambiente))
            {
                Console.WriteLine("A variável de ambiente ASPNETCORE_ENVIRONMENT não foi definida. Aplicação será encerrada.");
                Environment.Exit(1);
            }

            return new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile(Path.Combine(AppContext.BaseDirectory, "appsettings.json"), false)
                 .AddJsonFile(Path.Combine(AppContext.BaseDirectory, $"appsettings.{ambiente}.json"), false, true)
                 .AddInMemoryCollection(new Dictionary<string, string>
                 {
                    { "Environment", ambiente }
                 }).Build();
        }
    }
}
