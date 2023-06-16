namespace TGMTparking.UI
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.grd_card = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerClear = new System.Windows.Forms.Timer(this.components);
            this.gird_data = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_card)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gird_data)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.grd_card.Size = new System.Drawing.Size(915, 602);
            this.grd_card.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMessage});
            this.statusStrip1.Location = new System.Drawing.Point(1, 581);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(915, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(900, 17);
            this.lblMessage.Spring = true;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerClear
            // 
            this.timerClear.Interval = 2000;
            this.timerClear.Tick += new System.EventHandler(this.timerClear_Tick);
            // 
            // gird_data
            // 
            this.gird_data.AllowUserToAddRows = false;
            this.gird_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gird_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gird_data.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gird_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gird_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gird_data.DefaultCellStyle = dataGridViewCellStyle4;
            this.gird_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gird_data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gird_data.Location = new System.Drawing.Point(1, 167);
            this.gird_data.Name = "gird_data";
            this.gird_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gird_data.Size = new System.Drawing.Size(915, 414);
            this.gird_data.TabIndex = 12;
            this.gird_data.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grd_data_MouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txt_username);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_password2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_password1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_fullname);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.txt_phone);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(1, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(915, 166);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_username.Location = new System.Drawing.Point(175, 17);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(246, 23);
            this.txt_username.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(95, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Username";
            // 
            // txt_password2
            // 
            this.txt_password2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_password2.Location = new System.Drawing.Point(175, 130);
            this.txt_password2.Name = "txt_password2";
            this.txt_password2.PasswordChar = '*';
            this.txt_password2.Size = new System.Drawing.Size(246, 23);
            this.txt_password2.TabIndex = 5;
            this.txt_password2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(47, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nhập lại password";
            // 
            // txt_password1
            // 
            this.txt_password1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_password1.Location = new System.Drawing.Point(175, 101);
            this.txt_password1.Name = "txt_password1";
            this.txt_password1.PasswordChar = '*';
            this.txt_password1.Size = new System.Drawing.Size(246, 23);
            this.txt_password1.TabIndex = 4;
            this.txt_password1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(99, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Password";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_fullname.Location = new System.Drawing.Point(175, 73);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(246, 23);
            this.txt_fullname.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LightGreen;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_add.Location = new System.Drawing.Point(433, 42);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(104, 53);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Enabled = false;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(653, 42);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(104, 53);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_phone.Location = new System.Drawing.Point(175, 45);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(246, 23);
            this.txt_phone.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Location = new System.Drawing.Point(543, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 53);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.Location = new System.Drawing.Point(115, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 19);
            this.label12.TabIndex = 8;
            this.label12.Text = "Họ tên";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label13.Location = new System.Drawing.Point(79, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 19);
            this.label13.TabIndex = 6;
            this.label13.Text = "Số điện thoại";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 604);
            this.Controls.Add(this.gird_data);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grd_card);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "FormUser";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách user";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormPlate_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.grd_card)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gird_data)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_card;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timerClear;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private System.Windows.Forms.DataGridView gird_data;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.TextBox txt_password1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
    }
}