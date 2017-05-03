namespace sfxBrowser
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.fileTree = new System.Windows.Forms.TreeView();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.volume = new System.Windows.Forms.TrackBar();
            this.btnOGG = new System.Windows.Forms.CheckBox();
            this.btnLoop = new System.Windows.Forms.CheckBox();
            this.btnAutoPlay = new System.Windows.Forms.CheckBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnMP3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWAV = new System.Windows.Forms.CheckBox();
            this.btnCopyTo = new System.Windows.Forms.Button();
            this.btnOpenLocation = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtFileNameFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.speed = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playerTrack = new System.Windows.Forms.TrackBar();
            this.txtDuration = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtPosition = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "foldericon.bmp");
            this.imageList1.Images.SetKeyName(1, "audioicon.bmp");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search folder for audio files:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(0, 26);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(845, 20);
            this.txtPath.TabIndex = 0;
            // 
            // fileTree
            // 
            this.fileTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTree.HideSelection = false;
            this.fileTree.Location = new System.Drawing.Point(0, 129);
            this.fileTree.Name = "fileTree";
            this.fileTree.Size = new System.Drawing.Size(1092, 402);
            this.fileTree.TabIndex = 2;
            this.fileTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.fileTree_AfterSelect);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(851, 20);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(96, 30);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(17, 129);
            this.volume.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.volume.Maximum = 100;
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(94, 45);
            this.volume.TabIndex = 11;
            this.volume.TickFrequency = 10;
            this.volume.ValueChanged += new System.EventHandler(this.volume_ValueChanged);
            // 
            // btnOGG
            // 
            this.btnOGG.AutoSize = true;
            this.btnOGG.Location = new System.Drawing.Point(159, 67);
            this.btnOGG.Name = "btnOGG";
            this.btnOGG.Size = new System.Drawing.Size(50, 17);
            this.btnOGG.TabIndex = 6;
            this.btnOGG.Text = "OGG";
            this.btnOGG.UseVisualStyleBackColor = true;
            this.btnOGG.CheckedChanged += new System.EventHandler(this.btnOGG_CheckedChanged);
            // 
            // btnLoop
            // 
            this.btnLoop.AutoSize = true;
            this.btnLoop.Location = new System.Drawing.Point(18, 31);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(50, 17);
            this.btnLoop.TabIndex = 9;
            this.btnLoop.Text = "Loop";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.CheckedChanged += new System.EventHandler(this.btnLoop_CheckedChanged);
            // 
            // btnAutoPlay
            // 
            this.btnAutoPlay.AutoSize = true;
            this.btnAutoPlay.Location = new System.Drawing.Point(17, 8);
            this.btnAutoPlay.Name = "btnAutoPlay";
            this.btnAutoPlay.Size = new System.Drawing.Size(67, 17);
            this.btnAutoPlay.TabIndex = 7;
            this.btnAutoPlay.Text = "Autoplay";
            this.btnAutoPlay.UseVisualStyleBackColor = true;
            this.btnAutoPlay.CheckedChanged += new System.EventHandler(this.btnAutoPlay_CheckedChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(17, 67);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(94, 31);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnMP3
            // 
            this.btnMP3.AutoSize = true;
            this.btnMP3.Location = new System.Drawing.Point(105, 68);
            this.btnMP3.Name = "btnMP3";
            this.btnMP3.Size = new System.Drawing.Size(48, 17);
            this.btnMP3.TabIndex = 4;
            this.btnMP3.Text = "MP3";
            this.btnMP3.UseVisualStyleBackColor = true;
            this.btnMP3.CheckedChanged += new System.EventHandler(this.btnMP3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Volume:";
            // 
            // btnWAV
            // 
            this.btnWAV.AutoSize = true;
            this.btnWAV.Location = new System.Drawing.Point(48, 68);
            this.btnWAV.Name = "btnWAV";
            this.btnWAV.Size = new System.Drawing.Size(51, 17);
            this.btnWAV.TabIndex = 5;
            this.btnWAV.Text = "WAV";
            this.btnWAV.UseVisualStyleBackColor = true;
            this.btnWAV.CheckedChanged += new System.EventHandler(this.btnWAV_CheckedChanged);
            // 
            // btnCopyTo
            // 
            this.btnCopyTo.Location = new System.Drawing.Point(17, 278);
            this.btnCopyTo.Name = "btnCopyTo";
            this.btnCopyTo.Size = new System.Drawing.Size(94, 33);
            this.btnCopyTo.TabIndex = 13;
            this.btnCopyTo.Text = "Copy To ...";
            this.btnCopyTo.UseVisualStyleBackColor = true;
            this.btnCopyTo.Click += new System.EventHandler(this.btnCopyTo_Click);
            // 
            // btnOpenLocation
            // 
            this.btnOpenLocation.Location = new System.Drawing.Point(17, 327);
            this.btnOpenLocation.Name = "btnOpenLocation";
            this.btnOpenLocation.Size = new System.Drawing.Size(94, 35);
            this.btnOpenLocation.TabIndex = 14;
            this.btnOpenLocation.Text = "Open location ...";
            this.btnOpenLocation.UseVisualStyleBackColor = true;
            this.btnOpenLocation.Click += new System.EventHandler(this.btnOpenLocation_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(851, 58);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 31);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtFileNameFilter
            // 
            this.txtFileNameFilter.Location = new System.Drawing.Point(332, 64);
            this.txtFileNameFilter.Name = "txtFileNameFilter";
            this.txtFileNameFilter.Size = new System.Drawing.Size(513, 20);
            this.txtFileNameFilter.TabIndex = 16;
            this.txtFileNameFilter.TextChanged += new System.EventHandler(this.txtFileNameFilter_TextChanged);
            this.txtFileNameFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFileNameFilter_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "List only:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "File name contains:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1218, 545);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.speed);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnAutoPlay);
            this.panel2.Controls.Add(this.btnLoop);
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Controls.Add(this.volume);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCopyTo);
            this.panel2.Controls.Add(this.btnOpenLocation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1101, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 539);
            this.panel2.TabIndex = 1;
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(17, 198);
            this.speed.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.speed.Maximum = 100;
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(94, 45);
            this.speed.TabIndex = 15;
            this.speed.TickFrequency = 10;
            this.speed.ValueChanged += new System.EventHandler(this.speed_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Speed:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.txtPosition);
            this.panel1.Controls.Add(this.playerTrack);
            this.panel1.Controls.Add(this.txtDuration);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnOGG);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnMP3);
            this.panel1.Controls.Add(this.txtFileNameFilter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.btnWAV);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.fileTree);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 539);
            this.panel1.TabIndex = 0;
            // 
            // playerTrack
            // 
            this.playerTrack.AutoSize = false;
            this.playerTrack.Location = new System.Drawing.Point(105, 99);
            this.playerTrack.Name = "playerTrack";
            this.playerTrack.Size = new System.Drawing.Size(221, 24);
            this.playerTrack.TabIndex = 21;
            this.playerTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.playerTrack.Scroll += new System.EventHandler(this.playerTrack_Scroll);
            // 
            // txtDuration
            // 
            this.txtDuration.AutoSize = true;
            this.txtDuration.Location = new System.Drawing.Point(50, 102);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(49, 13);
            this.txtDuration.TabIndex = 20;
            this.txtDuration.Text = "00:00:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Duration:";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtPosition
            // 
            this.txtPosition.AutoSize = true;
            this.txtPosition.Location = new System.Drawing.Point(332, 102);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(49, 13);
            this.txtPosition.TabIndex = 22;
            this.txtPosition.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1263, 569);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Sound Effect file browser";
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TreeView fileTree;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnOpenLocation;
        private System.Windows.Forms.Button btnCopyTo;
        private System.Windows.Forms.CheckBox btnWAV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox btnMP3;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.CheckBox btnAutoPlay;
        private System.Windows.Forms.CheckBox btnLoop;
        private System.Windows.Forms.CheckBox btnOGG;
        private System.Windows.Forms.TrackBar volume;
        private System.Windows.Forms.TextBox txtFileNameFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar speed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtDuration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar playerTrack;
        private System.Windows.Forms.Label txtPosition;
    }
}

