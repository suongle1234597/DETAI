﻿using DevExpress.XtraReports.UI;
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
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.DSMH' table. You can move, or remove it, as needed.
            this.dSMHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSMHTableAdapter.Fill(this.dS.DSMH);
            // TODO: This line of code loads data into the 'dS.DSLOP' table. You can move, or remove it, as needed.
            this.dSLOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSLOPTableAdapter.Fill(this.dS.DSLOP);

            cmbLan.Items.Add("1");
            cmbLan.Items.Add("2");

            cmbLan.SelectedIndex = 0;

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;

            if (Program.mGroup == "Coso" || Program.mGroup == "Giangvien")
            {
                cmbCoSo.Enabled = false;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string strLenh = "EXEC dbo.SP_KTGVDKTonTaiTungCoSo '" + cmbTenMH.SelectedValue.ToString() + "', '" + cmbTenLop.SelectedValue.ToString() + "' , " + cmbLan.SelectedItem.ToString();
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            int kq = int.Parse(Program.myReader[0].ToString());
            Program.myReader.Close();
            if (kq == 0)
            {
                MessageBox.Show("Lớp này chưa được đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbTenLop.Focus();
                return;
            }
            string strLenh1 = "SELECT dbo.KiemTraMonHocDaThi('" + cmbTenMH.SelectedValue.ToString() + "', " + cmbLan.SelectedItem.ToString() + ", '"  + cmbTenLop.SelectedValue.ToString().Trim() + "') AS DATHI";
            Program.myReader = Program.ExecSqlDataReader(strLenh1);
            Program.myReader.Read();
            string kt = Program.myReader[0].ToString();
            Program.myReader.Close();

            if (kt.Trim() == "")
            {
                MessageBox.Show("Môn học này chưa thi. Xin chọn lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbTenMH.Focus();
                return;
            }

            Xrpt_XemBangDiem xrpt = new Xrpt_XemBangDiem(cmbTenLop.SelectedValue.ToString(), cmbTenMH.SelectedValue.ToString(), cmbLan.SelectedItem.ToString());
            string tenCoSo = "";
            if (cmbCoSo.SelectedIndex == 0)
            {
                tenCoSo = "CƠ SỞ 1";
            }
            else if (cmbCoSo.SelectedIndex == 1)
            {
                tenCoSo = "CƠ SỞ 2";
            }
            xrpt.lbCoSo.Text = tenCoSo;
            xrpt.lbTenLop.Text = cmbTenLop.Text;
            xrpt.lbTenMH.Text = cmbTenMH.Text;
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
