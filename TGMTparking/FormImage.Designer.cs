namespace TGMTparking
{
    partial class FormImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImage));
            this.pic_checkinFront = new System.Windows.Forms.PictureBox();
            this.pic_checkoutFront = new System.Windows.Forms.PictureBox();
            this.pic_checkinBack = new System.Windows.Forms.PictureBox();
            this.pic_checkoutBack = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_checkinFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_checkoutFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_checkinBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_checkoutBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_checkinFront
            // 
            this.pic_checkinFront.Location = new System.Drawing.Point(12, 50);
            this.pic_checkinFront.Name = "pic_checkinFront";
            this.pic_checkinFront.Size = new System.Drawing.Size(385, 265);
            this.pic_checkinFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_checkinFront.TabIndex = 0;
            this.pic_checkinFront.TabStop = false;
            // 
            // pic_checkoutFront
            // 
            this.pic_checkoutFront.Location = new System.Drawing.Point(403, 50);
            this.pic_checkoutFront.Name = "pic_checkoutFront";
            this.pic_checkoutFront.Size = new System.Drawing.Size(385, 265);
            this.pic_checkoutFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_checkoutFront.TabIndex = 1;
            this.pic_checkoutFront.TabStop = false;
            // 
            // pic_checkinBack
            // 
            this.pic_checkinBack.Location = new System.Drawing.Point(12, 365);
            this.pic_checkinBack.Name = "pic_checkinBack";
            this.pic_checkinBack.Size = new System.Drawing.Size(385, 265);
            this.pic_checkinBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_checkinBack.TabIndex = 2;
            this.pic_checkinBack.TabStop = false;
            // 
            // pic_checkoutBack
            // 
            this.pic_checkoutBack.Location = new System.Drawing.Point(403, 365);
            this.pic_checkoutBack.Name = "pic_checkoutBack";
            this.pic_checkoutBack.Size = new System.Drawing.Size(385, 265);
            this.pic_checkoutBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_checkoutBack.TabIndex = 3;
            this.pic_checkoutBack.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phía trước xe vào";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phía trước xe ra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phía sau xe vào";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(538, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ảnh sau xe ra";
            // 
            // FormImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 643);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_checkoutBack);
            this.Controls.Add(this.pic_checkinBack);
            this.Controls.Add(this.pic_checkoutFront);
            this.Controls.Add(this.pic_checkinFront);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormImage";
            this.Text = "Hình ảnh lượt xe";
            this.Load += new System.EventHandler(this.FormImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_checkinFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_checkoutFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_checkinBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_checkoutBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_checkinFront;
        private System.Windows.Forms.PictureBox pic_checkoutFront;
        private System.Windows.Forms.PictureBox pic_checkinBack;
        private System.Windows.Forms.PictureBox pic_checkoutBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}