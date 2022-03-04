using SaveSyncWorker.src;
using System.IO;
using Microsoft.Extensions.Options;
using SaveSyncWorker.config;

namespace SaveSyncWorker
{
    public class SaveSyncWorker : BackgroundService
    {
        private readonly ILogger<SaveSyncWorker> logger;
        private readonly ISaveSyncProcess saveSyncProcess;
        private FileSystemWatcher watcher = new FileSystemWatcher();
        private readonly IOptions<SaveSyncConfig> config;


        public SaveSyncWorker(ISaveSyncProcess syncingProcess, ILogger<SaveSyncWorker> logger, IOptions<SaveSyncConfig> config)
        {
            this.logger = logger;
            this.saveSyncProcess = syncingProcess;
            this.config = config;

            watcher.Path = config.Value.SaveDirLocation;
            watcher.EnableRaisingEvents = true;
            watcher.Changed += syncingProcess.SyncFiles;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await saveSyncProcess.SyncFiles();
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}