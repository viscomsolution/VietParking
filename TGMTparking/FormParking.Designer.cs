namespace TGMTparking
{
    partial class FormParking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParking));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_CPU = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_cardReader = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCard = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCountVehicle = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lượtXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchThẻToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_plate1 = new System.Windows.Forms.TextBox();
            this.pictureBox1_2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1_1 = new System.Windows.Forms.PictureBox();
            this.pnVideo1_2 = new System.Windows.Forms.Panel();
            this.pnVideo1_1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_plate2 = new System.Windows.Forms.TextBox();
            this.pictureBox2_2 = new System.Windows.Forms.PictureBox();
            this.pictureBox2_1 = new System.Windows.Forms.PictureBox();
            this.pnVideo2_2 = new System.Windows.Forms.Panel();
            this.pnVideo2_1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ctxtMnu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._recordNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._takePhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._cropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerClear = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_1)).BeginInit();
            this.panel4.SuspendLayout();
            this.ctxtMnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lbl_CPU,
            this.lbl_cardReader,
            this.lblCard,
            this.lblCountVehicle});
            this.statusStrip1.Location = new System.Drawing.Point(0, 673);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1072, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(594, 21);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "Phần mềm giữ xe TGMTparking";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_CPU
            // 
            this.lbl_CPU.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_CPU.ForeColor = System.Drawing.Color.Azure;
            this.lbl_CPU.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lbl_CPU.Name = "lbl_CPU";
            this.lbl_CPU.Size = new System.Drawing.Size(100, 21);
            this.lbl_CPU.Text = "CPU - RAM  |";
            // 
            // lbl_cardReader
            // 
            this.lbl_cardReader.ForeColor = System.Drawing.Color.Azure;
            this.lbl_cardReader.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lbl_cardReader.Name = "lbl_cardReader";
            this.lbl_cardReader.Size = new System.Drawing.Size(112, 21);
            this.lbl_cardReader.Text = "Card reader:... |";
            // 
            // lblCard
            // 
            this.lblCard.ForeColor = System.Drawing.Color.White;
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(136, 21);
            this.lblCard.Text = "Thẻ chưa dùng:...  |";
            // 
            // lblCountVehicle
            // 
            this.lblCountVehicle.ForeColor = System.Drawing.Color.White;
            this.lblCountVehicle.Name = "lblCountVehicle";
            this.lblCountVehicle.Size = new System.Drawing.Size(115, 21);
            this.lblCountVehicle.Text = "Xe trong bãi ... |";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lượtXeToolStripMenuItem,
            this.danhSáchThẻToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1072, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lượtXeToolStripMenuItem
            // 
            this.lượtXeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lượtXeToolStripMenuItem.Name = "lượtXeToolStripMenuItem";
            this.lượtXeToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.lượtXeToolStripMenuItem.Text = "Lượt xe";
            this.lượtXeToolStripMenuItem.Click += new System.EventHandler(this.lượtXeToolStripMenuItem_Click);
            // 
            // danhSáchThẻToolStripMenuItem
            // 
            this.danhSáchThẻToolStripMenuItem.Name = "danhSáchThẻToolStripMenuItem";
            this.danhSáchThẻToolStripMenuItem.Size = new System.Drawing.Size(120, 25);
            this.danhSáchThẻToolStripMenuItem.Text = "Danh sách thẻ";
            this.danhSáchThẻToolStripMenuItem.Click += new System.EventHandler(this.danhSáchThẻToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(93, 25);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(70, 25);
            this.optionToolStripMenuItem.Text = "Option";
            this.optionToolStripMenuItem.Click += new System.EventHandler(this.optionToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_plate1);
            this.panel1.Controls.Add(this.pictureBox1_2);
            this.panel1.Controls.Add(this.pictureBox1_1);
            this.panel1.Controls.Add(this.pnVideo1_2);
            this.panel1.Controls.Add(this.pnVideo1_1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(545, 644);
            this.panel1.TabIndex = 3;
            // 
            // txt_plate1
            // 
            this.txt_plate1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_plate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.txt_plate1.Location = new System.Drawing.Point(135, 466);
            this.txt_plate1.Name = "txt_plate1";
            this.txt_plate1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_plate1.Size = new System.Drawing.Size(280, 60);
            this.txt_plate1.TabIndex = 11;
            this.txt_plate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1_2
            // 
            this.pictureBox1_2.Image = global::TGMTparking.Properties.Resources.in_back;
            this.pictureBox1_2.Location = new System.Drawing.Point(276, 275);
            this.pictureBox1_2.Name = "pictureBox1_2";
            this.pictureBox1_2.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1_2.Size = new System.Drawing.Size(262, 172);
            this.pictureBox1_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1_2.TabIndex = 10;
            this.pictureBox1_2.TabStop = false;
            // 
            // pictureBox1_1
            // 
            this.pictureBox1_1.Image = global::TGMTparking.Properties.Resources.in_front;
            this.pictureBox1_1.Location = new System.Drawing.Point(3, 275);
            this.pictureBox1_1.Name = "pictureBox1_1";
            this.pictureBox1_1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1_1.Size = new System.Drawing.Size(267, 172);
            this.pictureBox1_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1_1.TabIndex = 9;
            this.pictureBox1_1.TabStop = false;
            // 
            // pnVideo1_2
            // 
            this.pnVideo1_2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnVideo1_2.Location = new System.Drawing.Point(276, 62);
            this.pnVideo1_2.Name = "pnVideo1_2";
            this.pnVideo1_2.Padding = new System.Windows.Forms.Padding(3);
            this.pnVideo1_2.Size = new System.Drawing.Size(264, 207);
            this.pnVideo1_2.TabIndex = 6;
            // 
            // pnVideo1_1
            // 
            this.pnVideo1_1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnVideo1_1.Location = new System.Drawing.Point(3, 62);
            this.pnVideo1_1.Name = "pnVideo1_1";
            this.pnVideo1_1.Padding = new System.Windows.Forms.Padding(3);
            this.pnVideo1_1.Size = new System.Drawing.Size(267, 207);
            this.pnVideo1_1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 59);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(202, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Làn vào";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txt_plate2);
            this.panel2.Controls.Add(this.pictureBox2_2);
            this.panel2.Controls.Add(this.pictureBox2_1);
            this.panel2.Controls.Add(this.pnVideo2_2);
            this.panel2.Controls.Add(this.pnVideo2_1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(545, 29);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(527, 644);
            this.panel2.TabIndex = 4;
            // 
            // txt_plate2
            // 
            this.txt_plate2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_plate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_plate2.Location = new System.Drawing.Point(129, 466);
            this.txt_plate2.Name = "txt_plate2";
            this.txt_plate2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_plate2.Size = new System.Drawing.Size(280, 61);
            this.txt_plate2.TabIndex = 12;
            this.txt_plate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2_2
            // 
            this.pictureBox2_2.Image = global::TGMTparking.Properties.Resources.out_back;
            this.pictureBox2_2.Location = new System.Drawing.Point(270, 275);
            this.pictureBox2_2.Name = "pictureBox2_2";
            this.pictureBox2_2.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox2_2.Size = new System.Drawing.Size(254, 172);
            this.pictureBox2_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2_2.TabIndex = 12;
            this.pictureBox2_2.TabStop = false;
            // 
            // pictureBox2_1
            // 
            this.pictureBox2_1.Image = global::TGMTparking.Properties.Resources.out_front;
            this.pictureBox2_1.Location = new System.Drawing.Point(6, 275);
            this.pictureBox2_1.Name = "pictureBox2_1";
            this.pictureBox2_1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox2_1.Size = new System.Drawing.Size(258, 172);
            this.pictureBox2_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2_1.TabIndex = 11;
            this.pictureBox2_1.TabStop = false;
            // 
            // pnVideo2_2
            // 
            this.pnVideo2_2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnVideo2_2.Location = new System.Drawing.Point(270, 62);
            this.pnVideo2_2.Name = "pnVideo2_2";
            this.pnVideo2_2.Padding = new System.Windows.Forms.Padding(3);
            this.pnVideo2_2.Size = new System.Drawing.Size(253, 207);
            this.pnVideo2_2.TabIndex = 6;
            // 
            // pnVideo2_1
            // 
            this.pnVideo2_1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnVideo2_1.Location = new System.Drawing.Point(3, 62);
            this.pnVideo2_1.Name = "pnVideo2_1";
            this.pnVideo2_1.Padding = new System.Windows.Forms.Padding(3);
            this.pnVideo2_1.Size = new System.Drawing.Size(260, 207);
            this.pnVideo2_1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(521, 59);
            this.panel4.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(205, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 46);
            this.label2.TabIndex = 8;
            this.label2.Text = "Làn ra";
            // 
            // ctxtMnu
            // 
            this.ctxtMnu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxtMnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._recordNowToolStripMenuItem,
            this._takePhotoToolStripMenuItem,
            this._cropToolStripMenuItem});
            this.ctxtMnu.Name = "_ctxtMnu";
            this.ctxtMnu.Size = new System.Drawing.Size(144, 82);
            // 
            // _recordNowToolStripMenuItem
            // 
            this._recordNowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_recordNowToolStripMenuItem.Image")));
            this._recordNowToolStripMenuItem.Name = "_recordNowToolStripMenuItem";
            this._recordNowToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this._recordNowToolStripMenuItem.Text = "Record Now";
            this._recordNowToolStripMenuItem.Visible = false;
            // 
            // _takePhotoToolStripMenuItem
            // 
            this._takePhotoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_takePhotoToolStripMenuItem.Image")));
            this._takePhotoToolStripMenuItem.Name = "_takePhotoToolStripMenuItem";
            this._takePhotoToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this._takePhotoToolStripMenuItem.Text = "Take Picture";
            // 
            // _cropToolStripMenuItem
            // 
            this._cropToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_cropToolStripMenuItem.Image")));
            this._cropToolStripMenuItem.Name = "_cropToolStripMenuItem";
            this._cropToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this._cropToolStripMenuItem.Text = "&Set crop";
            // 
            // timerClear
            // 
            this.timerClear.Interval = 3000;
            this.timerClear.Tick += new System.EventHandler(this.timerClear_Tick);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 699);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormParking";
            this.Text = "Phần mềm giữ xe TGMTparking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormParking_FormClosing);
            this.Load += new System.EventHandler(this.FormParking_Load);
            this.Shown += new System.EventHandler(this.FormParking_Shown);
            this.SizeChanged += new System.EventHandler(this.FormParking_SizeChanged);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormParking_KeyUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ctxtMnu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lbl_CPU;
        private System.Windows.Forms.ToolStripStatusLabel lbl_cardReader;
        private System.Windows.Forms.ToolStripStatusLabel lblCard;
        private System.Windows.Forms.ToolStripStatusLabel lblCountVehicle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lượtXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnVideo1_1;
        private System.Windows.Forms.Panel pnVideo2_1;
        private System.Windows.Forms.ToolStripMenuItem danhSáchThẻToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1_2;
        private System.Windows.Forms.PictureBox pictureBox1_1;
        private System.Windows.Forms.Panel pnVideo1_2;
        private System.Windows.Forms.Panel pnVideo2_2;
        private System.Windows.Forms.PictureBox pictureBox2_2;
        private System.Windows.Forms.PictureBox pictureBox2_1;
        private System.Windows.Forms.ContextMenuStrip ctxtMnu;
        private System.Windows.Forms.ToolStripMenuItem _recordNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _takePhotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _cropToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_plate1;
        private System.Windows.Forms.TextBox txt_plate2;
        private System.Windows.Forms.Timer timerClear;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
    }
}