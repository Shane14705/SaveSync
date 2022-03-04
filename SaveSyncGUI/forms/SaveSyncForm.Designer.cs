namespace SaveSyncGUI
{
    partial class SaveSyncForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveSyncForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStartService = new System.Windows.Forms.Button();
            this.btnStopService = new System.Windows.Forms.Button();
            this.btnAddSyncTarget = new System.Windows.Forms.Button();
            this.btnAddSaveDirectory = new System.Windows.Forms.Button();
            this.saveSyncTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.splitContainerLists = new System.Windows.Forms.SplitContainer();
            this.saveDirListBox = new System.Windows.Forms.ListBox();
            this.syncDirListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLists)).BeginInit();
            this.splitContainerLists.Panel1.SuspendLayout();
            this.splitContainerLists.Panel2.SuspendLayout();
            this.splitContainerLists.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnStartService, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStopService, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAddSyncTarget, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddSaveDirectory, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 176);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(481, 105);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnStartService
            // 
            this.btnStartService.AutoSize = true;
            this.btnStartService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartService.Location = new System.Drawing.Point(1, 53);
            this.btnStartService.Margin = new System.Windows.Forms.Padding(1);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(238, 51);
            this.btnStartService.TabIndex = 0;
            this.btnStartService.Text = "Start Service";
            this.btnStartService.UseVisualStyleBackColor = true;
            this.btnStartService.Click += new System.EventHandler(this.btnStartService_Click);
            // 
            // btnStopService
            // 
            this.btnStopService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStopService.Location = new System.Drawing.Point(241, 53);
            this.btnStopService.Margin = new System.Windows.Forms.Padding(1);
            this.btnStopService.Name = "btnStopService";
            this.btnStopService.Size = new System.Drawing.Size(239, 51);
            this.btnStopService.TabIndex = 1;
            this.btnStopService.Text = "Stop Service";
            this.btnStopService.UseVisualStyleBackColor = true;
            this.btnStopService.Click += new System.EventHandler(this.btnStopService_Click);
            // 
            // btnAddSyncTarget
            // 
            this.btnAddSyncTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddSyncTarget.Location = new System.Drawing.Point(241, 1);
            this.btnAddSyncTarget.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddSyncTarget.Name = "btnAddSyncTarget";
            this.btnAddSyncTarget.Size = new System.Drawing.Size(239, 50);
            this.btnAddSyncTarget.TabIndex = 2;
            this.btnAddSyncTarget.Text = "Add Sync Target";
            this.btnAddSyncTarget.UseVisualStyleBackColor = true;
            this.btnAddSyncTarget.Click += new System.EventHandler(this.btnAddSyncTarget_Click);
            // 
            // btnAddSaveDirectory
            // 
            this.btnAddSaveDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddSaveDirectory.Location = new System.Drawing.Point(1, 1);
            this.btnAddSaveDirectory.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddSaveDirectory.Name = "btnAddSaveDirectory";
            this.btnAddSaveDirectory.Size = new System.Drawing.Size(238, 50);
            this.btnAddSaveDirectory.TabIndex = 3;
            this.btnAddSaveDirectory.Text = "Add Save Directory";
            this.btnAddSaveDirectory.UseVisualStyleBackColor = true;
            this.btnAddSaveDirectory.Click += new System.EventHandler(this.btnAddSaveDirectory_Click);
            // 
            // saveSyncTray
            // 
            this.saveSyncTray.Text = "SaveSync";
            this.saveSyncTray.Visible = true;
            // 
            // splitContainerLists
            // 
            this.splitContainerLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLists.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLists.Name = "splitContainerLists";
            // 
            // splitContainerLists.Panel1
            // 
            this.splitContainerLists.Panel1.Controls.Add(this.saveDirListBox);
            // 
            // splitContainerLists.Panel2
            // 
            this.splitContainerLists.Panel2.Controls.Add(this.syncDirListBox);
            this.splitContainerLists.Size = new System.Drawing.Size(481, 176);
            this.splitContainerLists.SplitterDistance = 239;
            this.splitContainerLists.TabIndex = 1;
            // 
            // saveDirListBox
            // 
            this.saveDirListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveDirListBox.FormattingEnabled = true;
            this.saveDirListBox.ItemHeight = 15;
            this.saveDirListBox.Location = new System.Drawing.Point(0, 0);
            this.saveDirListBox.Name = "saveDirListBox";
            this.saveDirListBox.Size = new System.Drawing.Size(239, 176);
            this.saveDirListBox.TabIndex = 0;
            // 
            // syncDirListBox
            // 
            this.syncDirListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.syncDirListBox.FormattingEnabled = true;
            this.syncDirListBox.ItemHeight = 15;
            this.syncDirListBox.Location = new System.Drawing.Point(0, 0);
            this.syncDirListBox.Name = "syncDirListBox";
            this.syncDirListBox.Size = new System.Drawing.Size(238, 176);
            this.syncDirListBox.TabIndex = 0;
            // 
            // SaveSyncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 281);
            this.Controls.Add(this.splitContainerLists);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "SaveSyncForm";
            this.Text = "SaveSync";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainerLists.Panel1.ResumeLayout(false);
            this.splitContainerLists.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLists)).EndInit();
            this.splitContainerLists.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnStartService;
        private Button btnStopService;
        private Button btnAddSyncTarget;
        private Button btnAddSaveDirectory;
        private NotifyIcon saveSyncTray;
        private SplitContainer splitContainerLists;
        private ListBox saveDirListBox;
        private ListBox syncDirListBox;
    }
}