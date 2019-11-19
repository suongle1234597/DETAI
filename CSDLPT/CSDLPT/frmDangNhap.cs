using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            string chuoiKetNoi = "Data Source=SUONG;Initial Catalog=TRACNGHIEM;User ID=sa;password=123456";
            Program.conn.ConnectionString = chuoiKetNoi;
            //Program.conn.Open();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM V_DSPM");
            Program.bds_dspm.DataSource = dt;
            cmbCoSo.DataSource = dt;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";

            //this.v_DS_PHANMANHTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DS_PHANMANH);
            //cmbCoSo.SelectedIndex = 0;

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản và Mật khẩu không được để trống", "", MessageBoxButtons.OK);
                return;
            }

            Program.mlogin = txtTaiKhoan.Text;
            Program.password = txtMatKhau.Text;
            if (Program.KetNoi() == 0) return;

            Program.mCoso = cmbCoSo.SelectedIndex;

            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "";
            if (rbtnSinhVien.Checked == true)
            {
                strLenh = "EXEC SP_DangNhapSinhVien '" + Program.mlogin + "'";
            }
            else if (rbtnGiangVien.Checked == true)
            {
                strLenh = "EXEC SP_DangNhapGiangVien '" + Program.mlogin + "'";
            }

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0); // Lay username
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Tài khoản bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại tài khoản và mật khẩu", "", MessageBoxButtons.OK);
                return;
            }

            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.conn.Close();
            if (Program.mGroup.Equals("Truong"))
            {
                MessageBox.Show("Giảng viên: \t" + Program.mHoten + "\nNhóm: \t" + Program.mGroup, "", MessageBoxButtons.OK);
                frmGiaoDienNhomTruong truong = new frmGiaoDienNhomTruong();
                truong.ShowDialog();
            }
            else if (Program.mGroup.Equals("Coso"))
            {
                MessageBox.Show("Giảng viên: \t" + Program.mHoten + "\nNhóm: \t" + Program.mGroup, "", MessageBoxButtons.OK);
            }
            else if (Program.mGroup.Equals("Giangvien"))
            {
                MessageBox.Show("Giảng viên: \t" + Program.mHoten + "\nNhóm: \t" + Program.mGroup, "", MessageBoxButtons.OK);
            }
            else if (Program.mGroup.Equals("Sinhvien"))
            {
                MessageBox.Show("Sinh viên: \t" + Program.mHoten + "\nNhóm: \t" + Program.mGroup, "", MessageBoxButtons.OK);
            }
            
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbCoSo.SelectedValue.ToString();
            }
            catch(Exception) { };
        }

    }
}
