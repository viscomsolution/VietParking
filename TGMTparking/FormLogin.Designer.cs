namespace TGMTparking.UI
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.txt_username.Location = new System.Drawing.Point(74, 49);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(452, 54);
            this.txt_username.TabIndex = 0;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.Location = new System.Drawing.Point(145, 205);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(313, 79);
            this.btn_dangnhap.TabIndex = 2;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.txt_password.Location = new System.Drawing.Point(74, 126);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(452, 54);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(577, 317);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.btn_dangnhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập phần mềm";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.TextBox txt_password;
    }
}