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
            // TODO: This line of code loads data into the 'dS.DSLOP' table. You can move, or remove it, as needed.
            this.dSLOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSLOPTableAdapter.Fill(this.dS.DSLOP);
            // TODO: This line of code loads data into the 'dS.DSMH' table. You can move, or remove it, as needed.
            this.dSMHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSMHTableAdapter.Fill(this.dS.DSMH);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DSPM);
            // TODO: This line of code loads data into the 'dS.DSGV' table. You can move, or remove it, as needed.
            this.dSGVTableAdapter.Fill(this.dS.DSGV);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

            panelControl1.Enabled = false;
            gcGiaoVienDK.Enabled = false;
            gcGiaoVienDK.UseDisabledStatePainter = false; //khong phan biet mau

            cmbTrinhDo.Items.Add("A");
            cmbTrinhDo.Items.Add("B");
            cmbTrinhDo.Items.Add("C");

            cmbLan.Items.Add("1");
            cmbLan.Items.Add("2");

            cmbTrinhDo.SelectedIndex = 0;
            cmbLan.SelectedIndex = 0;

            if (cmbHoTen.SelectedValue.ToString() != null)
            {
                txtMaGV.Text = cmbHoTen.SelectedValue.ToString();
            }
            if (cmbTenMH.SelectedValue.ToString() != null)
            {
                txtMaMH.Text = cmbTenMH.SelectedValue.ToString();
            }
            if (cmbTenLop.SelectedValue.ToString() != null)
            {
                txtMaLop.Text = cmbTenLop.SelectedValue.ToString();
            }

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;

            //if (Program.mGroup == "Truong")
            //{
            //    panelControl1.Enabled = false;
            //    gcGiaoVienDK.Enabled = false;
            //    btnThem.Enabled = false;
            //    btnSua.Enabled = false;
            //    btnXoa.Enabled = false;
            //    btnPhucHoi.Enabled = false;
            //    btnRefresh.Enabled = false;
            //    btnThoat.Enabled = true;
            //    btnGhi.Enabled = false;
            //    cmbCoSo.Enabled = true;
            //}
            //else
            //{
            //    //gcMonHoc.Enabled = false;
            //    btnGhi.Enabled = false;
            //    cmbCoSo.Enabled = false;
            //}
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
            if (bdsLop.Count > 0)
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
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnPhucHoi.Enabled = true;
            btnRefresh.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = true;

            status = "Them";
        }

        private int getViTri(BindingSource bds, string text)
        {
            int a = 0;
            for (int i = 0; i < bds.Count; i++)
            {
                if (bds == bdsDSGV)
                {
                    if (text.Equals(((DataRowView)bds[i])["MAGV"].ToString()))
                    {
                        a = i;
                        break;
                    }
                }
                else if (bds == bdsMH)
                {
                    if (text.Equals(((DataRowView)bds[i])["MAMH"].ToString()))
                    {
                        a = i;
                        break;
                    }
                }
                else if (bds == bdsLop)
                {
                    if (text.Equals(((DataRowView)bds[i])["MALop"].ToString()))
                    {
                        a = i;
                        break;
                    }
                }
            }
            return a;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbHoTen.SelectedIndex = getViTri(bdsDSGV, txtMaGV.Text);
            cmbTenMH.SelectedIndex = getViTri(bdsMH, txtMaMH.Text);
            cmbTenLop.SelectedIndex = getViTri(bdsLop, txtMaLop.Text);

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
            //string strLenh = "DECLARE @result int EXEC @result = dbo.SP_SOCAUHOI '" + txtMaMH + "'";
            string strLenh = "EXEC dbo.SP_SOCAUHOI '" + txtMaMH + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            //int kq = int.Parse(Program.myReader[0].ToString());
            MessageBox.Show("So cau hoi " + Program.myReader[0].ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Program.myReader.Close();
            //else if() so cau thi phai nho hon so luong trong de va lon hon 10

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

            try
            {
                bdsGiaoVienDK.EndEdit(); //ket thuc qua trinh hieu chinh
                bdsGiaoVienDK.ResetCurrentItem(); // lay du lieu hien tai day ve co so du lieu
                this.gIAOVIEN_DANGKYTableAdapter.Update(this.dS.GIAOVIEN_DANGKY);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("unique") || ex.Message.Contains("PRIMARY"))
                {
                    MessageBox.Show("Lớp này đã được đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Program.conn.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Lỗi ghi đăng ký thi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            panelControl1.Enabled = false;
            btnGhi.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnRefresh.Enabled = true;
            btnThoat.Enabled = true;
            gcGiaoVienDK.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //    if (bdsBoDe.Count > 0)
            //    {
            //        MessageBox.Show("Môn học đã có bộ đề, không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //        return;
            //    }
            //    if (bdsGVDK.Count > 0)
            //    {
            //        MessageBox.Show("Môn học có đăng kí thi nên không được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //        return;
            //    }
            //    if (bdsBangDiem.Count > 0)
            //    {
            //        MessageBox.Show("Môn học có bảng điểm nên không được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //        return;
            //    }

            if (txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn Lớp đăng ký cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

    }
}
