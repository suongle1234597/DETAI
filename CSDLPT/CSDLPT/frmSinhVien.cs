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
    public partial class frmSinhVien : Form
    {
        int vitri;
        string status = "", status1 ="";
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false; //khong kt khao ngoai

            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr; 
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            
            // TODO: This line of code loads data into the 'dS.DSKHOA' table. You can move, or remove it, as needed.
            this.dSKHOATableAdapter.Connection.ConnectionString = Program.connstr; //chay tren tai khaon moi nhat khi dang nhap
            this.dSKHOATableAdapter.Fill(this.dS.DSKHOA);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            // TODO: This line of code loads data into the 'dS.BANGDIEM' table. You can move, or remove it, as needed.
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;

            if (Program.mGroup == "Truong")
            {
                panelControl1.Enabled = false;
                gcLop.Enabled = false;
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

            cmbTenKhoa.SelectedIndex = 0;
            panelControlLop.Enabled = false;
            panelControlSV.Enabled = false;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bdsLop.AddNew(); //Them mot muc moi vao danh sach
            cmbTenKhoa.SelectedIndex = 0;

            vitri = bdsLop.Position;
            panelControlLop.Enabled = true;

            gcLop.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnPhucHoi.Enabled = true;
            btnRefresh.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = true;
            txtMaLop.Enabled = true;
           
            txtMaLop.Focus(); //dieu khien con tro toi o textbox
            status = "Them";
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position;
            status = "Sua";
            panelControlLop.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnRefresh.Enabled = false;
            gcLop.Enabled = false;
            txtMaLop.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (status.Equals("Them"))
            {
                if (txtMaLop.Text.Trim() == "")
                {
                    MessageBox.Show("Mã Lớp không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaLop.Focus();
                    return;
                }
                else if (txtMaLop.Text.Length > 8)
                {
                    MessageBox.Show("Mã Lớp chỉ được 8 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaLop.Focus();
                    return;
                }

                string strLenh = "EXEC SP_KiemTraLopTonTai '" + txtMaLop.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int kq = Int32.Parse(Program.myReader.GetInt32(0).ToString());
                Program.myReader.Close();

                if (kq == 1)
                {
                    MessageBox.Show("Mã Lớp đã tồn tại. Mời nhập mã lớp khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaLop.Focus();
                    return;
                }
            }

            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên Lớp không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenLop.Focus();
                return;
            }
            else if (txtTenLop.Text.Length > 40)
            {
                MessageBox.Show("Tên Lớp chỉ được 40 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenLop.Focus();
                return;
            }

            string strLenh1 = "EXEC SP_KiemTraTenLopTonTai N'" + txtTenLop.Text + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh1);
            Program.myReader.Read();
            int kq1 = Int32.Parse(Program.myReader.GetInt32(0).ToString());
            Program.myReader.Close();

            if (kq1 == 1)
            {
                MessageBox.Show("Tên lớp không được trùng. Mời nhập tên lớp khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenLop.Focus();
                return;
            }

            try
            {
                bdsLop.EndEdit(); //ket thuc qua trinh hieu chinh
                bdsLop.ResetCurrentItem(); // lay du lieu hien tai day ve co so du lieu
                this.lOPTableAdapter.Update(this.dS.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            panelControlSV.Enabled = false;
            panelControlLop.Enabled = false;
            btnGhi.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnRefresh.Enabled = true;
            btnThoat.Enabled = true;
            gcLop.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSinhVien.Count > 0)
            {
                MessageBox.Show("Lớp đã có sinh viên nên không được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (bdsGiaoVienDK.Count > 0)
            {
                MessageBox.Show("Lớp đã được đăng ký nên không được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn Lớp cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (bdsLop.Count > 0)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa Lớp này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    try
                    {
                        bdsLop.RemoveCurrent();
                        this.lOPTableAdapter.Update(this.dS.LOP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa Lớp " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }

            if (bdsLop.Count == 0)
            {
                btnXoa.Enabled = false;
            }

            gcLop.Enabled = true;
            panelControlLop.Enabled = false;
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
            bdsLop.CancelEdit(); //huy chinh sua tren hang
            bdsLop.Position = vitri;
            bdsLop.RemoveFilter();
            dS.EnforceConstraints = false; //cac quy tac khong duoc thi hanh
            this.lOPTableAdapter.Fill(this.dS.LOP);
            gcLop.Enabled = true;
            panelControlLop.Enabled = false;
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
            this.lOPTableAdapter.Fill(this.dS.LOP);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát Form Sinh viên không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        
        private void cbbTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaKH.Text = cmbTenKhoa.SelectedValue.ToString();
            }
            catch (Exception ex) { };
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            panelControlSV.Enabled = true;
            gcLop.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnRefresh.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = false;

            btnThemSV.Enabled = false;
            btnSuaSV.Enabled = false;
            btnGhiSV.Enabled = true;
            btnXoaSV.Enabled = false;
            btnRefreshSV.Enabled = false;
            btnPhucHoiSV.Enabled = true;
            txtMaSV.Enabled = true;

            this.bdsSinhVien.AddNew();
            txtMaLop2.Text = txtMaLop.Text;
            txtMaSV.Focus(); 
            status1 = "Them";
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            status1 = "Sua";
            panelControlSV.Enabled = true;
            gcLop.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnRefresh.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = false;
            txtMaSV.Enabled = false;

            btnThemSV.Enabled = false;
            btnSuaSV.Enabled = false;
            btnGhiSV.Enabled = true;
            btnXoaSV.Enabled = false;
            btnRefreshSV.Enabled = false;
            btnPhucHoiSV.Enabled = true;
        }

        private void btnGhiSV_Click(object sender, EventArgs e)
        {
            if (status1.Equals("Them"))
            {
                if (txtMaSV.Text.Trim() == "")
                {
                    MessageBox.Show("Mã SV không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaSV.Focus();
                    return;
                }
                else if (txtMaSV.Text.Length > 8)
                {
                    MessageBox.Show("Mã SV chỉ được 8 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaSV.Focus();
                    return;
                }

                string strLenh = "EXEC SP_KiemTraSVTonTai '" + txtMaSV.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int kq = Int32.Parse(Program.myReader.GetInt32(0).ToString());
                if (kq == 1)
                {
                    MessageBox.Show("Mã SV đã tồn tại. Mời nhập mã SV khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Program.myReader.Close();
                    txtMaLop.Focus();
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

            DateTime now = DateTime.Now;
            string[] year1 = dateEditNgaySinh.Text.Split('/');
            string[] year2 = now.ToShortDateString().Split('/');

            if(Int32.Parse(year2[2]) - Int32.Parse(year1[2]) < 18)
            {
                MessageBox.Show("Năm sinh của SV phải nhỏ hơn 2002", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dateEditNgaySinh.Focus();
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
                bdsSinhVien.EndEdit(); //ket thuc qua trinh hieu chinh
                bdsSinhVien.ResetCurrentItem(); // lay du lieu hien tai day ve co so du lieu
                this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi SV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            panelControl1.Enabled = true;
            gcLop.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnRefresh.Enabled = true;
            btnThoat.Enabled = true;
            btnGhi.Enabled = false;

            panelControlSV.Enabled = false;
            btnThemSV.Enabled = true;
            btnSuaSV.Enabled = true;
            btnGhiSV.Enabled = false;
            btnXoaSV.Enabled = true;
            btnRefreshSV.Enabled = true;
            btnPhucHoiSV.Enabled = true;
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn SV cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (bdsBangDiem.Count > 0)
            {
                MessageBox.Show("Sinh viên đã thi nên không được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (bdsSinhVien.Count > 0)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa SV này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    try
                    {
                        bdsSinhVien.RemoveCurrent();
                        this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa SV " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }

            if (bdsSinhVien.Count == 0)
            {
                btnXoaSV.Enabled = false;
            }

            panelControl1.Enabled = true;
            gcLop.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnRefresh.Enabled = true;
            btnThoat.Enabled = true;
            btnGhi.Enabled = false;

            btnThemSV.Enabled = true;
            btnSuaSV.Enabled = true;
            btnGhiSV.Enabled = false;
            btnXoaSV.Enabled = true;
            btnRefreshSV.Enabled = true;
            btnPhucHoiSV.Enabled = true;
        }

        private void btnPhucHoiSV_Click(object sender, EventArgs e)
        {
            bdsSinhVien.CancelEdit();
            bdsSinhVien.RemoveFilter();
            dS.EnforceConstraints = false; //cac quy tac khong duoc thi hanh
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            panelControl1.Enabled = true;
            gcLop.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnRefresh.Enabled = true;
            btnThoat.Enabled = true;
            btnGhi.Enabled = false;

            btnThemSV.Enabled = true;
            btnSuaSV.Enabled = true;
            btnGhiSV.Enabled = false;
            btnXoaSV.Enabled = true;
            btnRefreshSV.Enabled = true;
            btnPhucHoiSV.Enabled = false;
        }

        private void btnRefreshSV_Click(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false; //cac quy tac khong duoc thi hanh
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            btnThemSV.Enabled = true;
            btnSuaSV.Enabled = true;
            btnGhiSV.Enabled = false;
            btnXoaSV.Enabled = true;
            btnRefreshSV.Enabled = true;
            btnPhucHoiSV.Enabled = true;
        }

        private void btnTimKiemSV_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTimKiem.Focus();
                return;
            }
            string ds = "", ds2 = "";
            try
            {
                string strLenh = "SELECT MALOP, MASV FROM SINHVIEN WHERE MASV LIKE N'%" + txtTimKiem.Text + "%' OR HO LIKE N'%" + txtTimKiem.Text + "%' OR TEN LIKE N'%" + txtTimKiem.Text + "%'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                while (Program.myReader.Read())
                {
                    ds += "'" + Program.myReader.GetString(0).Trim() + "',";
                    ds2 += "'" + Program.myReader.GetString(1).Trim() + "',";
                }
                Program.myReader.Close();
                Program.conn.Close();
                bdsLop.Filter = "MALOP IN (" + ds + ")";
                bdsSinhVien.Filter = "MASV IN (" + ds2 + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm kiếm không có kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTimKiem.Focus();
                return;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTimKiem.Focus();
                return;
            }
            string ds = "";
            try
            {
                string strLenh = "SELECT MALOP FROM LOP WHERE MALOP LIKE N'%" + txtTimKiem.Text + "%' OR TENLOP LIKE N'%" + txtTimKiem.Text + "%'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                while (Program.myReader.Read())
                {
                    ds += "'" + Program.myReader.GetString(0).Trim() + "',";
                }
                Program.myReader.Close();
                Program.conn.Close();
                bdsLop.Filter = "MALOP IN (" + ds + ")";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tìm kiếm không có kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTimKiem.Focus();
                return;
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
                    this.dSKHOATableAdapter.Connection.ConnectionString = Program.connstr; //chay tren tai khaon moi nhat khi dang nhap
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;

                    this.dSKHOATableAdapter.Fill(this.dS.DSKHOA);
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                }
                catch (Exception ex) { }
            }
        }
    }
}
