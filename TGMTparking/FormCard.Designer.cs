namespace TGMTparking.UI
{
    partial class FormCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCard));
            this.ctx_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_lost = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_found = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_reset = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCardReader = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerClear = new System.Windows.Forms.Timer(this.components);
            this.grid_card = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_lost = new System.Windows.Forms.CheckBox();
            this.chk_free = new System.Windows.Forms.CheckBox();
            this.chk_using = new System.Windows.Forms.CheckBox();
            this.ctx_menu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_card)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctx_menu
            // 
            this.ctx_menu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ctx_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_delete,
            this.btn_lost,
            this.btn_found,
            this.btn_reset});
            this.ctx_menu.Name = "ctx_menu";
            this.ctx_menu.Size = new System.Drawing.Size(187, 108);
            // 
            // btn_delete
            // 
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(186, 26);
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_lost
            // 
            this.btn_lost.Name = "btn_lost";
            this.btn_lost.Size = new System.Drawing.Size(186, 26);
            this.btn_lost.Text = "Báo mất thẻ";
            this.btn_lost.Click += new System.EventHandler(this.btn_lost_Click);
            // 
            // btn_found
            // 
            this.btn_found.Name = "btn_found";
            this.btn_found.Size = new System.Drawing.Size(186, 26);
            this.btn_found.Text = "Đã tìm thấy thẻ";
            this.btn_found.Click += new System.EventHandler(this.btn_found_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(186, 26);
            this.btn_reset.Text = "Reset thẻ";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMessage,
            this.lblCardReader});
            this.statusStrip1.Location = new System.Drawing.Point(1, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(961, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(787, 21);
            this.lblMessage.Spring = true;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCardReader
            // 
            this.lblCardReader.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCardReader.ForeColor = System.Drawing.Color.Red;
            this.lblCardReader.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lblCardReader.Name = "lblCardReader";
            this.lblCardReader.Size = new System.Drawing.Size(128, 21);
            this.lblCardReader.Text = "Đầu đọc thẻ: NO ";
            // 
            // timerClear
            // 
            this.timerClear.Interval = 2000;
            this.timerClear.Tick += new System.EventHandler(this.timerClear_Tick);
            // 
            // grid_card
            // 
            this.grid_card.AllowUserToAddRows = false;
            this.grid_card.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_card.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid_card.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_card.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_card.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_card.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_card.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grid_card.Location = new System.Drawing.Point(1, 65);
            this.grid_card.MultiSelect = false;
            this.grid_card.Name = "grid_card";
            this.grid_card.ReadOnly = true;
            this.grid_card.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_card.Size = new System.Drawing.Size(961, 394);
            this.grid_card.TabIndex = 24;
            this.grid_card.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grid_card_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.chk_lost);
            this.groupBox1.Controls.Add(this.chk_free);
            this.groupBox1.Controls.Add(this.chk_using);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 64);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // chk_lost
            // 
            this.chk_lost.AutoSize = true;
            this.chk_lost.Checked = true;
            this.chk_lost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_lost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_lost.Location = new System.Drawing.Point(242, 19);
            this.chk_lost.Name = "chk_lost";
            this.chk_lost.Size = new System.Drawing.Size(73, 23);
            this.chk_lost.TabIndex = 2;
            this.chk_lost.Text = "Đã mất";
            this.chk_lost.UseVisualStyleBackColor = true;
            this.chk_lost.CheckedChanged += new System.EventHandler(this.chk_lost_CheckedChanged);
            // 
            // chk_free
            // 
            this.chk_free.AutoSize = true;
            this.chk_free.Checked = true;
            this.chk_free.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_free.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_free.Location = new System.Drawing.Point(129, 19);
            this.chk_free.Name = "chk_free";
            this.chk_free.Size = new System.Drawing.Size(96, 23);
            this.chk_free.TabIndex = 1;
            this.chk_free.Text = "Chưa dùng";
            this.chk_free.UseVisualStyleBackColor = true;
            this.chk_free.CheckedChanged += new System.EventHandler(this.chk_free_CheckedChanged);
            // 
            // chk_using
            // 
            this.chk_using.AutoSize = true;
            this.chk_using.Checked = true;
            this.chk_using.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_using.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_using.Location = new System.Drawing.Point(16, 19);
            this.chk_using.Name = "chk_using";
            this.chk_using.Size = new System.Drawing.Size(97, 23);
            this.chk_using.TabIndex = 0;
            this.chk_using.Text = "Đang dùng";
            this.chk_using.UseVisualStyleBackColor = true;
            this.chk_using.CheckedChanged += new System.EventHandler(this.chk_using_CheckedChanged);
            // 
            // FormCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 486);
            this.Controls.Add(this.grid_card);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCard";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách thẻ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCard_FormClosed);
            this.Load += new System.EventHandler(this.FormCard_Load);
            this.ctx_menu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_card)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private System.Windows.Forms.ToolStripStatusLabel lblCardReader;
        private System.Windows.Forms.Timer timerClear;
        private System.Windows.Forms.ContextMenuStrip ctx_menu;
        private System.Windows.Forms.ToolStripMenuItem btn_delete;
        private System.Windows.Forms.DataGridView grid_card;
        private System.Windows.Forms.ToolStripMenuItem btn_lost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_using;
        private System.Windows.Forms.CheckBox chk_lost;
        private System.Windows.Forms.CheckBox chk_free;
        private System.Windows.Forms.ToolStripMenuItem btn_found;
        private System.Windows.Forms.ToolStripMenuItem btn_reset;
    }
}