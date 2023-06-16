namespace TGMTparking.UI
{
    partial class MsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox));
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnKhong = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoiDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNoiDung.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblNoiDung.Location = new System.Drawing.Point(1, 1);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Padding = new System.Windows.Forms.Padding(5);
            this.lblNoiDung.Size = new System.Drawing.Size(582, 147);
            this.lblNoiDung.TabIndex = 2;
            this.lblNoiDung.Text = "TEXT";
            this.lblNoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDongY
            // 
            this.btnDongY.BackColor = System.Drawing.Color.White;
            this.btnDongY.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDongY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDongY.Location = new System.Drawing.Point(283, 157);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(92, 29);
            this.btnDongY.TabIndex = 0;
            this.btnDongY.Text = "Yes";
            this.btnDongY.UseVisualStyleBackColor = false;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnKhong
            // 
            this.btnKhong.BackColor = System.Drawing.Color.White;
            this.btnKhong.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnKhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKhong.Location = new System.Drawing.Point(381, 157);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(92, 29);
            this.btnKhong.TabIndex = 0;
            this.btnKhong.Text = "No";
            this.btnKhong.UseVisualStyleBackColor = false;
            this.btnKhong.Click += new System.EventHandler(this.btn_02_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDong.Location = new System.Drawing.Point(479, 157);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(92, 29);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "Close";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btn_03_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 148);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(582, 1);
            this.panel1.TabIndex = 3;
            // 
            // MsgBox
            // 
            this.AcceptButton = this.btnDongY;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 195);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.btnKhong);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MsgBox";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông báo";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ct_messagebox_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageBox_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.Panel panel1;
    }
}