namespace QUANLYMATHANG.Fuction
{
    partial class FormEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaHang = new System.Windows.Forms.TextBox();
            this.textBoxTenHang = new System.Windows.Forms.TextBox();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.textBoxGiaTien = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPic = new System.Windows.Forms.TextBox();
            this.buttonChos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá tiền";
            // 
            // textBoxMaHang
            // 
            this.textBoxMaHang.Location = new System.Drawing.Point(105, 6);
            this.textBoxMaHang.Name = "textBoxMaHang";
            this.textBoxMaHang.Size = new System.Drawing.Size(167, 20);
            this.textBoxMaHang.TabIndex = 5;
            // 
            // textBoxTenHang
            // 
            this.textBoxTenHang.Location = new System.Drawing.Point(105, 48);
            this.textBoxTenHang.Name = "textBoxTenHang";
            this.textBoxTenHang.Size = new System.Drawing.Size(167, 20);
            this.textBoxTenHang.TabIndex = 6;
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(105, 82);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(167, 20);
            this.textBoxSoLuong.TabIndex = 7;
            this.textBoxSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNotAllowChar);
            // 
            // textBoxGiaTien
            // 
            this.textBoxGiaTien.Location = new System.Drawing.Point(105, 116);
            this.textBoxGiaTien.Name = "textBoxGiaTien";
            this.textBoxGiaTien.Size = new System.Drawing.Size(167, 20);
            this.textBoxGiaTien.TabIndex = 8;
            this.textBoxGiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNotAllowChar);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(36, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Sửa";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(183, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(349, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 145);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ảnh";
            // 
            // textBoxPic
            // 
            this.textBoxPic.Location = new System.Drawing.Point(407, 170);
            this.textBoxPic.Name = "textBoxPic";
            this.textBoxPic.Size = new System.Drawing.Size(199, 20);
            this.textBoxPic.TabIndex = 12;
            // 
            // buttonChos
            // 
            this.buttonChos.Location = new System.Drawing.Point(469, 208);
            this.buttonChos.Name = "buttonChos";
            this.buttonChos.Size = new System.Drawing.Size(75, 23);
            this.buttonChos.TabIndex = 13;
            this.buttonChos.Text = "Chọn ảnh";
            this.buttonChos.UseVisualStyleBackColor = true;
            this.buttonChos.Click += new System.EventHandler(this.buttonPic_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 261);
            this.Controls.Add(this.buttonChos);
            this.Controls.Add(this.textBoxPic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxGiaTien);
            this.Controls.Add(this.textBoxSoLuong);
            this.Controls.Add(this.textBoxTenHang);
            this.Controls.Add(this.textBoxMaHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            this.Load += new System.EventHandler(this.FormEdit_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMaHang;
        private System.Windows.Forms.TextBox textBoxTenHang;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.TextBox textBoxGiaTien;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPic;
        private System.Windows.Forms.Button buttonChos;
    }
}