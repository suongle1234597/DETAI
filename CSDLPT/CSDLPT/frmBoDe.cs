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
    public partial class frmBoDe : Form
    {
        String status = "";
        int vitri;
        public frmBoDe()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBoDe.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);
        }

        private void frmDe_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false; //khong kt khao ngoai

            // TODO: This line of code loads data into the 'dS.DSMH' table. You can move, or remove it, as needed.
            this.dSMHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSMHTableAdapter.Fill(this.dS.DSMH);

            // TODO: This line of code loads data into the 'dS.DSGV' table. You can move, or remove it, as needed.
            this.dSGVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSGVTableAdapter.Fill(this.dS.DSGV);
            // TODO: This line of code loads data into the 'dS.DSMH' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'dS.CHITIET_BAITHI' table. You can move, or remove it, as needed.
            this.cHITIET_BAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cHITIET_BAITHITableAdapter.Fill(this.dS.CHITIET_BAITHI);
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);


            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;

            cmbTrinhDo.Items.Add("A");
            cmbTrinhDo.Items.Add("B");
            cmbTrinhDo.Items.Add("C");

            cmbDapAn.Items.Add("A");
            cmbDapAn.Items.Add("B");
            cmbDapAn.Items.Add("C");
            cmbDapAn.Items.Add("D");

            cmbTrinhDo.SelectedIndex = 0;
            cmbDapAn.SelectedIndex = 0;

            if (Program.mGroup == "Truong")
            {
                panelControl1.Enabled = false;
                gcBoDe.Enabled = false;
                gcBoDe.UseDisabledStatePainter = false; //khong phan biet mau
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
                //gcMonHoc.UseDisabledStatePainter = false; //khong phan biet mau
                btnGhi.Enabled = false;
                cmbCoSo.Enabled = false;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bdsBoDe.AddNew(); //Them mot muc moi vao danh sach

            cmbTrinhDo.SelectedIndex = 1;
            cmbDapAn.SelectedIndex = 1;
            cmbTrinhDo.SelectedIndex = 0;
            cmbDapAn.SelectedIndex = 0;

            vitri = bdsBoDe.Position;
            panelControl1.Enabled = true;

            gcBoDe.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnPhucHoi.Enabled = true;
            btnRefresh.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = true;
            txtMaMH.Enabled = true;

           
            txtMaMH.Focus(); //dieu khien con tro toi o textbox
            status = "Them";
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsBoDe.Position;
            status = "Sua";
            panelControl1.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnRefresh.Enabled = false;
            gcBoDe.Enabled = false;
            txtMaMH.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (status.Equals("Them"))
            {
                if (txtCauHoi.Text.Trim() == "")
                {
                    MessageBox.Show("Nội dung không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCauHoi.Focus();
                    return;
                }

                string strLenh = "EXEC SP_TimKiemMaBoDe '" + txtCauHoi.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int kq = Int32.Parse(Program.myReader.GetInt32(0).ToString());
                if (kq == 1)
                {
                    MessageBox.Show("Câu hỏi đã tồn tại. Mời nhập mã câu hỏi khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Program.myReader.Close();
                    Program.conn.Close();
                    txtCauHoi.Focus();
                    return;
                }
                Program.myReader.Close();
            }

            if (txtNoiDung.Text.Trim() == "")
            {
                MessageBox.Show("Nội dung không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNoiDung.Focus();
                return;
            }
            if (txtA.Text.Trim() == "")
            {
                MessageBox.Show("Câu A không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtA.Focus();
                return;
            }
            if (txtB.Text.Trim() == "")
            {
                MessageBox.Show("Câu B không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtB.Focus();
                return;

            }
            if (txtC.Text.Trim() == "")
            {
                MessageBox.Show("Câu C không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtC.Focus();
                return;
            }
            if (txtD.Text.Trim() == "")
            {
                MessageBox.Show("Câu D không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtD.Focus();
                return;
            }

            string strLenh1 = "EXEC SP_KTBoDeNoiDung N'" + txtNoiDung.Text + "', N'" + txtA.Text +"', N'" + txtB.Text + "', N'" + txtC.Text  + "', N'" + txtD.Text  + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh1);
            Program.myReader.Read();
            int kq1 = Int32.Parse(Program.myReader.GetInt32(0).ToString());
            if (kq1 == 1)
            {
                MessageBox.Show("Nội dung và đáp án của câu hỏi bị trùng. Mời nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Program.myReader.Close();
                Program.conn.Close();
                txtNoiDung.Focus();
                return;
            }
            Program.myReader.Close();

            try
            {
                bdsBoDe.EndEdit(); //ket thuc qua trinh hieu chinh
                bdsBoDe.ResetCurrentItem(); // lay du lieu hien tai day ve co so du lieu
                this.bODETableAdapter.Update(this.dS.BODE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi bộ đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            panelControl1.Enabled = false;
            btnGhi.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnRefresh.Enabled = true;
            btnThoat.Enabled = true;
            gcBoDe.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsChiTietBaiThi.Count > 0)
            {
                MessageBox.Show("Câu hỏi này đã thi, không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn Câu hỏi cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (bdsBoDe.Count > 0)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa Câu hỏi này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    try
                    {
                        bdsBoDe.RemoveCurrent();
                        this.bODETableAdapter.Update(this.dS.BODE);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa Câu hỏi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }

            if (bdsBoDe.Count == 0)
            {
                btnXoa.Enabled = false;
            }

            gcBoDe.Enabled = true;
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
            bdsBoDe.CancelEdit(); //huy chinh sua tren hang
            bdsBoDe.Position = vitri;
            gcBoDe.Enabled = true;
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
            this.bODETableAdapter.Fill(this.dS.BODE);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát Form Bộ đề không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
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
                    this.cHITIET_BAITHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cHITIET_BAITHITableAdapter.Fill(this.dS.CHITIET_BAITHI);
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Fill(this.dS.BODE);
                }
                catch (Exception ex) { }
            }
        }

        private void cmbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaMH.Text = cmbTenMH.SelectedValue.ToString();
            }
            catch (Exception ex) { };
        }

        private void cmbTenGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaGV.Text = cmbTenGV.SelectedValue.ToString();
            }
            catch (Exception ex) { };
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
