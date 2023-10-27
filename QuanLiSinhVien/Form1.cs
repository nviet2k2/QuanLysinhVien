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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             //ThongTinSinhVien thongTinSinhVien = new ThongTinSinhVien();

             // thongTinSinhVien.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        private void ShowChildFormInPanel(Form ThongTinSinhVien)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                if (f.Name == "DanhMucMonHoc")
                {
                    f.Activate();
                    return;
                }
                DanhMucMonHoc danhMucMonHoc = new DanhMucMonHoc();
                danhMucMonHoc.MdiParent = this;
                danhMucMonHoc.Show();
            }
        }
    }
}
