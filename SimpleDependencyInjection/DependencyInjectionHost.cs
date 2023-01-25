namespace SimpleDependencyInjection
{
    public class DependencyInjectionHost
    {
        static DependencyInjectionHost dependencyInjectionHost;
        private DependencyInjectionHost() { }

        public IServiceCollection Services { get; private set; }

        public IConfiguration Configuration { get; private set; }

        public IServiceProvider ServiceProvider { get; private set; }

        public T GetService<T>() => ServiceProvider.GetService<T>();

        public T GetRequiredService<T>() => ServiceProvider.GetRequiredService<T>();

        public static DependencyInjectionHost CreateDefaullHost()
        {
            if (dependencyInjectionHost is null)
            {
                dependencyInjectionHost = new DependencyInjectionHost();
                dependencyInjectionHost.LoadConfiguration();
                dependencyInjectionHost.Services = new ServiceCollection();
            }

            return dependencyInjectionHost;
        }

        public void Build()
        {
            dependencyInjectionHost.ServiceProvider = dependencyInjectionHost.Services.BuildServiceProvider();
        }

        void LoadConfiguration()
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true)
                .AddEnvironmentVariables()
                .Build();
        }
    }
}