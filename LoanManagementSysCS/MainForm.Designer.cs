namespace LoanManagementSys
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
            btnOK = new Button();
            lstOutput = new ListBox();
            btnStop = new Button();
            lstItems = new ListBox();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(129, 648);
            btnOK.Margin = new Padding(2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(203, 52);
            btnOK.TabIndex = 0;
            btnOK.Text = "Start";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lstOutput
            // 
            lstOutput.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lstOutput.FormattingEnabled = true;
            lstOutput.ItemHeight = 20;
            lstOutput.Location = new Point(22, 11);
            lstOutput.Margin = new Padding(3, 4, 3, 4);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(714, 604);
            lstOutput.TabIndex = 1;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(360, 648);
            btnStop.Margin = new Padding(3, 4, 3, 4);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(203, 52);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // lstItems
            // 
            lstItems.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 20;
            lstItems.Location = new Point(763, 11);
            lstItems.Margin = new Padding(2);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(484, 604);
            lstItems.TabIndex = 4;
            lstItems.SelectedIndexChanged += lstItems_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 714);
            Controls.Add(lstItems);
            Controls.Add(btnStop);
            Controls.Add(lstOutput);
            Controls.Add(btnOK);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Equipment Loaning System";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnOK;
        private ListBox lstOutput;
        private Button btnStop;
        private ListBox lstItems;

        public ListBox ListItems
        {
            get { return lstItems; }
        }
        public ListBox ListOutput
        {
            get { return lstOutput; }
        }
    }
}
