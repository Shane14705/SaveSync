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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveSyncForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStartService = new System.Windows.Forms.Button();
            this.btnStopService = new System.Windows.Forms.Button();
            this.btnPickSyncTarget = new System.Windows.Forms.Button();
            this.btnPickSaveDirectory = new System.Windows.Forms.Button();
            this.labelServiceStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnStartService, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStopService, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPickSyncTarget, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPickSaveDirectory, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 480);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1167, 287);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnStartService
            // 
            this.btnStartService.AutoSize = true;
            this.btnStartService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartService.Location = new System.Drawing.Point(3, 146);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(577, 138);
            this.btnStartService.TabIndex = 0;
            this.btnStartService.Text = "Start Service";
            this.btnStartService.UseVisualStyleBackColor = true;
            this.btnStartService.Click += new System.EventHandler(this.btnStartService_Click);
            // 
            // btnStopService
            // 
            this.btnStopService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStopService.Location = new System.Drawing.Point(586, 146);
            this.btnStopService.Name = "btnStopService";
            this.btnStopService.Size = new System.Drawing.Size(578, 138);
            this.btnStopService.TabIndex = 1;
            this.btnStopService.Text = "Stop Service";
            this.btnStopService.UseVisualStyleBackColor = true;
            this.btnStopService.Click += new System.EventHandler(this.btnStopService_Click);
            // 
            // btnPickSyncTarget
            // 
            this.btnPickSyncTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPickSyncTarget.Location = new System.Drawing.Point(586, 3);
            this.btnPickSyncTarget.Name = "btnPickSyncTarget";
            this.btnPickSyncTarget.Size = new System.Drawing.Size(578, 137);
            this.btnPickSyncTarget.TabIndex = 2;
            this.btnPickSyncTarget.Text = "Pick Sync Target";
            this.btnPickSyncTarget.UseVisualStyleBackColor = true;
            this.btnPickSyncTarget.Click += new System.EventHandler(this.btnPickSyncTarget_Click);
            // 
            // btnPickSaveDirectory
            // 
            this.btnPickSaveDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPickSaveDirectory.Location = new System.Drawing.Point(3, 3);
            this.btnPickSaveDirectory.Name = "btnPickSaveDirectory";
            this.btnPickSaveDirectory.Size = new System.Drawing.Size(577, 137);
            this.btnPickSaveDirectory.TabIndex = 3;
            this.btnPickSaveDirectory.Text = "Pick Save Directory";
            this.btnPickSaveDirectory.UseVisualStyleBackColor = true;
            this.btnPickSaveDirectory.Click += new System.EventHandler(this.btnPickSaveDirectory_Click);
            // 
            // labelServiceStatus
            // 
            this.labelServiceStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelServiceStatus.AutoSize = true;
            this.labelServiceStatus.Location = new System.Drawing.Point(420, 237);
            this.labelServiceStatus.Margin = new System.Windows.Forms.Padding(0);
            this.labelServiceStatus.Name = "labelServiceStatus";
            this.labelServiceStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelServiceStatus.Size = new System.Drawing.Size(327, 41);
            this.labelServiceStatus.TabIndex = 1;
            this.labelServiceStatus.Text = "Service Status: Stopped";
            // 
            // SaveSyncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 767);
            this.Controls.Add(this.labelServiceStatus);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaveSyncForm";
            this.Text = "SaveSync";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnStartService;
        private Button btnStopService;
        private Button btnPickSyncTarget;
        private Button btnPickSaveDirectory;
        private Label labelServiceStatus;
    }
}