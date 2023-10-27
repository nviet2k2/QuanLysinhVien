using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien
{
    public partial class DanhMucMonHoc : Form
    {
        public DanhMucMonHoc()
        {
            InitializeComponent();
        }

        private void sinhVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sinhVienDbDataSet1);

        }

        private void DanhMucMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinhVienDbDataSet1.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.sinhVienDbDataSet1.SinhVien);

        }
    }
}
