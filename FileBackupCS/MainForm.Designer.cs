using System.Drawing;
using System.Windows.Forms;

namespace FileBackup
{
    partial class MainForm
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
            this.lstSource = new System.Windows.Forms.ListBox();
            this.lstTarget = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAsync = new System.Windows.Forms.Button();
            this.dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSource
            // 
            this.lstSource.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.lstSource.FormattingEnabled = true;
            this.lstSource.ItemHeight = 20;
            this.lstSource.Location = new System.Drawing.Point(24, 40);
            this.lstSource.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lstSource.Name = "lstSource";
            this.lstSource.Size = new System.Drawing.Size(699, 304);
            this.lstSource.TabIndex = 0;
            // 
            // lstTarget
            // 
            this.lstTarget.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.lstTarget.FormattingEnabled = true;
            this.lstTarget.ItemHeight = 20;
            this.lstTarget.Location = new System.Drawing.Point(739, 40);
            this.lstTarget.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lstTarget.Name = "lstTarget";
            this.lstTarget.Size = new System.Drawing.Size(724, 304);
            this.lstTarget.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnStart.Location = new System.Drawing.Point(62, 375);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(291, 38);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Run ThreadPool";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAsync
            // 
            this.btnAsync.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnAsync.Location = new System.Drawing.Point(398, 375);
            this.btnAsync.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(291, 38);
            this.btnAsync.TabIndex = 3;
            this.btnAsync.Text = "Run Async";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Files to back-up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label2.Location = new System.Drawing.Point(743, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Files backed-up";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lstTarget);
            this.Controls.Add(this.lstSource);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "MainForm";
            this.Text = "File Processor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ListBox lstSource;
        public ListBox lstTarget;
        private Button btnStart;
        private Button btnAsync;
        private FolderBrowserDialog dialog;
        private Label label1;
        private Label label2;
    }
}
