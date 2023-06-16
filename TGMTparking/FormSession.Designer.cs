using System.Windows.Forms;

namespace TGMTparking
{
    partial class FormSession
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSession));
            this.grd_card = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerClear = new System.Windows.Forms.Timer(this.components);
            this.grid_data = new System.Windows.Forms.DataGridView();
            this.ctx_1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_viewImage = new System.Windows.Forms.ToolStripMenuItem();
            this.choXeRaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_searchPlate = new System.Windows.Forms.TextBox();
            this.rd_desc = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.rd_asc = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.chk_checkout = new System.Windows.Forms.CheckBox();
            this.chk_checkin = new System.Windows.Forms.CheckBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grd_card)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_data)).BeginInit();
            this.ctx_1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_card
            // 
            this.grd_card.AllowUserToAddRows = false;
            this.grd_card.AllowUserToDeleteRows = false;
            this.grd_card.AllowUserToResizeColumns = false;
            this.grd_card.AllowUserToResizeRows = false;
            this.grd_card.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grd_card.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_card.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_card.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_card.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_card.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.grd_card.Location = new System.Drawing.Point(1, 1);
            this.grd_card.MultiSelect = false;
            this.grd_card.Name = "grd_card";
            this.grd_card.ReadOnly = true;
            this.grd_card.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grd_card.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            this.grd_card.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grd_card.RowTemplate.Height = 25;
            this.grd_card.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_card.Size = new System.Drawing.Size(1183, 651);
            this.grd_card.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMessage});
            this.statusStrip1.Location = new System.Drawing.Point(1, 630);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1183, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(1168, 17);
            this.lblMessage.Spring = true;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerClear
            // 
            this.timerClear.Interval = 2000;
            this.timerClear.Tick += new System.EventHandler(this.timerClear_Tick);
            // 
            // grid_data
            // 
            this.grid_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid_data.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_data.ContextMenuStrip = this.ctx_1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_data.DefaultCellStyle = dataGridViewCellStyle4;
            this.grid_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_data.Location = new System.Drawing.Point(1, 92);
            this.grid_data.Name = "grid_data";
            this.grid_data.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_data.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_data.Size = new System.Drawing.Size(1183, 538);
            this.grid_data.TabIndex = 12;
            this.grid_data.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grd_data_MouseClick);
            this.grid_data.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grid_data_MouseDoubleClick);
            // 
            // ctx_1
            // 
            this.ctx_1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ctx_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_viewImage,
            this.choXeRaToolStripMenuItem});
            this.ctx_1.Name = "ctx_1";
            this.ctx_1.Size = new System.Drawing.Size(146, 56);
            this.ctx_1.Opening += new System.ComponentModel.CancelEventHandler(this.ctx_1_Opening);
            // 
            // btn_viewImage
            // 
            this.btn_viewImage.Name = "btn_viewImage";
            this.btn_viewImage.Size = new System.Drawing.Size(145, 26);
            this.btn_viewImage.Text = "Xem ảnh";
            this.btn_viewImage.Click += new System.EventHandler(this.btn_viewImage_Click);
            // 
            // choXeRaToolStripMenuItem
            // 
            this.choXeRaToolStripMenuItem.Name = "choXeRaToolStripMenuItem";
            this.choXeRaToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.choXeRaToolStripMenuItem.Text = "Cho xe ra";
            this.choXeRaToolStripMenuItem.Click += new System.EventHandler(this.choXeRaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Biển số";
            // 
            // txt_searchPlate
            // 
            this.txt_searchPlate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchPlate.Location = new System.Drawing.Point(83, 53);
            this.txt_searchPlate.Name = "txt_searchPlate";
            this.txt_searchPlate.Size = new System.Drawing.Size(255, 25);
            this.txt_searchPlate.TabIndex = 34;
            this.txt_searchPlate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_searchPlate_KeyDown);
            // 
            // rd_desc
            // 
            this.rd_desc.AutoSize = true;
            this.rd_desc.Checked = true;
            this.rd_desc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_desc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rd_desc.Location = new System.Drawing.Point(410, 22);
            this.rd_desc.Name = "rd_desc";
            this.rd_desc.Size = new System.Drawing.Size(119, 23);
            this.rd_desc.TabIndex = 29;
            this.rd_desc.TabStop = true;
            this.rd_desc.Text = "Mới nhất trước";
            this.rd_desc.UseVisualStyleBackColor = true;
            this.rd_desc.CheckedChanged += new System.EventHandler(this.rd_desc_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(150, 21);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(114, 23);
            this.dateTimePicker2.TabIndex = 33;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // rd_asc
            // 
            this.rd_asc.AutoSize = true;
            this.rd_asc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_asc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rd_asc.Location = new System.Drawing.Point(298, 22);
            this.rd_asc.Name = "rd_asc";
            this.rd_asc.Size = new System.Drawing.Size(112, 23);
            this.rd_asc.TabIndex = 28;
            this.rd_asc.Text = "Cũ nhất trước";
            this.rd_asc.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 23);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.chk_checkout);
            this.groupBox2.Controls.Add(this.chk_checkin);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.rd_desc);
            this.groupBox2.Controls.Add(this.txt_searchPlate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rd_asc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1183, 91);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.LightGreen;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_search.Location = new System.Drawing.Point(382, 44);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(138, 41);
            this.btn_search.TabIndex = 44;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // chk_checkout
            // 
            this.chk_checkout.AutoSize = true;
            this.chk_checkout.Checked = true;
            this.chk_checkout.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_checkout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_checkout.Location = new System.Drawing.Point(663, 22);
            this.chk_checkout.Name = "chk_checkout";
            this.chk_checkout.Size = new System.Drawing.Size(63, 23);
            this.chk_checkout.TabIndex = 43;
            this.chk_checkout.Text = "Đã về";
            this.chk_checkout.UseVisualStyleBackColor = true;
            this.chk_checkout.CheckedChanged += new System.EventHandler(this.chk_checkout_CheckedChanged);
            // 
            // chk_checkin
            // 
            this.chk_checkin.AutoSize = true;
            this.chk_checkin.Checked = true;
            this.chk_checkin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_checkin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_checkin.Location = new System.Drawing.Point(573, 22);
            this.chk_checkin.Name = "chk_checkin";
            this.chk_checkin.Size = new System.Drawing.Size(85, 23);
            this.chk_checkin.TabIndex = 42;
            this.chk_checkin.Text = "Trong bãi";
            this.chk_checkin.UseVisualStyleBackColor = true;
            this.chk_checkin.CheckedChanged += new System.EventHandler(this.chk_checkin_CheckedChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FormSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 653);
            this.Controls.Add(this.grid_data);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grd_card);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "FormSession";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lượt xe ra vào";
            this.Load += new System.EventHandler(this.FormSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_card)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_data)).EndInit();
            this.ctx_1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_card;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timerClear;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private System.Windows.Forms.DataGridView grid_data;
        private System.Windows.Forms.RadioButton rd_desc;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RadioButton rd_asc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_searchPlate;
        private System.Windows.Forms.ContextMenuStrip ctx_1;
        private System.Windows.Forms.ToolStripMenuItem btn_viewImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private PrintPreviewDialog printPreviewDialog1;
        private CheckBox chk_checkin;
        private CheckBox chk_checkout;
        private ToolStripMenuItem choXeRaToolStripMenuItem;
        private Button btn_search;
    }
}