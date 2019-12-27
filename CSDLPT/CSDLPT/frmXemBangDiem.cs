using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class frmXemBangDiem : Form
    {
        public frmXemBangDiem()
        {
            InitializeComponent();
        }
        
        private void frmXemBangDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.DSMH' table. You can move, or remove it, as needed.
            this.dSMHTableAdapter.Fill(this.dS.DSMH);
            // TODO: This line of code loads data into the 'dS.DSLOP' table. You can move, or remove it, as needed.
            this.dSLOPTableAdapter.Fill(this.dS.DSLOP);

            cmbLan.Items.Add("1");
            cmbLan.Items.Add("2");

            cmbLan.SelectedIndex = 0;

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string strLenh = "EXEC dbo.SP_KTGVDKTonTai '" + cmbTenMH.SelectedValue.ToString() + "', '" + cmbTenLop.SelectedValue.ToString() + "' , " + cmbLan.SelectedItem.ToString();
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            int kq = int.Parse(Program.myReader[0].ToString());
            Program.myReader.Close();
            if (kq == 0)
            {
                MessageBox.Show("Lớp này chưa được đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Program.conn.Close();
                return;
            }
            string strLenh1 = "SELECT dbo.KiemTraMonHocDaThi('" + cmbTenMH.SelectedValue.ToString() + "', " + cmbLan.SelectedItem.ToString() + ") AS DATHI";
            Program.myReader = Program.ExecSqlDataReader(strLenh1);
            Program.myReader.Read();
            string kt = Program.myReader[0].ToString();
            Program.myReader.Close();
            if (kt == "")
            {
                MessageBox.Show("Môn học này chưa thi. Xin chọn lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Program.conn.Close();
                return;
            }

            Xrpt_XemBangDiem xrpt = new Xrpt_XemBangDiem(cmbTenLop.SelectedValue.ToString(), cmbTenMH.SelectedValue.ToString(), cmbLan.SelectedItem.ToString());
            string tenCoSo = "";
            if (Program.mCoso == 0)
            {
                tenCoSo = "CƠ SỞ 1";
            }
            else if (Program.mCoso == 1)
            {
                tenCoSo = "CƠ SỞ 2";
            }
            xrpt.lbCoSo.Text = tenCoSo;
            xrpt.lbTenLop.Text = cmbTenLop.DisplayMember;
            xrpt.lbTenMH.Text = cmbTenMH.DisplayMember;
            xrpt.lbLan.Text = cmbLan.SelectedItem.ToString();
            ReportPrintTool print = new ReportPrintTool(xrpt);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát Form Xem bảng điểm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
