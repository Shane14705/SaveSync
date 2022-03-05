using System;
using System.ServiceProcess;
using System.IO;
using SaveSyncGUI.src;


namespace SaveSyncGUI
{
    public partial class SaveSyncForm : Form
    {
        private List<string> saveDirList;
        private List<string> targetDirList;
        
        //Perhaps we can get rid of the top two and only use this one list with the SyncManagers (however what will we do when we add a savedir with no sync dir yet? Maybe we can force them to pick both at once?
        private List<SaveSyncManager> saveManagerList = new List<SaveSyncManager>();


        public SaveSyncForm()
        {
            //In the constructor for the program here, we should load in all of our save/sync dirs from wherever we are storing them, and instantiate SaveSyncManagers for each pair
            saveDirList = new List<string>();
            targetDirList = new List<string>();


            //Here is where we should load in the directories
            InitializeComponent();
            
        }

        private void btnAddSaveDirectory_Click(object sender, EventArgs e)
        {
            
            if (DialogResult.OK == pickSaveDirDialog.ShowDialog())
            {
                try
                {
                    
                    saveDirList.Add(Path.GetFullPath(pickSaveDirDialog.SelectedPath));
                    saveDirListBox.Items.Add(Path.GetFullPath(pickSaveDirDialog.SelectedPath));

                    //Ok, with the way the constructor is set up right now we most likely will have to force the user to add the save and sync dirs at the same time.
                    saveManagerList.Add(new SaveSyncManager(Path.GetFullPath(pickSaveDirDialog.SelectedPath), "INSERT SYNC TARGET HERE"));
                }
                catch (ArgumentException exception)
                {
                    MessageBox.Show("Could not validate the path selected!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

            }
            
        }

        private void SaveSyncForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                saveSyncTray.Visible = true;
            }
        }


        private void btnAddSyncTarget_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnStartService_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnStopService_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void saveSyncTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            saveSyncTray.Visible = false;
        }
    }
}