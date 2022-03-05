using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SaveSyncGUI.src
{
    //Class that manages a fileset to be saved and synced. You should make one of these per directory you want to watch 
    internal class SaveSyncManager
    {
        private string watchingDir = null;
        private string syncTargetDir = null;
        private FileSystemWatcher watcher = new FileSystemWatcher();
        public SaveSyncManager(string dirToWatch, string targetDir)
        {
            this.watchingDir = dirToWatch;
            this.syncTargetDir = targetDir;
            this.watcher.Path = dirToWatch;
            this.watcher.IncludeSubdirectories = true;
            this.watcher.NotifyFilter = NotifyFilters.Attributes |
                                   NotifyFilters.CreationTime |
                                   NotifyFilters.DirectoryName |
                                   NotifyFilters.FileName |
                                   NotifyFilters.LastAccess |
                                   NotifyFilters.LastWrite |
                                   NotifyFilters.Security |
                                   NotifyFilters.Size;
            // Watch all files.  
            this.watcher.Filter = "*.*";
            //This is where we should bind the events for this class's file watcher to the callbacks on this class instance 
            this.watcher.Changed += this.OnFileChanged;
            this.watcher.EnableRaisingEvents = true;
        }

        public void OnFileChanged(object e, EventArgs args)
        {
            Console.Out.WriteLine("Hi!");
        }

        private bool SaveToCloud()
        {
            throw new NotImplementedException();
        }
    }
}
