using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYMATHANG.Fuction
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            HANGHOA hang = new HANGHOA();
            int soluong = int.Parse(this.textBoxSoluon.Text);
            int giatien = int.Parse(this.textBoxGiaTien.Text);
            hang.MAHANG = this.textBoxMaHang.Text;
            hang.TENHANG = this.textBoxTenHang.Text;
            hang.SOLUONG = soluong;
            hang.GIATIEN = giatien;
            

            try
            {
                ImageConverter converter = new ImageConverter();
                byte[] image = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));
               
                hang.ANH = image;
                var db = new QuanLyMatHangEntities1();
                db.HANGHOAs.Add(hang);
                db.SaveChanges();
                MessageBox.Show("Mặt hàng đã thêm thành công");
                this.Close();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxNotAllowChar(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
               
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
                textBoxPic.Text = open.FileName;
            pictureBox1.ImageLocation = open.FileName;
        }


       

        
    }
}
