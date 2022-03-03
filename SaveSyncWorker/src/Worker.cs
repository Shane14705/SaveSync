using SaveSyncWorker.src;
using System.IO;

namespace SaveSyncWorker
{
    public class SaveSyncWorker : BackgroundService
    {
        private readonly ILogger<SaveSyncWorker> logger;
        private readonly ISaveSyncProcess saveSyncProcess;
        private FileSystemWatcher watcher = new FileSystemWatcher();


        public SaveSyncWorker(ISaveSyncProcess syncingProcess, ILogger<SaveSyncWorker> logger)
        {
            this.logger = logger;
            this.saveSyncProcess = syncingProcess;
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