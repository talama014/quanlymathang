namespace QUANLYMATHANG.Fuction
{
    partial class MatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatHang));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaMặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaMặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listMatHang = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.chỉnhSửaMặtHàngToolStripMenuItem,
            this.xóaMặtHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem.Image")));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.addToolStripMenuItem.Text = " + Thêm mặt hàng";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chỉnhSửaMặtHàngToolStripMenuItem
            // 
            this.chỉnhSửaMặtHàngToolStripMenuItem.Name = "chỉnhSửaMặtHàngToolStripMenuItem";
            this.chỉnhSửaMặtHàngToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.chỉnhSửaMặtHàngToolStripMenuItem.Text = "Chỉnh sửa mặt hàng";
            this.chỉnhSửaMặtHàngToolStripMenuItem.Click += new System.EventHandler(this.lstClasses_DoubleClick);
            // 
            // xóaMặtHàngToolStripMenuItem
            // 
            this.xóaMặtHàngToolStripMenuItem.Name = "xóaMặtHàngToolStripMenuItem";
            this.xóaMặtHàngToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.xóaMặtHàngToolStripMenuItem.Text = "Xóa Mặt Hàng";
            this.xóaMặtHàngToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listMatHang
            // 
            this.listMatHang.AllowUserToAddRows = false;
            this.listMatHang.AllowUserToDeleteRows = false;
            this.listMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listMatHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.listMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMatHang.Location = new System.Drawing.Point(0, 24);
            this.listMatHang.Name = "listMatHang";
            this.listMatHang.ReadOnly = true;
            this.listMatHang.Size = new System.Drawing.Size(886, 287);
            this.listMatHang.TabIndex = 2;
            // 
            // MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(886, 311);
            this.Controls.Add(this.listMatHang);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MatHang";
            this.Text = "TẤT CẢ MẶT HÀNG";
            this.Load += new System.EventHandler(this.FormList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaMặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaMặtHàngToolStripMenuItem;
        private System.Windows.Forms.DataGridView listMatHang;

    }
    
}