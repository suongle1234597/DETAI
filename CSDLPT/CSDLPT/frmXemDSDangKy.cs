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
    public partial class frmXemDSDangKy : Form
    {
        public frmXemDSDangKy()
        {
            InitializeComponent();
        }

        private void frmXemDSDangKy_Load(object sender, EventArgs e)
        {
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (dateEditNgayBatDau.Text.Trim() == "")
            {
                MessageBox.Show("Ngày thi bắt đầu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dateEditNgayBatDau.Focus();
                return;
            }
            if (dateEditDenNgay.Text.Trim() == "")
            {
                MessageBox.Show("Ngày thi kết thúc không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dateEditDenNgay.Focus();
                return;
            }
            if(dateEditNgayBatDau.DateTime > dateEditDenNgay.DateTime)
            {
                MessageBox.Show("Ngày thi kết thúc không được nhỏ hơn Ngày thi bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dateEditDenNgay.Focus();
                return;
            }
            
            Xrpt_XemDSDangKy xrpt = new Xrpt_XemDSDangKy(dateEditNgayBatDau.Text, dateEditDenNgay.Text);
            string tenCoSo = "";
            if(Program.mCoso == 0)
            {
                tenCoSo = "CƠ SỞ 1";
            }
            else if (Program.mCoso == 1)
            {
                tenCoSo = "CƠ SỞ 2";
            }
            xrpt.lbCoSo.Text = tenCoSo;
            xrpt.lbTuNgay.Text = dateEditNgayBatDau.Text;
            xrpt.lbDenNgay.Text = dateEditDenNgay.Text;
            ReportPrintTool print = new ReportPrintTool(xrpt);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát Form Xem Danh sách Đăng ký không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.servername = cmbCoSo.SelectedValue.ToString();
            }
            catch (Exception) { };
            if (cmbCoSo.SelectedIndex != Program.mCoso)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở mới", "", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                }
                catch (Exception ex) { }
            }
        }
    }
}
