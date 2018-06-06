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
    public partial class MatHang : Form
    {


        public MatHang()
        {
            InitializeComponent();


        }

        private void MatHangData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ShowList()
        {
            var db = new QuanLyMatHangEntities1();
            var list = db.HANGHOAs.ToList();
            this.listMatHang.DataSource = list;

        }
        private void FormList_Load(object sender, EventArgs e)
        {
            this.listMatHang.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(dataGridView2_DataError);

            this.ShowList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new FormAdd();
            form.ShowDialog();
            this.ShowList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa mặt hàng này ?", "Hãy chú ý", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var db = new QuanLyMatHangEntities1();
                for (int i = 0; i < this.listMatHang.SelectedRows.Count; i++)
                {
                    try
                    {
                        var row = this.listMatHang.SelectedRows[i];
                        var item = (HANGHOA)row.DataBoundItem;
                        var hang = db.HANGHOAs.Find(item.ID);

                        db.HANGHOAs.Remove(hang);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Loi" + ex.Message);
                    }
                }
                this.ShowList();
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }
            
        }


        private void lstClasses_DoubleClick(object sender, EventArgs e)
        {
            if (this.listMatHang.SelectedRows.Count == 1)
            {
                var row = this.listMatHang.SelectedRows[0];
                var item = (HANGHOA)row.DataBoundItem;

                var form = new FormEdit(item);
                form.ShowDialog();
                this.ShowList();
            }
        }

        private void listMatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }


    }
}
