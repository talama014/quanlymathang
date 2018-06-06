using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYMATHANG.Fuction
{
    public partial class FormEdit : Form
    {
        public FormEdit(HANGHOA hang)
        {
            InitializeComponent();
            this.hang = hang;
        }
        private HANGHOA hang;

        private void FormEdit_Load_1(object sender, EventArgs e)
        {

            if (hang.ANH != null) {this.pictureBox1.Image = byteArrayToImage(hang.ANH); }
           
            String soluong = this.hang.SOLUONG.ToString();
            String giatien = this.hang.SOLUONG.ToString();
           
            this.textBoxMaHang.Text = this.hang.MAHANG;
            this.textBoxTenHang.Text = this.hang.TENHANG;
            this.textBoxSoLuong.Text = soluong;
            this.textBoxGiaTien.Text = giatien;
            
        }
       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                int soluong = int.Parse(this.textBoxSoLuong.Text);
                int giatien = int.Parse(this.textBoxGiaTien.Text);
                var db = new QuanLyMatHangEntities1();
                var newClass = db.HANGHOAs.Find(this.hang.ID);
                newClass.MAHANG = this.textBoxTenHang.Text;
                newClass.TENHANG = this.textBoxTenHang.Text;
                newClass.SOLUONG = soluong;
                newClass.GIATIEN = giatien;
                ImageConverter converter = new ImageConverter();
                byte[] image = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));

                newClass.ANH = image;
                db.Entry(newClass).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
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

        private void buttonPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
                textBoxPic.Text = open.FileName;
            pictureBox1.ImageLocation = open.FileName;
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
       
    }
}
