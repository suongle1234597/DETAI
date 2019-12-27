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
    public partial class frmGiaoVienDK : Form
    {
        int vitri;
        string status = "";
        public frmGiaoVienDK()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGiaoVienDK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);
        }

        private void frmGiaoVienDK_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.DSLOP' table. You can move, or remove it, as needed.
            this.dSLOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSLOPTableAdapter.Fill(this.dS.DSLOP);
            // TODO: This line of code loads data into the 'dS.DSMH' table. You can move, or remove it, as needed.
            this.dSMHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSMHTableAdapter.Fill(this.dS.DSMH);
            // TODO: This line of code loads data into the 'dS.DSGV' table. You can move, or remove it, as needed.
            this.dSGVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSGVTableAdapter.Fill(this.dS.DSGV);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

            panelControl1.Enabled = false;
            //gcGiaoVienDK.Enabled = false;
            //gcGiaoVienDK.UseDisabledStatePainter = false; //khong phan biet mau

            cmbTrinhDo.Items.Add("A");
            cmbTrinhDo.Items.Add("B");
            cmbTrinhDo.Items.Add("C");

            cmbLan.Items.Add("1");
            cmbLan.Items.Add("2");

            cmbTrinhDo.SelectedIndex = 0;
            cmbLan.SelectedIndex = 0;

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;

            if (Program.mGroup == "Truong")
            {
                panelControl1.Enabled = false;
                gcGiaoVienDK.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnPhucHoi.Enabled = false;
                btnRefresh.Enabled = false;
                btnThoat.Enabled = true;
                btnGhi.Enabled = false;
                cmbCoSo.Enabled = true;
            }
            else
            {
                //gcMonHoc.Enabled = false;
                btnGhi.Enabled = false;
                cmbCoSo.Enabled = false;
            }
        }

        private void cmbHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaGV.Text = cmbHoTen.SelectedValue.ToString();
            }
            catch (Exception ex) { };
        }

        private void cmbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaMH.Text = cmbTenMH.SelectedValue.ToString();
            }
            catch (Exception ex) { };
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaLop.Text = cmbTenLop.SelectedValue.ToString();
            }
            catch (Exception ex) { };
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bdsGiaoVienDK.AddNew();

            if (bdsDSGV.Count > 0)
            {
                cmbHoTen.SelectedIndex = 0;
                txtMaGV.Text = cmbHoTen.SelectedValue.ToString();
            }
            if (bdsMH.Count > 0)
            {
                cmbTenMH.SelectedIndex = 0;
                txtMaMH.Text = cmbTenMH.SelectedValue.ToString();
            }
            if (bdsDSLop.Count > 0)
            {
                cmbTenLop.SelectedIndex = 0;
                txtMaLop.Text = cmbTenLop.SelectedValue.ToString();
            }

            cmbTrinhDo.SelectedIndex = 1;
            cmbLan.SelectedIndex = 1;
            cmbTrinhDo.SelectedIndex = 0;
            cmbLan.SelectedIndex = 0;

            vitri = bdsGiaoVienDK.Position;
            panelControl1.Enabled = true;

            gcGiaoVienDK.Enabled = false;
            gcGiaoVienDK.UseDisabledStatePainter = false; //khong phan biet mau
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnPhucHoi.Enabled = true;
            btnRefresh.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = true;
            cmbTenMH.Enabled = true;
            cmbTenLop.Enabled = true;
            cmbLan.Enabled = true;

            cmbHoTen.Focus();
            status = "Them";
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLenh = "SELECT dbo.KiemTraMonHocDaThi('" + txtMaMH.Text.Trim() + "', " + cmbLan.SelectedItem.ToString() + ") AS DATHI";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            string kt = Program.myReader[0].ToString();
            Program.myReader.Close();

            if (kt.Trim() != "")
            {
                MessageBox.Show("Lớp này đã thi, không được sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Program.conn.Close();
                return;
            }

            vitri = bdsGiaoVienDK.Position;
            panelControl1.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnRefresh.Enabled = false;
            gcGiaoVienDK.Enabled = false;
            gcGiaoVienDK.UseDisabledStatePainter = false; //khong phan biet mau
            cmbTenMH.Enabled = false;
            cmbTenLop.Enabled = false;
            cmbLan.Enabled = false;

            status = "Sua";
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (status.Equals("Them"))
            {
                if (dateEditNgayThi.Text.Trim() == "")
                {
                    MessageBox.Show("Ngày thi không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dateEditNgayThi.Focus();
                    return;
                }
                else if (dateEditNgayThi.DateTime <= DateTime.Now)
                {
                    MessageBox.Show("Ngày thi không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dateEditNgayThi.Focus();
                    return;
                }
            }

            if(spinEditSoCauThi.Text.Trim() == "")
            {
                MessageBox.Show("Số câu thi không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                spinEditSoCauThi.Focus();
                return;
            }
            else {
                if (spinEditSoCauThi.Value < 10)
                {
                    MessageBox.Show("Số câu thi không được nhỏ hơn 10 ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    spinEditSoCauThi.Focus();
                    return;
                }
                else
                {
                    string strLenh = "EXEC dbo.SP_KTSoCau '" + cmbTrinhDo.SelectedItem.ToString() + "' , '" + txtMaMH.Text + "' , " + spinEditSoCauThi.Value;
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();
                    int kq = int.Parse(Program.myReader.GetInt32(0).ToString());
                    Program.myReader.Close();

                    if (kq == 0)
                    {
                        MessageBox.Show("Số câu thi của môn học theo trình độ không đủ để đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cmbTenMH.Focus();
                        return;
                    }
                }
            }

            if (spinEditThoiGian.Text == "")
            {
                MessageBox.Show("Thời gian thi không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                spinEditThoiGian.Focus();
                return;
            }
            else if (spinEditThoiGian.Value < 15 || spinEditThoiGian.Value > 60)
            {
                MessageBox.Show("Thời gian thi phải nằm trong khoảng 15 đến 60 phút!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                spinEditThoiGian.Focus();
                return;
            }

            if(status == "Them")
            {
                string strLenh2 = "EXEC dbo.SP_KTGVDKTonTai '" + txtMaMH.Text + "', '" + txtMaLop.Text + "' , " + cmbLan.SelectedItem.ToString();
                Program.myReader = Program.ExecSqlDataReader(strLenh2);
                Program.myReader.Read();
                int kq2 = int.Parse(Program.myReader[0].ToString());
                Program.myReader.Close();
                if (kq2 == 1)
                {
                    MessageBox.Show("Lớp này đã được đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            try
            {
                bdsGiaoVienDK.EndEdit(); //ket thuc qua trinh hieu chinh
                bdsGiaoVienDK.ResetCurrentItem(); // lay du lieu hien tai day ve co so du lieu
                this.gIAOVIEN_DANGKYTableAdapter.Update(this.dS.GIAOVIEN_DANGKY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đăng ký thi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            panelControl1.Enabled = false;
            btnGhi.Enabled = false;
            btnPhucHoi.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnRefresh.Enabled = true;
            btnThoat.Enabled = true;
            gcGiaoVienDK.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (txtMaMH.Text.Trim() == "" && txtMaLop.Text.Trim() == "" && cmbLan.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Vui lòng chọn Lớp đăng ký cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string strLenh = "SELECT dbo.KiemTraMonHocDaThi('" + txtMaMH.Text.Trim() + "', " + cmbLan.SelectedItem.ToString() + ") AS DATHI";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            string kt = Program.myReader[0].ToString();
            Program.myReader.Close();

            if (kt.Trim() != "")
            {
                MessageBox.Show("Lớp này đã thi, không được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Program.conn.Close();
                return;
            }

            if (bdsGiaoVienDK.Count > 0)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa Lớp này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    try
                    {
                        bdsGiaoVienDK.RemoveCurrent();
                        this.gIAOVIEN_DANGKYTableAdapter.Update(this.dS.GIAOVIEN_DANGKY);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa Lớp đăng ký thi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }

            if (bdsGiaoVienDK.Count == 0)
            {
                btnXoa.Enabled = false;
            }

            gcGiaoVienDK.Enabled = true;
            panelControl1.Enabled = false;
            btnGhi.Enabled = false;
            btnPhucHoi.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnRefresh.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGiaoVienDK.CancelEdit(); //huy chinh sua tren hang

            this.dSLOPTableAdapter.Fill(this.dS.DSLOP);
            this.dSMHTableAdapter.Fill(this.dS.DSMH);
            this.dSGVTableAdapter.Fill(this.dS.DSGV);
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

            bdsGiaoVienDK.Position = vitri;
            gcGiaoVienDK.Enabled = true;
            panelControl1.Enabled = false;
            btnGhi.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnRefresh.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dS.EnforceConstraints = false; //cac quy tac khong duoc thi hanh
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát Form Giáo viên Đăng ký không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
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
                    this.dSLOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dSMHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dSGVTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;

                    this.dSLOPTableAdapter.Fill(this.dS.DSLOP);
                    this.dSMHTableAdapter.Fill(this.dS.DSMH);
                    this.dSGVTableAdapter.Fill(this.dS.DSGV);
                    this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
                }
                catch (Exception ex) { }
            }
        }
    }
}
