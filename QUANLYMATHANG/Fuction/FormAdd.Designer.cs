namespace QUANLYMATHANG.Fuction
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaHang = new System.Windows.Forms.TextBox();
            this.textBoxTenHang = new System.Windows.Forms.TextBox();
            this.textBoxSoluon = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxGiaTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPic = new System.Windows.Forms.TextBox();
            this.buttonPic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Mặt Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Mặt Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá Tiền";
            // 
            // textBoxMaHang
            // 
            this.textBoxMaHang.Location = new System.Drawing.Point(108, 13);
            this.textBoxMaHang.Name = "textBoxMaHang";
            this.textBoxMaHang.Size = new System.Drawing.Size(164, 20);
            this.textBoxMaHang.TabIndex = 4;
            // 
            // textBoxTenHang
            // 
            this.textBoxTenHang.Location = new System.Drawing.Point(108, 55);
            this.textBoxTenHang.Name = "textBoxTenHang";
            this.textBoxTenHang.Size = new System.Drawing.Size(164, 20);
            this.textBoxTenHang.TabIndex = 5;
            // 
            // textBoxSoluon
            // 
            this.textBoxSoluon.Location = new System.Drawing.Point(108, 89);
            this.textBoxSoluon.Name = "textBoxSoluon";
            this.textBoxSoluon.Size = new System.Drawing.Size(164, 20);
            this.textBoxSoluon.TabIndex = 6;
            this.textBoxSoluon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNotAllowChar);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(39, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(221, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxGiaTien
            // 
            this.textBoxGiaTien.Location = new System.Drawing.Point(108, 124);
            this.textBoxGiaTien.Name = "textBoxGiaTien";
            this.textBoxGiaTien.Size = new System.Drawing.Size(164, 20);
            this.textBoxGiaTien.TabIndex = 9;
            this.textBoxGiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNotAllowChar);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ảnh";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxPic
            // 
            this.textBoxPic.Location = new System.Drawing.Point(406, 141);
            this.textBoxPic.Name = "textBoxPic";
            this.textBoxPic.Size = new System.Drawing.Size(281, 20);
            this.textBoxPic.TabIndex = 11;
            // 
            // buttonPic
            // 
            this.buttonPic.Location = new System.Drawing.Point(517, 182);
            this.buttonPic.Name = "buttonPic";
            this.buttonPic.Size = new System.Drawing.Size(75, 23);
            this.buttonPic.TabIndex = 12;
            this.buttonPic.Text = "Chọn ảnh";
            this.buttonPic.UseVisualStyleBackColor = true;
            this.buttonPic.Click += new System.EventHandler(this.buttonPic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(428, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 109);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 230);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPic);
            this.Controls.Add(this.textBoxPic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxGiaTien);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxSoluon);
            this.Controls.Add(this.textBoxTenHang);
            this.Controls.Add(this.textBoxMaHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdd";
            this.Text = "Thêm Mặt Hàng";
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
        private System.Windows.Forms.TextBox textBoxSoluon;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxGiaTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPic;
        private System.Windows.Forms.Button buttonPic;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}