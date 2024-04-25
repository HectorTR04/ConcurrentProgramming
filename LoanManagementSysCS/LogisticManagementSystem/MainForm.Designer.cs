using System.Windows.Forms;

namespace LogisticManagementSystem
{
    partial class MainForm
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
            this.producerSectionBox = new System.Windows.Forms.GroupBox();
            this.bOSCHBox = new System.Windows.Forms.GroupBox();
            this.bOSCHStopBtn = new System.Windows.Forms.Button();
            this.bOSCHStartBtn = new System.Windows.Forms.Button();
            this.bOSCHStatus = new System.Windows.Forms.Label();
            this.bOSCHStatusLabel = new System.Windows.Forms.Label();
            this.razerBox = new System.Windows.Forms.GroupBox();
            this.razerStopBtn = new System.Windows.Forms.Button();
            this.razerStartBtn = new System.Windows.Forms.Button();
            this.razerStatus = new System.Windows.Forms.Label();
            this.razerStatusLabel = new System.Windows.Forms.Label();
            this.lantmannenBox = new System.Windows.Forms.GroupBox();
            this.lantmannenStopBtn = new System.Windows.Forms.Button();
            this.lantmannenStartBtn = new System.Windows.Forms.Button();
            this.lantmannenStatus = new System.Windows.Forms.Label();
            this.lantmannenStatusLabel = new System.Windows.Forms.Label();
            this.consumerSectionBox = new System.Windows.Forms.GroupBox();
            this.clasOhlsonBox = new System.Windows.Forms.GroupBox();
            this.clasOhlsonListbox = new System.Windows.Forms.ListBox();
            this.clasOhlsonStopBtn = new System.Windows.Forms.Button();
            this.clasOhlsonStartBtn = new System.Windows.Forms.Button();
            this.clasOhlsonCheckbox = new System.Windows.Forms.CheckBox();
            this.clasOhlsonStatusLabel = new System.Windows.Forms.Label();
            this.clasOhlsonStatus = new System.Windows.Forms.Label();
            this.elgigantenBox = new System.Windows.Forms.GroupBox();
            this.elgigantenListBox = new System.Windows.Forms.ListBox();
            this.elgigantenStopBtn = new System.Windows.Forms.Button();
            this.elgigantenStartBtn = new System.Windows.Forms.Button();
            this.elgigantenCheckbox = new System.Windows.Forms.CheckBox();
            this.elgigantenStatusLabel = new System.Windows.Forms.Label();
            this.elgigantenStatus = new System.Windows.Forms.Label();
            this.icaSectionBox = new System.Windows.Forms.GroupBox();
            this.icaListBox = new System.Windows.Forms.ListBox();
            this.icaStopButton = new System.Windows.Forms.Button();
            this.icaStartBtn = new System.Windows.Forms.Button();
            this.icaCheckbox = new System.Windows.Forms.CheckBox();
            this.icaStatusLabel = new System.Windows.Forms.Label();
            this.icaStatus = new System.Windows.Forms.Label();
            this.storageSectionBox = new System.Windows.Forms.GroupBox();
            this.lblItemsProduced = new System.Windows.Forms.Label();
            this.progressItems = new System.Windows.Forms.ProgressBar();
            this.maxCapacityLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.producerSectionBox.SuspendLayout();
            this.bOSCHBox.SuspendLayout();
            this.razerBox.SuspendLayout();
            this.lantmannenBox.SuspendLayout();
            this.consumerSectionBox.SuspendLayout();
            this.clasOhlsonBox.SuspendLayout();
            this.elgigantenBox.SuspendLayout();
            this.icaSectionBox.SuspendLayout();
            this.storageSectionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // producerSectionBox
            // 
            this.producerSectionBox.Controls.Add(this.bOSCHBox);
            this.producerSectionBox.Controls.Add(this.razerBox);
            this.producerSectionBox.Controls.Add(this.lantmannenBox);
            this.producerSectionBox.Location = new System.Drawing.Point(17, 16);
            this.producerSectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.producerSectionBox.Name = "producerSectionBox";
            this.producerSectionBox.Padding = new System.Windows.Forms.Padding(4);
            this.producerSectionBox.Size = new System.Drawing.Size(305, 466);
            this.producerSectionBox.TabIndex = 0;
            this.producerSectionBox.TabStop = false;
            this.producerSectionBox.Text = "Producers";
            // 
            // bOSCHBox
            // 
            this.bOSCHBox.Controls.Add(this.bOSCHStopBtn);
            this.bOSCHBox.Controls.Add(this.bOSCHStartBtn);
            this.bOSCHBox.Controls.Add(this.bOSCHStatus);
            this.bOSCHBox.Controls.Add(this.bOSCHStatusLabel);
            this.bOSCHBox.Location = new System.Drawing.Point(8, 322);
            this.bOSCHBox.Margin = new System.Windows.Forms.Padding(4);
            this.bOSCHBox.Name = "bOSCHBox";
            this.bOSCHBox.Padding = new System.Windows.Forms.Padding(4);
            this.bOSCHBox.Size = new System.Drawing.Size(289, 123);
            this.bOSCHBox.TabIndex = 2;
            this.bOSCHBox.TabStop = false;
            this.bOSCHBox.Text = "BOSCH";
            // 
            // bOSCHStopBtn
            // 
            this.bOSCHStopBtn.Enabled = false;
            this.bOSCHStopBtn.Location = new System.Drawing.Point(199, 73);
            this.bOSCHStopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.bOSCHStopBtn.Name = "bOSCHStopBtn";
            this.bOSCHStopBtn.Size = new System.Drawing.Size(64, 28);
            this.bOSCHStopBtn.TabIndex = 3;
            this.bOSCHStopBtn.Text = "Stop";
            this.bOSCHStopBtn.UseVisualStyleBackColor = true;
            this.bOSCHStopBtn.Click += new System.EventHandler(this.BOSCHStopBtn_Click);
            // 
            // bOSCHStartBtn
            // 
            this.bOSCHStartBtn.Enabled = false;
            this.bOSCHStartBtn.Location = new System.Drawing.Point(39, 73);
            this.bOSCHStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.bOSCHStartBtn.Name = "bOSCHStartBtn";
            this.bOSCHStartBtn.Size = new System.Drawing.Size(132, 28);
            this.bOSCHStartBtn.TabIndex = 2;
            this.bOSCHStartBtn.Text = "Start Producing";
            this.bOSCHStartBtn.UseVisualStyleBackColor = true;
            this.bOSCHStartBtn.Click += new System.EventHandler(this.BOSCHStartBtn_Click);
            // 
            // bOSCHStatus
            // 
            this.bOSCHStatus.AutoSize = true;
            this.bOSCHStatus.Location = new System.Drawing.Point(107, 38);
            this.bOSCHStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bOSCHStatus.Name = "bOSCHStatus";
            this.bOSCHStatus.Size = new System.Drawing.Size(120, 16);
            this.bOSCHStatus.TabIndex = 1;
            this.bOSCHStatus.Text = "NOT PRODUCING";
            // 
            // bOSCHStatusLabel
            // 
            this.bOSCHStatusLabel.AutoSize = true;
            this.bOSCHStatusLabel.Location = new System.Drawing.Point(57, 38);
            this.bOSCHStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bOSCHStatusLabel.Name = "bOSCHStatusLabel";
            this.bOSCHStatusLabel.Size = new System.Drawing.Size(47, 16);
            this.bOSCHStatusLabel.TabIndex = 0;
            this.bOSCHStatusLabel.Text = "Status:";
            // 
            // razerBox
            // 
            this.razerBox.Controls.Add(this.razerStopBtn);
            this.razerBox.Controls.Add(this.razerStartBtn);
            this.razerBox.Controls.Add(this.razerStatus);
            this.razerBox.Controls.Add(this.razerStatusLabel);
            this.razerBox.Location = new System.Drawing.Point(8, 171);
            this.razerBox.Margin = new System.Windows.Forms.Padding(4);
            this.razerBox.Name = "razerBox";
            this.razerBox.Padding = new System.Windows.Forms.Padding(4);
            this.razerBox.Size = new System.Drawing.Size(289, 123);
            this.razerBox.TabIndex = 1;
            this.razerBox.TabStop = false;
            this.razerBox.Text = "Razer";
            // 
            // razerStopBtn
            // 
            this.razerStopBtn.Enabled = false;
            this.razerStopBtn.Location = new System.Drawing.Point(199, 73);
            this.razerStopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.razerStopBtn.Name = "razerStopBtn";
            this.razerStopBtn.Size = new System.Drawing.Size(64, 28);
            this.razerStopBtn.TabIndex = 3;
            this.razerStopBtn.Text = "Stop";
            this.razerStopBtn.UseVisualStyleBackColor = true;
            this.razerStopBtn.Click += new System.EventHandler(this.RazerStopBtn_Click);
            // 
            // razerStartBtn
            // 
            this.razerStartBtn.Enabled = false;
            this.razerStartBtn.Location = new System.Drawing.Point(39, 73);
            this.razerStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.razerStartBtn.Name = "razerStartBtn";
            this.razerStartBtn.Size = new System.Drawing.Size(132, 28);
            this.razerStartBtn.TabIndex = 2;
            this.razerStartBtn.Text = "Start Producing";
            this.razerStartBtn.UseVisualStyleBackColor = true;
            this.razerStartBtn.Click += new System.EventHandler(this.RazerStartBtn_Click);
            // 
            // razerStatus
            // 
            this.razerStatus.AutoSize = true;
            this.razerStatus.Location = new System.Drawing.Point(107, 38);
            this.razerStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.razerStatus.Name = "razerStatus";
            this.razerStatus.Size = new System.Drawing.Size(120, 16);
            this.razerStatus.TabIndex = 1;
            this.razerStatus.Text = "NOT PRODUCING";
            // 
            // razerStatusLabel
            // 
            this.razerStatusLabel.AutoSize = true;
            this.razerStatusLabel.Location = new System.Drawing.Point(57, 38);
            this.razerStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.razerStatusLabel.Name = "razerStatusLabel";
            this.razerStatusLabel.Size = new System.Drawing.Size(47, 16);
            this.razerStatusLabel.TabIndex = 0;
            this.razerStatusLabel.Text = "Status:";
            // 
            // lantmannenBox
            // 
            this.lantmannenBox.Controls.Add(this.lantmannenStopBtn);
            this.lantmannenBox.Controls.Add(this.lantmannenStartBtn);
            this.lantmannenBox.Controls.Add(this.lantmannenStatus);
            this.lantmannenBox.Controls.Add(this.lantmannenStatusLabel);
            this.lantmannenBox.Location = new System.Drawing.Point(8, 23);
            this.lantmannenBox.Margin = new System.Windows.Forms.Padding(4);
            this.lantmannenBox.Name = "lantmannenBox";
            this.lantmannenBox.Padding = new System.Windows.Forms.Padding(4);
            this.lantmannenBox.Size = new System.Drawing.Size(289, 123);
            this.lantmannenBox.TabIndex = 0;
            this.lantmannenBox.TabStop = false;
            this.lantmannenBox.Text = "Lantmännen";
            // 
            // lantmannenStopBtn
            // 
            this.lantmannenStopBtn.Enabled = false;
            this.lantmannenStopBtn.Location = new System.Drawing.Point(199, 73);
            this.lantmannenStopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.lantmannenStopBtn.Name = "lantmannenStopBtn";
            this.lantmannenStopBtn.Size = new System.Drawing.Size(64, 28);
            this.lantmannenStopBtn.TabIndex = 3;
            this.lantmannenStopBtn.Text = "Stop";
            this.lantmannenStopBtn.UseVisualStyleBackColor = true;
            this.lantmannenStopBtn.Click += new System.EventHandler(this.LantmannenStopBtn_Click);
            // 
            // lantmannenStartBtn
            // 
            this.lantmannenStartBtn.Enabled = false;
            this.lantmannenStartBtn.Location = new System.Drawing.Point(39, 73);
            this.lantmannenStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.lantmannenStartBtn.Name = "lantmannenStartBtn";
            this.lantmannenStartBtn.Size = new System.Drawing.Size(132, 28);
            this.lantmannenStartBtn.TabIndex = 2;
            this.lantmannenStartBtn.Text = "Start Producing";
            this.lantmannenStartBtn.UseVisualStyleBackColor = true;
            this.lantmannenStartBtn.Click += new System.EventHandler(this.LantmannenStartBtn_Click);
            // 
            // lantmannenStatus
            // 
            this.lantmannenStatus.AutoSize = true;
            this.lantmannenStatus.Location = new System.Drawing.Point(107, 38);
            this.lantmannenStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lantmannenStatus.Name = "lantmannenStatus";
            this.lantmannenStatus.Size = new System.Drawing.Size(120, 16);
            this.lantmannenStatus.TabIndex = 1;
            this.lantmannenStatus.Text = "NOT PRODUCING";
            // 
            // lantmannenStatusLabel
            // 
            this.lantmannenStatusLabel.AutoSize = true;
            this.lantmannenStatusLabel.Location = new System.Drawing.Point(57, 38);
            this.lantmannenStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lantmannenStatusLabel.Name = "lantmannenStatusLabel";
            this.lantmannenStatusLabel.Size = new System.Drawing.Size(47, 16);
            this.lantmannenStatusLabel.TabIndex = 0;
            this.lantmannenStatusLabel.Text = "Status:";
            // 
            // consumerSectionBox
            // 
            this.consumerSectionBox.Controls.Add(this.clasOhlsonBox);
            this.consumerSectionBox.Controls.Add(this.elgigantenBox);
            this.consumerSectionBox.Controls.Add(this.icaSectionBox);
            this.consumerSectionBox.Location = new System.Drawing.Point(355, 16);
            this.consumerSectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.consumerSectionBox.Name = "consumerSectionBox";
            this.consumerSectionBox.Padding = new System.Windows.Forms.Padding(4);
            this.consumerSectionBox.Size = new System.Drawing.Size(547, 466);
            this.consumerSectionBox.TabIndex = 1;
            this.consumerSectionBox.TabStop = false;
            this.consumerSectionBox.Text = "Consumers";
            // 
            // clasOhlsonBox
            // 
            this.clasOhlsonBox.Controls.Add(this.clasOhlsonListbox);
            this.clasOhlsonBox.Controls.Add(this.clasOhlsonStopBtn);
            this.clasOhlsonBox.Controls.Add(this.clasOhlsonStartBtn);
            this.clasOhlsonBox.Controls.Add(this.clasOhlsonCheckbox);
            this.clasOhlsonBox.Controls.Add(this.clasOhlsonStatusLabel);
            this.clasOhlsonBox.Controls.Add(this.clasOhlsonStatus);
            this.clasOhlsonBox.Location = new System.Drawing.Point(25, 322);
            this.clasOhlsonBox.Margin = new System.Windows.Forms.Padding(4);
            this.clasOhlsonBox.Name = "clasOhlsonBox";
            this.clasOhlsonBox.Padding = new System.Windows.Forms.Padding(4);
            this.clasOhlsonBox.Size = new System.Drawing.Size(513, 123);
            this.clasOhlsonBox.TabIndex = 2;
            this.clasOhlsonBox.TabStop = false;
            this.clasOhlsonBox.Text = "Clas Ohlson";
            // 
            // clasOhlsonListbox
            // 
            this.clasOhlsonListbox.FormattingEnabled = true;
            this.clasOhlsonListbox.ItemHeight = 16;
            this.clasOhlsonListbox.Location = new System.Drawing.Point(208, 28);
            this.clasOhlsonListbox.Margin = new System.Windows.Forms.Padding(4);
            this.clasOhlsonListbox.Name = "clasOhlsonListbox";
            this.clasOhlsonListbox.Size = new System.Drawing.Size(286, 84);
            this.clasOhlsonListbox.TabIndex = 8;
            // 
            // clasOhlsonStopBtn
            // 
            this.clasOhlsonStopBtn.Enabled = false;
            this.clasOhlsonStopBtn.Location = new System.Drawing.Point(138, 87);
            this.clasOhlsonStopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clasOhlsonStopBtn.Name = "clasOhlsonStopBtn";
            this.clasOhlsonStopBtn.Size = new System.Drawing.Size(53, 28);
            this.clasOhlsonStopBtn.TabIndex = 7;
            this.clasOhlsonStopBtn.Text = "Stop";
            this.clasOhlsonStopBtn.UseVisualStyleBackColor = true;
            this.clasOhlsonStopBtn.Click += new System.EventHandler(this.ClasOhlsonStopBtn_Click);
            // 
            // clasOhlsonStartBtn
            // 
            this.clasOhlsonStartBtn.Enabled = false;
            this.clasOhlsonStartBtn.Location = new System.Drawing.Point(20, 84);
            this.clasOhlsonStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clasOhlsonStartBtn.Name = "clasOhlsonStartBtn";
            this.clasOhlsonStartBtn.Size = new System.Drawing.Size(108, 28);
            this.clasOhlsonStartBtn.TabIndex = 6;
            this.clasOhlsonStartBtn.Text = "Start Loading";
            this.clasOhlsonStartBtn.UseVisualStyleBackColor = true;
            this.clasOhlsonStartBtn.Click += new System.EventHandler(this.ClasOhlsonStartBtn_Click);
            // 
            // clasOhlsonCheckbox
            // 
            this.clasOhlsonCheckbox.AutoSize = true;
            this.clasOhlsonCheckbox.Location = new System.Drawing.Point(20, 56);
            this.clasOhlsonCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.clasOhlsonCheckbox.Name = "clasOhlsonCheckbox";
            this.clasOhlsonCheckbox.Size = new System.Drawing.Size(111, 20);
            this.clasOhlsonCheckbox.TabIndex = 5;
            this.clasOhlsonCheckbox.Text = "Continue load";
            this.clasOhlsonCheckbox.UseVisualStyleBackColor = true;
            // 
            // clasOhlsonStatusLabel
            // 
            this.clasOhlsonStatusLabel.AutoSize = true;
            this.clasOhlsonStatusLabel.Location = new System.Drawing.Point(9, 28);
            this.clasOhlsonStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clasOhlsonStatusLabel.Name = "clasOhlsonStatusLabel";
            this.clasOhlsonStatusLabel.Size = new System.Drawing.Size(47, 16);
            this.clasOhlsonStatusLabel.TabIndex = 4;
            this.clasOhlsonStatusLabel.Text = "Status:";
            // 
            // clasOhlsonStatus
            // 
            this.clasOhlsonStatus.AutoSize = true;
            this.clasOhlsonStatus.Location = new System.Drawing.Point(58, 28);
            this.clasOhlsonStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clasOhlsonStatus.Name = "clasOhlsonStatus";
            this.clasOhlsonStatus.Size = new System.Drawing.Size(121, 16);
            this.clasOhlsonStatus.TabIndex = 3;
            this.clasOhlsonStatus.Text = "NOT CONSUMING";
            // 
            // elgigantenBox
            // 
            this.elgigantenBox.Controls.Add(this.elgigantenListBox);
            this.elgigantenBox.Controls.Add(this.elgigantenStopBtn);
            this.elgigantenBox.Controls.Add(this.elgigantenStartBtn);
            this.elgigantenBox.Controls.Add(this.elgigantenCheckbox);
            this.elgigantenBox.Controls.Add(this.elgigantenStatusLabel);
            this.elgigantenBox.Controls.Add(this.elgigantenStatus);
            this.elgigantenBox.Location = new System.Drawing.Point(25, 171);
            this.elgigantenBox.Margin = new System.Windows.Forms.Padding(4);
            this.elgigantenBox.Name = "elgigantenBox";
            this.elgigantenBox.Padding = new System.Windows.Forms.Padding(4);
            this.elgigantenBox.Size = new System.Drawing.Size(513, 123);
            this.elgigantenBox.TabIndex = 1;
            this.elgigantenBox.TabStop = false;
            this.elgigantenBox.Text = "Elgiganten";
            // 
            // elgigantenListBox
            // 
            this.elgigantenListBox.FormattingEnabled = true;
            this.elgigantenListBox.ItemHeight = 16;
            this.elgigantenListBox.Location = new System.Drawing.Point(208, 31);
            this.elgigantenListBox.Margin = new System.Windows.Forms.Padding(4);
            this.elgigantenListBox.Name = "elgigantenListBox";
            this.elgigantenListBox.Size = new System.Drawing.Size(286, 84);
            this.elgigantenListBox.TabIndex = 8;
            // 
            // elgigantenStopBtn
            // 
            this.elgigantenStopBtn.Enabled = false;
            this.elgigantenStopBtn.Location = new System.Drawing.Point(138, 87);
            this.elgigantenStopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.elgigantenStopBtn.Name = "elgigantenStopBtn";
            this.elgigantenStopBtn.Size = new System.Drawing.Size(53, 28);
            this.elgigantenStopBtn.TabIndex = 7;
            this.elgigantenStopBtn.Text = "Stop";
            this.elgigantenStopBtn.UseVisualStyleBackColor = true;
            this.elgigantenStopBtn.Click += new System.EventHandler(this.ElgigantenStopBtn_Click);
            // 
            // elgigantenStartBtn
            // 
            this.elgigantenStartBtn.Enabled = false;
            this.elgigantenStartBtn.Location = new System.Drawing.Point(20, 87);
            this.elgigantenStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.elgigantenStartBtn.Name = "elgigantenStartBtn";
            this.elgigantenStartBtn.Size = new System.Drawing.Size(108, 28);
            this.elgigantenStartBtn.TabIndex = 6;
            this.elgigantenStartBtn.Text = "Start Loading";
            this.elgigantenStartBtn.UseVisualStyleBackColor = true;
            this.elgigantenStartBtn.Click += new System.EventHandler(this.ElgigantenStartBtn_Click);
            // 
            // elgigantenCheckbox
            // 
            this.elgigantenCheckbox.AutoSize = true;
            this.elgigantenCheckbox.Location = new System.Drawing.Point(20, 56);
            this.elgigantenCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.elgigantenCheckbox.Name = "elgigantenCheckbox";
            this.elgigantenCheckbox.Size = new System.Drawing.Size(111, 20);
            this.elgigantenCheckbox.TabIndex = 5;
            this.elgigantenCheckbox.Text = "Continue load";
            this.elgigantenCheckbox.UseVisualStyleBackColor = true;
            // 
            // elgigantenStatusLabel
            // 
            this.elgigantenStatusLabel.AutoSize = true;
            this.elgigantenStatusLabel.Location = new System.Drawing.Point(9, 28);
            this.elgigantenStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.elgigantenStatusLabel.Name = "elgigantenStatusLabel";
            this.elgigantenStatusLabel.Size = new System.Drawing.Size(47, 16);
            this.elgigantenStatusLabel.TabIndex = 4;
            this.elgigantenStatusLabel.Text = "Status:";
            // 
            // elgigantenStatus
            // 
            this.elgigantenStatus.AutoSize = true;
            this.elgigantenStatus.Location = new System.Drawing.Point(58, 28);
            this.elgigantenStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.elgigantenStatus.Name = "elgigantenStatus";
            this.elgigantenStatus.Size = new System.Drawing.Size(121, 16);
            this.elgigantenStatus.TabIndex = 3;
            this.elgigantenStatus.Text = "NOT CONSUMING";
            // 
            // icaSectionBox
            // 
            this.icaSectionBox.Controls.Add(this.icaListBox);
            this.icaSectionBox.Controls.Add(this.icaStopButton);
            this.icaSectionBox.Controls.Add(this.icaStartBtn);
            this.icaSectionBox.Controls.Add(this.icaCheckbox);
            this.icaSectionBox.Controls.Add(this.icaStatusLabel);
            this.icaSectionBox.Controls.Add(this.icaStatus);
            this.icaSectionBox.Location = new System.Drawing.Point(25, 23);
            this.icaSectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.icaSectionBox.Name = "icaSectionBox";
            this.icaSectionBox.Padding = new System.Windows.Forms.Padding(4);
            this.icaSectionBox.Size = new System.Drawing.Size(513, 123);
            this.icaSectionBox.TabIndex = 0;
            this.icaSectionBox.TabStop = false;
            this.icaSectionBox.Text = "ICA";
            // 
            // icaListBox
            // 
            this.icaListBox.FormattingEnabled = true;
            this.icaListBox.ItemHeight = 16;
            this.icaListBox.Location = new System.Drawing.Point(208, 23);
            this.icaListBox.Margin = new System.Windows.Forms.Padding(4);
            this.icaListBox.Name = "icaListBox";
            this.icaListBox.Size = new System.Drawing.Size(286, 84);
            this.icaListBox.TabIndex = 8;
            // 
            // icaStopButton
            // 
            this.icaStopButton.Enabled = false;
            this.icaStopButton.Location = new System.Drawing.Point(138, 78);
            this.icaStopButton.Margin = new System.Windows.Forms.Padding(4);
            this.icaStopButton.Name = "icaStopButton";
            this.icaStopButton.Size = new System.Drawing.Size(53, 28);
            this.icaStopButton.TabIndex = 7;
            this.icaStopButton.Text = "Stop";
            this.icaStopButton.UseVisualStyleBackColor = true;
            this.icaStopButton.Click += new System.EventHandler(this.IcaStopButton_Click);
            // 
            // icaStartBtn
            // 
            this.icaStartBtn.Enabled = false;
            this.icaStartBtn.Location = new System.Drawing.Point(20, 78);
            this.icaStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.icaStartBtn.Name = "icaStartBtn";
            this.icaStartBtn.Size = new System.Drawing.Size(108, 28);
            this.icaStartBtn.TabIndex = 6;
            this.icaStartBtn.Text = "Start Loading";
            this.icaStartBtn.UseVisualStyleBackColor = true;
            this.icaStartBtn.Click += new System.EventHandler(this.IcaStartBtn_Click);
            // 
            // icaCheckbox
            // 
            this.icaCheckbox.AutoSize = true;
            this.icaCheckbox.Location = new System.Drawing.Point(20, 47);
            this.icaCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.icaCheckbox.Name = "icaCheckbox";
            this.icaCheckbox.Size = new System.Drawing.Size(111, 20);
            this.icaCheckbox.TabIndex = 5;
            this.icaCheckbox.Text = "Continue load";
            this.icaCheckbox.UseVisualStyleBackColor = true;
            // 
            // icaStatusLabel
            // 
            this.icaStatusLabel.AutoSize = true;
            this.icaStatusLabel.Location = new System.Drawing.Point(9, 19);
            this.icaStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.icaStatusLabel.Name = "icaStatusLabel";
            this.icaStatusLabel.Size = new System.Drawing.Size(47, 16);
            this.icaStatusLabel.TabIndex = 4;
            this.icaStatusLabel.Text = "Status:";
            // 
            // icaStatus
            // 
            this.icaStatus.AutoSize = true;
            this.icaStatus.Location = new System.Drawing.Point(58, 19);
            this.icaStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.icaStatus.Name = "icaStatus";
            this.icaStatus.Size = new System.Drawing.Size(121, 16);
            this.icaStatus.TabIndex = 3;
            this.icaStatus.Text = "NOT CONSUMING";
            // 
            // storageSectionBox
            // 
            this.storageSectionBox.Controls.Add(this.lblItemsProduced);
            this.storageSectionBox.Controls.Add(this.progressItems);
            this.storageSectionBox.Controls.Add(this.maxCapacityLabel);
            this.storageSectionBox.Location = new System.Drawing.Point(135, 490);
            this.storageSectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.storageSectionBox.Name = "storageSectionBox";
            this.storageSectionBox.Padding = new System.Windows.Forms.Padding(4);
            this.storageSectionBox.Size = new System.Drawing.Size(767, 101);
            this.storageSectionBox.TabIndex = 2;
            this.storageSectionBox.TabStop = false;
            this.storageSectionBox.Text = "Storage";
            // 
            // lblItemsProduced
            // 
            this.lblItemsProduced.AutoSize = true;
            this.lblItemsProduced.Location = new System.Drawing.Point(672, 19);
            this.lblItemsProduced.Name = "lblItemsProduced";
            this.lblItemsProduced.Size = new System.Drawing.Size(67, 16);
            this.lblItemsProduced.TabIndex = 9;
            this.lblItemsProduced.Text = "Max items";
            this.lblItemsProduced.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressItems
            // 
            this.progressItems.ForeColor = System.Drawing.Color.Blue;
            this.progressItems.Location = new System.Drawing.Point(207, 46);
            this.progressItems.Margin = new System.Windows.Forms.Padding(4);
            this.progressItems.Maximum = 20;
            this.progressItems.Name = "progressItems";
            this.progressItems.Size = new System.Drawing.Size(532, 28);
            this.progressItems.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressItems.TabIndex = 2;
            // 
            // maxCapacityLabel
            // 
            this.maxCapacityLabel.AutoSize = true;
            this.maxCapacityLabel.Location = new System.Drawing.Point(8, 52);
            this.maxCapacityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxCapacityLabel.Name = "maxCapacityLabel";
            this.maxCapacityLabel.Size = new System.Drawing.Size(132, 16);
            this.maxCapacityLabel.TabIndex = 1;
            this.maxCapacityLabel.Text = "Max capacity (items):";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(12, 502);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(117, 74);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Start System";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 599);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.storageSectionBox);
            this.Controls.Add(this.consumerSectionBox);
            this.Controls.Add(this.producerSectionBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logistics Management System";
            this.producerSectionBox.ResumeLayout(false);
            this.bOSCHBox.ResumeLayout(false);
            this.bOSCHBox.PerformLayout();
            this.razerBox.ResumeLayout(false);
            this.razerBox.PerformLayout();
            this.lantmannenBox.ResumeLayout(false);
            this.lantmannenBox.PerformLayout();
            this.consumerSectionBox.ResumeLayout(false);
            this.clasOhlsonBox.ResumeLayout(false);
            this.clasOhlsonBox.PerformLayout();
            this.elgigantenBox.ResumeLayout(false);
            this.elgigantenBox.PerformLayout();
            this.icaSectionBox.ResumeLayout(false);
            this.icaSectionBox.PerformLayout();
            this.storageSectionBox.ResumeLayout(false);
            this.storageSectionBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox producerSectionBox;
        private System.Windows.Forms.GroupBox consumerSectionBox;
        private System.Windows.Forms.GroupBox storageSectionBox;
        private System.Windows.Forms.ProgressBar progressItems;
        private System.Windows.Forms.Label maxCapacityLabel;
        private System.Windows.Forms.GroupBox lantmannenBox;
        private System.Windows.Forms.Button lantmannenStopBtn;
        private System.Windows.Forms.Button lantmannenStartBtn;
        private System.Windows.Forms.Label lantmannenStatusLabel;
        private System.Windows.Forms.Label lantmannenStatus;
        private System.Windows.Forms.GroupBox bOSCHBox;
        private System.Windows.Forms.Button bOSCHStopBtn;
        private System.Windows.Forms.Button bOSCHStartBtn;
        private System.Windows.Forms.Label bOSCHStatus;
        private System.Windows.Forms.Label bOSCHStatusLabel;
        private System.Windows.Forms.GroupBox razerBox;
        private System.Windows.Forms.Button razerStopBtn;
        private System.Windows.Forms.Button razerStartBtn;
        private System.Windows.Forms.Label razerStatus;
        private System.Windows.Forms.Label razerStatusLabel;
        private System.Windows.Forms.GroupBox icaSectionBox;
        private System.Windows.Forms.ListBox icaListBox;
        private System.Windows.Forms.Button icaStopButton;
        private System.Windows.Forms.Button icaStartBtn;
        private System.Windows.Forms.CheckBox icaCheckbox;
        private System.Windows.Forms.Label icaStatusLabel;
        private System.Windows.Forms.Label icaStatus;
        private System.Windows.Forms.GroupBox clasOhlsonBox;
        private System.Windows.Forms.ListBox clasOhlsonListbox;
        private System.Windows.Forms.Button clasOhlsonStopBtn;
        private System.Windows.Forms.Button clasOhlsonStartBtn;
        private System.Windows.Forms.CheckBox clasOhlsonCheckbox;
        private System.Windows.Forms.Label clasOhlsonStatusLabel;
        private System.Windows.Forms.Label clasOhlsonStatus;
        private System.Windows.Forms.GroupBox elgigantenBox;
        private System.Windows.Forms.ListBox elgigantenListBox;
        private System.Windows.Forms.Button elgigantenStopBtn;
        private System.Windows.Forms.Button elgigantenStartBtn;
        private System.Windows.Forms.CheckBox elgigantenCheckbox;
        private System.Windows.Forms.Label elgigantenStatusLabel;
        private System.Windows.Forms.Label elgigantenStatus;
        private System.Windows.Forms.Label lblItemsProduced;
        private System.Windows.Forms.Button startBtn;

        public Button StartButton { get { return startBtn; } set { startBtn = value; } }
        public GroupBox ProducerSectionBox { get { return producerSectionBox; } set { producerSectionBox = value; } }
        public GroupBox ConsumerSectionBox { get { return consumerSectionBox; } set { consumerSectionBox = value; } }
        public GroupBox StorageSectionBox { get { return storageSectionBox; } set { storageSectionBox = value; } }
        public ProgressBar ProgressItems { get { return progressItems; } set { progressItems = value; } }
        public Label MaxCapacityLabel { get { return maxCapacityLabel; } set { maxCapacityLabel = value; } }
        public GroupBox LantmannenBox { get { return lantmannenBox; } set { lantmannenBox = value; } }
        public Button LantmannenStopBtn { get { return lantmannenStopBtn; } set { lantmannenStopBtn = value; } }
        public Button LantmannenStartBtn { get { return lantmannenStartBtn; } set { lantmannenStartBtn = value; } }
        public Label LantmannenStatusLabel { get { return lantmannenStatusLabel; } set { lantmannenStatusLabel = value; } }
        public Label LantmannenStatus { get { return lantmannenStatus; } set { lantmannenStatus = value; } }
        public GroupBox BOSCHBox { get { return bOSCHBox; } set { bOSCHBox = value; } }
        public Button BOSCHStopBtn { get { return bOSCHStopBtn; } set { bOSCHStopBtn = value; } }
        public Button BOSCHStartBtn { get { return bOSCHStartBtn; } set { bOSCHStartBtn = value; } }
        public Label BOSCHStatus { get { return bOSCHStatus; } set { bOSCHStatus = value; } }
        public Label BOSCHStatusLabel { get { return bOSCHStatusLabel; } set { bOSCHStatusLabel = value; } }
        public GroupBox RazerBox { get { return razerBox; } set { razerBox = value; } }
        public Button RazerStopBtn { get { return razerStopBtn; } set { razerStopBtn = value; } }
        public Button RazerStartBtn { get { return razerStartBtn; } set { razerStartBtn = value; } }
        public Label RazerStatus { get { return razerStatus; } set { razerStatus = value; } }
        public Label RazerStatusLabel { get { return razerStatusLabel; } set { razerStatusLabel = value; } }
        public GroupBox IcaSectionBox { get { return icaSectionBox; } set { icaSectionBox = value; } }
        public ListBox IcaListBox { get { return icaListBox; } set { icaListBox = value; } }
        public Button IcaStopButton { get { return icaStopButton; } set { icaStopButton = value; } }
        public Button IcaStartBtn { get { return icaStartBtn; } set { icaStartBtn = value; } }
        public CheckBox IcaCheckbox { get { return icaCheckbox; } set { icaCheckbox = value; } }
        public Label IcaStatusLabel { get { return icaStatusLabel; } set { icaStatusLabel = value; } }
        public Label IcaStatus { get { return icaStatus; } set { icaStatus = value; } }
        public GroupBox ClasOhlsonBox { get { return clasOhlsonBox; } set { clasOhlsonBox = value; } }
        public ListBox ClasOhlsonListbox { get { return clasOhlsonListbox; } set { clasOhlsonListbox = value; } }
        public Button ClasOhlsonStopBtn { get { return clasOhlsonStopBtn; } set { clasOhlsonStopBtn = value; } }
        public Button ClasOhlsonStartBtn { get { return clasOhlsonStartBtn; } set { clasOhlsonStartBtn = value; } }
        public CheckBox ClasOhlsonCheckbox { get { return clasOhlsonCheckbox; } set { clasOhlsonCheckbox = value; } }
        public Label ClasOhlsonStatusLabel { get { return clasOhlsonStatusLabel; } set { clasOhlsonStatusLabel = value; } }
        public Label ClasOhlsonStatus { get { return clasOhlsonStatus; } set { clasOhlsonStatus = value; } }
        public GroupBox ElgigantenBox { get { return elgigantenBox; } set { elgigantenBox = value; } }
        public ListBox ElgigantenListBox { get { return elgigantenListBox; } set { elgigantenListBox = value; } }
        public Button ElgigantenStopBtn { get { return elgigantenStopBtn; } set { elgigantenStopBtn = value; } }
        public Button ElgigantenStartBtn { get { return elgigantenStartBtn; } set { elgigantenStartBtn = value; } }
        public CheckBox ElgigantenCheckbox { get { return elgigantenCheckbox; } set { elgigantenCheckbox = value; } }
        public Label ElgigantenStatusLabel { get { return elgigantenStatusLabel; } set { elgigantenStatusLabel = value; } }
        public Label ElgigantenStatus { get { return elgigantenStatus; } set { elgigantenStatus = value; } }
        public Label LblItemsProduced { get { return lblItemsProduced; } set { lblItemsProduced = value; } }


    }
}

