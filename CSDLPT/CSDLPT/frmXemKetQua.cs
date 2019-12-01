using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace CSDLPT
{
    public partial class frmXemKetQua : Form
    {
        public frmXemKetQua()
        {
            InitializeComponent();
        }

        private void frmXemKetQua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.DSMH' table. You can move, or remove it, as needed.
            this.dSMHTableAdapter.Fill(this.dS.DSMH);
            // TODO: This line of code loads data into the 'dS.DSLOP' table. You can move, or remove it, as needed.
            this.dSLOPTableAdapter.Fill(this.dS.DSLOP);

            cmbTrinhDo.Items.Add("A");
            cmbTrinhDo.Items.Add("B");
            cmbTrinhDo.Items.Add("C");

            cmbTrinhDo.SelectedIndex = 0;

            txtHoTen.Text = Program.mHoten;
            txtHoTen.Enabled = false;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string strLenh = "EXEC SP_ThongTinXemKQ '" + cmbTenLop.SelectedValue.ToString() +"', '" + Program.mlogin +"', '" + cmbTenMH.SelectedValue.ToString() + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            int dem = 0;
            if (Program.myReader.HasRows)
            {
                dem++;
            }
            if (dem == 0)
            {
                MessageBox.Show("Bạn chưa thi môn này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Program.myReader.Close();
                return;
            }
            else
            {
                Program.myReader.Read();
                string maSV = Program.myReader.GetString(1);
                string hoten = Program.myReader.GetString(2) + Program.myReader.GetString(3);
                string ngayThi = Program.myReader.GetDateTime(4).ToString();
                string lan = Program.myReader.GetInt32(5).ToString();
                string[] str = ngayThi.Split(' ');
                Program.myReader.Close();
                Xrpt_XemKetQua xrpt = new Xrpt_XemKetQua(cmbTenLop.SelectedValue.ToString(), maSV, cmbTenMH.SelectedValue.ToString());
                xrpt.lbLop.Text = cmbTenLop.SelectedValue.ToString();
                xrpt.lbHoTen.Text = hoten;
                xrpt.lbMonThi.Text = cmbTenMH.SelectedValue.ToString();
                xrpt.lbNgayThi.Text = str[1];
                xrpt.lbLanThi.Text = lan;
                ReportPrintTool print = new ReportPrintTool(xrpt);
                print.ShowPreviewDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát Form Xem kết quả không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panelControlTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
