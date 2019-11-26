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
            // TODO: This line of code loads data into the 'dS.DSKHOA' table. You can move, or remove it, as needed.
            this.dSKHOATableAdapter.Connection.ConnectionString = Program.connstr; //chay tren tai khaon moi nhat khi dang nhap
            this.dSKHOATableAdapter.Fill(this.dS.DSKHOA);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DSPM);

            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

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
        }
        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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

            this.bdsLop.AddNew(); //Them mot muc moi vao danh sach
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
            String strLenh;

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

            try
            {
                bdsLop.EndEdit(); //ket thuc qua trinh hieu chinh
                bdsLop.ResetCurrentItem(); // lay du lieu hien tai day ve co so du lieu
                this.lOPTableAdapter.Update(this.dS.LOP);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("unique") || ex.Message.Contains("PRIMARY"))
                {
                    MessageBox.Show("Mã Lớp đã tồn tại. Mời nhập mã lớp khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Program.conn.Close();
                    txtMaLop.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Lỗi ghi lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

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

        private void cmbCoSo_SelectedValueChanged(object sender, EventArgs e)
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
                Program.password = Program.mloginDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở mới", "", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    //this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    //this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                }
                catch (Exception ex) { }
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
                if (ex.Message.Contains("unique") || ex.Message.Contains("PRIMARY"))
                {
                    MessageBox.Show("Mã SV đã tồn tại. Mời nhập mã SV khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Program.conn.Close();
                    txtMaSV.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Lỗi ghi SV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
            //if (bdsSinhVien.Count > 0)
            //{
            //    MessageBox.Show("Lớp đã có sinh viên nên không được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //    return;
            //}

            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn SV cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnThoatSV_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.OK)
            {

            }
        }
    }
}
