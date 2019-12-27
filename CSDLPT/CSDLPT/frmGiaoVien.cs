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
    public partial class frmGiaoVien : Form
    {
        int vitri;
        string status = "", status1 = "";

        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Fill(this.dS.BODE);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Fill(this.dS.BODE);
            dS.EnforceConstraints = false; //khong kt khao ngoai

            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr; 
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            txtMaKH2.Enabled = false;
            
            if(Program.mCoso == 0)
            {
                txtMaCS.Text = "CS1";
            }
            else if (Program.mCoso == 1)
            {
                txtMaCS.Text = "CS2";
            }
            txtMaCS.Enabled = false;

            if (Program.mGroup == "Truong")
            {
                panelControl1.Enabled = false;
                gcKhoa.Enabled = false;
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

            panelControlKhoa.Enabled = false;
            panelControlGiaoVien.Enabled = false;
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);
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
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Fill(this.dS.KHOA);
                    this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
                }
                catch (Exception ex) { }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bdsKhoa.AddNew(); //Them mot muc moi vao danh sach
            vitri = bdsKhoa.Position;
            panelControlKhoa.Enabled = true;
            panelControlGiaoVien.Enabled = false;

            gcKhoa.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnPhucHoi.Enabled = true;
            btnRefresh.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = true;
            txtMaKH.Enabled = true;

            txtMaKH.Focus(); //dieu khien con tro toi o textbox
            if (Program.mCoso == 0)
            {
                txtMaCS.Text = "CS1";
            }
            else if (Program.mCoso == 1)
            {
                txtMaCS.Text = "CS2";
            }
            status = "Them";
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKhoa.Position;
            status = "Sua";
            panelControlKhoa.Enabled = true;
            panelControlGiaoVien.Enabled = false;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnRefresh.Enabled = false;
            gcKhoa.Enabled = false;
            txtMaKH.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (status.Equals("Them"))
            {
                if (txtMaKH.Text.Trim() == "")
                {
                    MessageBox.Show("Mã Khoa không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaKH.Focus();
                    return;
                }
                else if (txtMaKH.Text.Length > 8)
                {
                    MessageBox.Show("Mã Khoa chỉ được 8 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaKH.Focus();
                    return;
                }

                string strLenh = "EXEC SP_KiemTraKhoaTonTai '" + txtMaKH.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int kq = Int32.Parse(Program.myReader.GetInt32(0).ToString());
                if (kq == 1)
                {
                    MessageBox.Show("Mã khoa đã tồn tại. Mời nhập mã khoa khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Program.myReader.Close();
                    txtMaKH.Focus();
                    return;
                }
                Program.myReader.Close();
            }

            if (txtTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Tên Khoa không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenKH.Focus();
                return;
            }
            else if (txtTenKH.Text.Length > 40)
            {
                MessageBox.Show("Tên Khoa chỉ được 40 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenKH.Focus();
                return;
            }

            string strLenh1 = "EXEC SP_KiemTraTenKhoaTonTai N'" + txtTenKH.Text + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh1);
            Program.myReader.Read();
            int kq1 = Int32.Parse(Program.myReader.GetInt32(0).ToString());
            if (kq1 == 1)
            {
                MessageBox.Show("Tên Khoa không được trùng. Mời nhập tên khoa khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Program.myReader.Close();
                txtTenKH.Focus();
                return;
            }
            Program.myReader.Close();

            try
            {
                bdsKhoa.EndEdit(); //ket thuc qua trinh hieu chinh
                bdsKhoa.ResetCurrentItem(); // lay du lieu hien tai day ve co so du lieu
                this.kHOATableAdapter.Update(this.dS.KHOA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            panelControlKhoa.Enabled = false;
            panelControlGiaoVien.Enabled = false;

            btnGhi.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnRefresh.Enabled = true;
            btnThoat.Enabled = true;
            gcKhoa.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsGiaoVien.Count > 0)
            {
                MessageBox.Show("Khoa đã có Giáo viên nên không được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn Khoa cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (bdsKhoa.Count > 0)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa Khoa này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    try
                    {
                        bdsKhoa.RemoveCurrent();
                        this.kHOATableAdapter.Update(this.dS.KHOA);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa Khoa" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }

            if (bdsKhoa.Count == 0)
            {
                btnXoa.Enabled = false;
            }

            gcKhoa.Enabled = true;
            panelControlKhoa.Enabled = false;
            panelControlGiaoVien.Enabled = false;
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
            bdsKhoa.CancelEdit(); //huy chinh sua tren hang
            bdsKhoa.Position = vitri;
            gcKhoa.Enabled = true;
            panelControlKhoa.Enabled = false;
            panelControlGiaoVien.Enabled = false;
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
            this.kHOATableAdapter.Fill(this.dS.KHOA);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát Form Gíao viên không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            panelControlGiaoVien.Enabled = true;
            gcKhoa.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnRefresh.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = false;

            btnThemGV.Enabled = false;
            btnSuaGV.Enabled = false;
            btnGhiGV.Enabled = true;
            btnXoaGV.Enabled = false;
            btnRefreshGV.Enabled = false;
            btnPhucHoiGV.Enabled = true;
            txtMaGV.Enabled = true;

            this.bdsGiaoVien.AddNew();
            txtMaKH2.Text = txtMaKH.Text;
            txtMaGV.Focus();
            status1 = "Them";
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            status1 = "Sua";
            panelControlKhoa.Enabled = false;
            panelControlGiaoVien.Enabled = true;
            gcKhoa.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnRefresh.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = false;
            txtMaGV.Enabled = false;

            btnThemGV.Enabled = false;
            btnSuaGV.Enabled = false;
            btnGhiGV.Enabled = true;
            btnXoaGV.Enabled = false;
            btnRefreshGV.Enabled = false;
            btnPhucHoiGV.Enabled = true;
        }

        private void btnGhiGV_Click(object sender, EventArgs e)
        {
            if (status1.Equals("Them"))
            {
                if (txtMaGV.Text.Trim() == "")
                {
                    MessageBox.Show("Mã GV không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaGV.Focus();
                    return;
                }
                else if (txtMaGV.Text.Length > 8)
                {
                    MessageBox.Show("Mã GV chỉ được 8 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaGV.Focus();
                    return;
                }

                string strLenh = "EXEC SP_KiemTraGVTonTai '" + txtMaGV.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int kq = Int32.Parse(Program.myReader.GetInt32(0).ToString());
                if (kq == 1)
                {
                    MessageBox.Show("Mã GV đã tồn tại. Mời nhập mã GV khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Program.myReader.Close();
                    txtMaGV.Focus();
                    return;
                }
                Program.myReader.Close();
            }

            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtHo.Focus();
                return;
            }
            else if (txtHo.Text.Length > 40)
            {
                MessageBox.Show("Họ chỉ được 40 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtHo.Focus();
                return;
            }

            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTen.Focus();
                return;
            }
            else if (txtTen.Text.Length > 10)
            {
                MessageBox.Show("Tên chỉ được 10 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTen.Focus();
                return;
            }

            if (txtDiaChi.Text.Length > 40)
            {
                MessageBox.Show("Địa chỉ chỉ được 40 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDiaChi.Focus();
                return;
            }

            try
            {
                bdsGiaoVien.EndEdit(); //ket thuc qua trinh hieu chinh
                bdsGiaoVien.ResetCurrentItem(); // lay du lieu hien tai day ve co so du lieu
                this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi GV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            panelControl1.Enabled = true;
            gcKhoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnRefresh.Enabled = true;
            btnThoat.Enabled = true;
            btnGhi.Enabled = false;

            panelControlKhoa.Enabled = false;
            panelControlGiaoVien.Enabled = false;
            btnThemGV.Enabled = true;
            btnSuaGV.Enabled = true;
            btnGhiGV.Enabled = false;
            btnXoaGV.Enabled = true;
            btnRefreshGV.Enabled = true;
            btnPhucHoiGV.Enabled = false;
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn GV cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (bdsBoDe.Count > 0)
            {
                MessageBox.Show("Giáo viên đã soạn bộ đề nên không được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (bdsGVDK.Count > 0)
            {
                MessageBox.Show("Giáo viên đã đăng ký thi nên không được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (bdsGiaoVien.Count > 0)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa GV này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    try
                    {
                        bdsGiaoVien.RemoveCurrent();
                        this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa GV " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }

            if (bdsGiaoVien.Count == 0)
            {
                btnXoaGV.Enabled = false;
            }

            panelControl1.Enabled = true;
            gcKhoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnRefresh.Enabled = true;
            btnThoat.Enabled = true;
            btnGhi.Enabled = false;

            panelControlKhoa.Enabled = false;
            panelControlGiaoVien.Enabled = false;
            btnThemGV.Enabled = true;
            btnSuaGV.Enabled = true;
            btnGhiGV.Enabled = false;
            btnXoaGV.Enabled = true;
            btnRefreshGV.Enabled = true;
            btnPhucHoiGV.Enabled = true;
        }

        private void btnPhucHoiGV_Click(object sender, EventArgs e)
        {
            bdsGiaoVien.CancelEdit();
            panelControl1.Enabled = true;
            gcKhoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnRefresh.Enabled = true;
            btnThoat.Enabled = true;
            btnGhi.Enabled = false;

            panelControlKhoa.Enabled = false;
            panelControlGiaoVien.Enabled = false;
            btnThemGV.Enabled = true;
            btnSuaGV.Enabled = true;
            btnGhiGV.Enabled = false;
            btnXoaGV.Enabled = true;
            btnRefreshGV.Enabled = true;
            btnPhucHoiGV.Enabled = false;
        }

        private void btnRefreshGV_Click(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false; //cac quy tac khong duoc thi hanh
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            panelControlKhoa.Enabled = false;
            panelControlGiaoVien.Enabled = false;
            btnThemGV.Enabled = true;
            btnSuaGV.Enabled = true;
            btnGhiGV.Enabled = false;
            btnXoaGV.Enabled = true;
            btnRefreshGV.Enabled = true;
            btnPhucHoiGV.Enabled = true;

        }
    }
}
