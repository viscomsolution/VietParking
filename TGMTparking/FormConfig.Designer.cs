using TGMTparking.UI;

namespace TGMTparking
{
    partial class FormConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_message = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerClear = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_cropPlate = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_url1_2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_url1_1 = new System.Windows.Forms.TextBox();
            this.rd_lane1_in = new System.Windows.Forms.RadioButton();
            this.rd_lane1_out = new System.Windows.Forms.RadioButton();
            this.btn_saveLane1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_url2_2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_url2_1 = new System.Windows.Forms.TextBox();
            this.rd_lane2_in = new System.Windows.Forms.RadioButton();
            this.rd_lane2_out = new System.Windows.Forms.RadioButton();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_message});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_message
            // 
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 17);
            // 
            // timerClear
            // 
            this.timerClear.Interval = 1000;
            this.timerClear.Tick += new System.EventHandler(this.timerClear_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_cropPlate);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 71);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đọc biển số";
            // 
            // chk_cropPlate
            // 
            this.chk_cropPlate.AutoSize = true;
            this.chk_cropPlate.Location = new System.Drawing.Point(14, 30);
            this.chk_cropPlate.Name = "chk_cropPlate";
            this.chk_cropPlate.Size = new System.Drawing.Size(106, 23);
            this.chk_cropPlate.TabIndex = 0;
            this.chk_cropPlate.Text = "Crop biển số";
            this.chk_cropPlate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_url1_2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_url1_1);
            this.groupBox1.Controls.Add(this.rd_lane1_in);
            this.groupBox1.Controls.Add(this.rd_lane1_out);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 142);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Làn xe 01";
            // 
            // txt_url1_2
            // 
            this.txt_url1_2.Location = new System.Drawing.Point(131, 67);
            this.txt_url1_2.Name = "txt_url1_2";
            this.txt_url1_2.Size = new System.Drawing.Size(526, 25);
            this.txt_url1_2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "URL camera 1.2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "URL camera 1.1";
            // 
            // txt_url1_1
            // 
            this.txt_url1_1.Location = new System.Drawing.Point(131, 33);
            this.txt_url1_1.Name = "txt_url1_1";
            this.txt_url1_1.Size = new System.Drawing.Size(526, 25);
            this.txt_url1_1.TabIndex = 14;
            // 
            // rd_lane1_in
            // 
            this.rd_lane1_in.AutoSize = true;
            this.rd_lane1_in.Location = new System.Drawing.Point(21, 103);
            this.rd_lane1_in.Name = "rd_lane1_in";
            this.rd_lane1_in.Size = new System.Drawing.Size(75, 23);
            this.rd_lane1_in.TabIndex = 7;
            this.rd_lane1_in.TabStop = true;
            this.rd_lane1_in.Text = "Làn vào";
            this.rd_lane1_in.UseVisualStyleBackColor = true;
            // 
            // rd_lane1_out
            // 
            this.rd_lane1_out.AutoSize = true;
            this.rd_lane1_out.Location = new System.Drawing.Point(166, 103);
            this.rd_lane1_out.Name = "rd_lane1_out";
            this.rd_lane1_out.Size = new System.Drawing.Size(65, 23);
            this.rd_lane1_out.TabIndex = 6;
            this.rd_lane1_out.TabStop = true;
            this.rd_lane1_out.Text = "Làn ra";
            this.rd_lane1_out.UseVisualStyleBackColor = true;
            // 
            // btn_saveLane1
            // 
            this.btn_saveLane1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveLane1.Location = new System.Drawing.Point(302, 367);
            this.btn_saveLane1.Name = "btn_saveLane1";
            this.btn_saveLane1.Size = new System.Drawing.Size(77, 33);
            this.btn_saveLane1.TabIndex = 5;
            this.btn_saveLane1.Text = "Save";
            this.btn_saveLane1.UseVisualStyleBackColor = true;
            this.btn_saveLane1.Click += new System.EventHandler(this.btn_saveLane1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_url2_2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txt_url2_1);
            this.groupBox4.Controls.Add(this.rd_lane2_in);
            this.groupBox4.Controls.Add(this.rd_lane2_out);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 142);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(684, 132);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Làn xe 02";
            // 
            // txt_url2_2
            // 
            this.txt_url2_2.Location = new System.Drawing.Point(131, 58);
            this.txt_url2_2.Name = "txt_url2_2";
            this.txt_url2_2.Size = new System.Drawing.Size(526, 25);
            this.txt_url2_2.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "URL camera 2.2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "URL camera 2.1";
            // 
            // txt_url2_1
            // 
            this.txt_url2_1.Location = new System.Drawing.Point(131, 24);
            this.txt_url2_1.Name = "txt_url2_1";
            this.txt_url2_1.Size = new System.Drawing.Size(526, 25);
            this.txt_url2_1.TabIndex = 18;
            // 
            // rd_lane2_in
            // 
            this.rd_lane2_in.AutoSize = true;
            this.rd_lane2_in.Location = new System.Drawing.Point(20, 90);
            this.rd_lane2_in.Name = "rd_lane2_in";
            this.rd_lane2_in.Size = new System.Drawing.Size(75, 23);
            this.rd_lane2_in.TabIndex = 7;
            this.rd_lane2_in.TabStop = true;
            this.rd_lane2_in.Text = "Làn vào";
            this.rd_lane2_in.UseVisualStyleBackColor = true;
            // 
            // rd_lane2_out
            // 
            this.rd_lane2_out.AutoSize = true;
            this.rd_lane2_out.Location = new System.Drawing.Point(170, 90);
            this.rd_lane2_out.Name = "rd_lane2_out";
            this.rd_lane2_out.Size = new System.Drawing.Size(65, 23);
            this.rd_lane2_out.TabIndex = 6;
            this.rd_lane2_out.TabStop = true;
            this.rd_lane2_out.Text = "Làn ra";
            this.rd_lane2_out.UseVisualStyleBackColor = true;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 440);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_saveLane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timerClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_cropPlate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_saveLane1;
        private System.Windows.Forms.RadioButton rd_lane1_in;
        private System.Windows.Forms.RadioButton rd_lane1_out;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rd_lane2_in;
        private System.Windows.Forms.RadioButton rd_lane2_out;
        private System.Windows.Forms.ToolStripStatusLabel lbl_message;
        private System.Windows.Forms.TextBox txt_url1_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_url1_2;
        private System.Windows.Forms.TextBox txt_url2_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_url2_1;
    }
}

