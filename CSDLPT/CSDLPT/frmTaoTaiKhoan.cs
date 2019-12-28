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
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.V_DSGVChuaCoTaiKhoan' table. You can move, or remove it, as needed.
            this.v_DSGVChuaCoTaiKhoanTableAdapter.Fill(this.dS.V_DSGVChuaCoTaiKhoan);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            if(Program.mGroup == "Truong")
            {
                cmbNhom.SelectedItem = "Truong";
                cmbNhom.Enabled = false;
            }
            else if(Program.mGroup == "Coso")
            {
                cmbNhom.Items.Add("Giangvien");
                cmbNhom.Items.Add("Coso");
                cmbNhom.Enabled = true;
            }
            cmbNhom.SelectedIndex = 0;

            //Goi cai view tra ve DataTable
            DataTable dt = new DataTable();

            //Program.servername

            dt = Program.ExecSqlDataTable("SELECT * FROM V_DSGVChuaCoTaiKhoan"); //dau cai chuoi lenh nay vao cai ham nay, ham nay thuc thi lenh, roi tra ve DataTable
            //lien ket giua bindingSource với combobox
            cmbTenGV.DataSource = dt;
            cmbTenGV.DisplayMember = "HOTEN"; //ten cot muon hien len
            cmbTenGV.ValueMember = "MAGV"; //gia tri muon hien len

            if (cmbTenGV.SelectedValue == null)
            {
                 MessageBox.Show("Không có giáo viên nào chưa có tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 return;
            }
            else
            {
                cmbTenGV.SelectedIndex = 0;
            }
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            if (cmbTenGV.SelectedValue == null)
            {
                MessageBox.Show("Không có giáo viên nào chưa có tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                if (txtTaiKhoan.Text.Trim() == "")
                {
                    MessageBox.Show("Tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTaiKhoan.Focus();
                    return;
                }
                if (txtMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMatKhau.Focus();
                    return;
                }

                try
                {
                    string strLenh = "EXEC sp_TaoTaiKhoan '" + txtTaiKhoan.Text + "', '" + txtMatKhau.Text + "', '" + cmbTenGV.SelectedValue.ToString() + "' , '" + cmbNhom.SelectedItem.ToString() + "'";
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();
                    Program.myReader.Close();
                    MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tạo tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát Form Tạo tài khoản không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
