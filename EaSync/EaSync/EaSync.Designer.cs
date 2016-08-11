namespace EaSync
{
    partial class EaSync
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EaSync));
            this.SyncBtn = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DestinationFolder = new System.Windows.Forms.TextBox();
            this.SyncFolder = new System.Windows.Forms.TextBox();
            this.DestBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.extensionLabel = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.SyncFolderSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.DestFolderSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.ExtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SyncBtn
            // 
            this.SyncBtn.Location = new System.Drawing.Point(511, 210);
            this.SyncBtn.Name = "SyncBtn";
            this.SyncBtn.Size = new System.Drawing.Size(75, 23);
            this.SyncBtn.TabIndex = 0;
            this.SyncBtn.Text = "Change";
            this.SyncBtn.UseVisualStyleBackColor = true;
            this.SyncBtn.Click += new System.EventHandler(this.SyncBtn_Click);
            // 
            // Lista
            // 
            this.Lista.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 15;
            this.Lista.Location = new System.Drawing.Point(12, 12);
            this.Lista.Name = "Lista";
            this.Lista.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Lista.Size = new System.Drawing.Size(585, 184);
            this.Lista.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sync folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination:";
            // 
            // DestinationFolder
            // 
            this.DestinationFolder.Location = new System.Drawing.Point(81, 241);
            this.DestinationFolder.Name = "DestinationFolder";
            this.DestinationFolder.Size = new System.Drawing.Size(424, 20);
            this.DestinationFolder.TabIndex = 4;
            // 
            // SyncFolder
            // 
            this.SyncFolder.Location = new System.Drawing.Point(81, 210);
            this.SyncFolder.Name = "SyncFolder";
            this.SyncFolder.Size = new System.Drawing.Size(424, 20);
            this.SyncFolder.TabIndex = 4;
            // 
            // DestBtn
            // 
            this.DestBtn.Location = new System.Drawing.Point(511, 239);
            this.DestBtn.Name = "DestBtn";
            this.DestBtn.Size = new System.Drawing.Size(75, 23);
            this.DestBtn.TabIndex = 0;
            this.DestBtn.Text = "Change";
            this.DestBtn.UseVisualStyleBackColor = true;
            this.DestBtn.Click += new System.EventHandler(this.DestBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(143, 268);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(362, 23);
            this.progressBar.TabIndex = 5;
            // 
            // extensionLabel
            // 
            this.extensionLabel.AutoSize = true;
            this.extensionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.extensionLabel.Location = new System.Drawing.Point(12, 272);
            this.extensionLabel.Name = "extensionLabel";
            this.extensionLabel.Size = new System.Drawing.Size(69, 16);
            this.extensionLabel.TabIndex = 6;
            this.extensionLabel.Text = "Extension:";
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartBtn.ForeColor = System.Drawing.Color.Navy;
            this.StartBtn.Location = new System.Drawing.Point(511, 268);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 25);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ExtBox
            // 
            this.ExtBox.Location = new System.Drawing.Point(81, 271);
            this.ExtBox.Name = "ExtBox";
            this.ExtBox.Size = new System.Drawing.Size(56, 20);
            this.ExtBox.TabIndex = 7;
            // 
            // EaSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 298);
            this.Controls.Add(this.ExtBox);
            this.Controls.Add(this.extensionLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.SyncFolder);
            this.Controls.Add(this.DestinationFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.DestBtn);
            this.Controls.Add(this.SyncBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EaSync";
            this.Text = "EaSync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SyncBtn;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DestinationFolder;
        private System.Windows.Forms.TextBox SyncFolder;
        private System.Windows.Forms.Button DestBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label extensionLabel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.FolderBrowserDialog SyncFolderSelector;
        private System.Windows.Forms.FolderBrowserDialog DestFolderSelector;
        private System.Windows.Forms.TextBox ExtBox;
    }
}

