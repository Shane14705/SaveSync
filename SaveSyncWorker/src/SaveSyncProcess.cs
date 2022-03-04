using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using SaveSyncWorker.config;

namespace SaveSyncWorker.src
{
    public interface ISaveSyncProcess
    {
        Task SyncFiles(object sender, FileSystemEventArgs e);
    }
    public class SaveSyncProcess : ISaveSyncProcess
    {
        public SaveSyncProcess(IOptions<SaveSyncConfig> config, ILogger<SaveSyncProcess> logger)
        {
            this.config = config.Value;
            this.logger = logger;
        }

        private readonly SaveSyncConfig config;
        private readonly ILogger<SaveSyncProcess> logger;
        Task ISaveSyncProcess.SyncFiles(object sender, FileSystemEventArgs e)
        {
            logger.LogInformation($"Syncing saves for {config.GameName} to {config.CloudSyncLocation}!");
            return Task.CompletedTask;
        }
    }
}
