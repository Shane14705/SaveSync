using System.Runtime.CompilerServices;
using Microsoft.Extensions.Hosting;
using SaveSyncWorker.config;
using SaveSyncWorker.src;

namespace SaveSyncWorker.src
{
    public class SaveSyncHost
    {
        public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args).ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddConsole();
                logging.AddEventLog();
            }).UseWindowsService().ConfigureServices(configService);

        private static void configService(HostBuilderContext ctx, IServiceCollection services)
        {
            services.Configure<SaveSyncConfig>(ctx.Configuration.GetSection("Omori"));
            services.AddLogging();
            services.AddSingleton<ISaveSyncProcess, SaveSyncProcess>();
            services.AddHostedService<SaveSyncWorker>();

        }
    }
}