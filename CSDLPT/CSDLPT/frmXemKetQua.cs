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
        int maBD = 0;
        public frmXemKetQua()
        {
            InitializeComponent();
        }

        private void frmXemKetQua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.dS.V_DSPM);
            // TODO: This line of code loads data into the 'dS.DSSV' table. You can move, or remove it, as needed.
            this.dSSVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSSVTableAdapter.Fill(this.dS.DSSV);
            // TODO: This line of code loads data into the 'dS.DSMH' table. You can move, or remove it, as needed.
            this.dSMHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSMHTableAdapter.Fill(this.dS.DSMH);
            // TODO: This line of code loads data into the 'dS.DSLOP' table. You can move, or remove it, as needed.
            this.dSLOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSLOPTableAdapter.Fill(this.dS.DSLOP);

            cmbLan.Items.Add("1");
            cmbLan.Items.Add("2");

            cmbTrinhDo.Items.Add("A");
            cmbTrinhDo.Items.Add("B");
            cmbTrinhDo.Items.Add("C");

            cmbLan.SelectedIndex = 0;
            cmbTrinhDo.SelectedIndex = 0;

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;

            if (Program.mGroup == "Sinhvien")
            {
                cmbHoTen.SelectedValue = Program.username;
                cmbHoTen.Enabled = false;
                labelTrinhDo.Visible = false;
                labelCoSo.Visible = false;
                cmbTrinhDo.Visible = false;
                cmbCoSo.Visible = false;
                cmbTenLop.Enabled = false;
                cmbTenLop.SelectedValue = Program.mMaLop;
            }
            gcXemKetQua.Enabled = false;
        }

        public void KiemTra()
        {
            string maSV = "";
            if (Program.mGroup == "Sinhvien")
            {
                maSV = Program.username;
            }
            else
            {
                maSV = cmbHoTen.SelectedValue.ToString();
            }

            if (Program.mGroup != "Sinhvien")
            {
                string lenh = "EXEC SP_KTSVThuocLop '" + maSV + "', '" + cmbTenLop.SelectedValue.ToString() + "'";
                Program.myReader = Program.ExecSqlDataReader(lenh);
                Program.myReader.Read();
                int result = Int32.Parse(Program.myReader.GetInt32(0).ToString());
                if (result == 0)
                {
                    MessageBox.Show("Sinh viên không thuộc lớp này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Program.myReader.Close();
                    cmbHoTen.Focus();
                    return;
                }
                Program.myReader.Close();
            }

            string strLenh = "EXEC SP_KiemTraDaThi '" + maSV + "', '" + cmbTenMH.SelectedValue.ToString() + "',  " + cmbLan.SelectedItem.ToString();
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            int kq = Int32.Parse(Program.myReader.GetInt32(0).ToString());
            if (kq == 0)
            {
                MessageBox.Show("Sinh viên chưa thi môn này lần " + cmbLan.SelectedItem.ToString() + "\nVui lòng chọn lại môn hoặc lần thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Program.myReader.Close();
                cmbTenMH.Focus();
                return;
            }
            maBD = Int32.Parse(Program.myReader.GetInt32(1).ToString());
            Program.myReader.Close();

            if (Program.mGroup != "Sinhvien")
            {
                string lenh2 = "EXEC SP_KTTrinhDo '" + cmbTenMH.SelectedValue.ToString() + "', '" + cmbTenLop.SelectedValue.ToString() + "' , " + cmbLan.SelectedItem.ToString() + " , '" + cmbTrinhDo.SelectedItem.ToString() + "'";
                Program.myReader = Program.ExecSqlDataReader(lenh2);
                Program.myReader.Read();
                int result2 = Int32.Parse(Program.myReader.GetInt32(0).ToString());
                if (result2 == 0)
                {
                    MessageBox.Show("Trình độ không đúng. Xin chọn lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Program.myReader.Close();
                    cmbTrinhDo.Focus();
                    return;
                }
                Program.myReader.Close();
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            KiemTra();

            this.sP_XemKetQuaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_XemKetQuaTableAdapter.Fill(this.dS.SP_XemKetQua, maBD);

            string strLenh = "EXEC SP_XemKetQua '" + maBD + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            Program.myReader.Close();
            gcXemKetQua.Enabled = true;
            btnXem.Enabled = false;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            KiemTra();

            string strLenh1 = "EXEC SP_ThongTinXemKQ '" + cmbTenMH.SelectedValue.ToString() + "', '" + cmbTenLop.SelectedValue.ToString() + "', " + maBD;
            Program.myReader = Program.ExecSqlDataReader(strLenh1);

            Program.myReader.Read();
            string ngayThi = Program.myReader.GetDateTime(0).ToString();
            string lan = Program.myReader.GetInt16(1).ToString(); //vi smallint
            string[] str = ngayThi.Split(' ');
            Program.myReader.Close();
            Xrpt_XemKetQua xrpt = new Xrpt_XemKetQua(maBD);
            xrpt.lbLop.Text = cmbTenLop.SelectedValue.ToString();
            xrpt.lbHoTen.Text = Program.mHoten;
            xrpt.lbMonThi.Text = cmbTenMH.SelectedValue.ToString();
            xrpt.lbNgayThi.Text = str[0];
            xrpt.lbLanThi.Text = lan;
            ReportPrintTool print = new ReportPrintTool(xrpt);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát Form Xem kết quả không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
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
                    this.dSSVTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dSSVTableAdapter.Fill(this.dS.DSSV);
                    this.dSMHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dSMHTableAdapter.Fill(this.dS.DSMH);
                    this.dSLOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dSLOPTableAdapter.Fill(this.dS.DSLOP);
                }
                catch (Exception ex) { }
            }
        }
    }
}
