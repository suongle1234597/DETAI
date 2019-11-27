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
    public partial class frmThi : Form
    {
        int phut = 0, giay = 59;
        public frmThi()
        {
            InitializeComponent();
        }

        private void load_ThongTinThi()
        {   
           
            if (txtMaLop.Text.Trim() != "" && dateEditNgayThi.Text.Trim() != "")
            {
                string strLenh = "EXEC dbo.SP_KiemTraDangKy '" + cmbTenMH.SelectedValue.ToString().Trim() + "', '"+ txtMaLop.Text.Trim() + "', " + Int32.Parse(cmbLan.SelectedItem.ToString());

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                if (Program.myReader == null) return;
                int dem = 0;
                if (Program.myReader.HasRows)
                {
                    dem++;
                }
                if(dem == 0){ 
                    MessageBox.Show("Lớp này chưa được đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Program.myReader.Close();
                    txtSoCauThi.Text = "";
                    txtThoiGian.Text = "";
                    txtTrinhDo.Text = "";
                    return;
                }

                string ngay = Program.myReader.GetDateTime(4).ToString();
                string[] str = ngay.Split(' ');

                if (!dateEditNgayThi.Text.Trim().Equals(str[0]))
                {
                    MessageBox.Show("Ngày thi không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtSoCauThi.Text = "";
                    txtThoiGian.Text = "";
                    txtTrinhDo.Text = "";
                    dateEditNgayThi.Focus();
                    Program.myReader.Close();
                    return;
                }
                else
                {
                    txtSoCauThi.Text = Program.myReader.GetInt16(6).ToString();
                    txtThoiGian.Text = Program.myReader.GetInt16(7).ToString();
                    txtTrinhDo.Text = Program.myReader.GetString(3);
                }

                Program.myReader.Close();
                Program.conn.Close();
            }
        }

        private void frmThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.DSLOP' table. You can move, or remove it, as needed.
            this.dSLOPTableAdapter.Fill(this.dS.DSLOP);
            // TODO: This line of code loads data into the 'dS.DSLOP' table. You can move, or remove it, as needed.
            this.dSLOPTableAdapter.Fill(this.dS.DSLOP);
            // TODO: This line of code loads data into the 'dS.DSMH' table. You can move, or remove it, as needed.
            this.dSMHTableAdapter.Fill(this.dS.DSMH);

            cmbLan.Items.Add("1");
            cmbLan.Items.Add("2");

            cmbLan.SelectedIndex = 0;

            txtTenLop.Enabled = false;
            txtHoTen.Enabled = false;
            txtHoTen.Text = Program.mHoten;
            txtSoCauThi.Enabled = false; 
            txtThoiGian.Enabled = false;
            txtTrinhDo.Enabled = false;
            if (Program.mGroup == "Truong" || Program.mGroup == "Coso" || Program.mGroup == "Giangvien")
            {
                txtMaLop.Enabled = true;
            }
            else
            {
                txtMaLop.Enabled = false;
            }
        }

        private void txtMaLop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Boolean flag = false;
                for (int i = 0; i < bdsLop.Count; i++)
                {
                    if ((txtMaLop.Text).Equals(((DataRowView)bdsLop[i])["MALOP"].ToString().Trim()))
                    {
                        flag = true;
                        txtTenLop.Text = ((DataRowView)bdsLop[i])["TENLOP"].ToString();
                        
                        break;
                    }
                }
                if(flag == false)
                {
                    MessageBox.Show("Mã Lớp không tồn tại. Mời nhập mã lớp khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTenLop.Text = "";
                    txtMaLop.Focus();
                    return;
                }
                load_ThongTinThi();
            }
        }

        private void dateEditNgayThi_EditValueChanged_1(object sender, EventArgs e)
        {
            load_ThongTinThi();
        }

        private void cmbTenMH_SelectedValueChanged(object sender, EventArgs e)
        {
            load_ThongTinThi();
        }

        private void cmbLan_SelectedValueChanged(object sender, EventArgs e)
        {
            load_ThongTinThi();
        }

        private void btnBatDauThi_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã Lớp không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaLop.Focus();
                return;
            }
            if (dateEditNgayThi.Text.Trim() == "")
            {
                MessageBox.Show("Ngày thi không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dateEditNgayThi.Focus();
                return;
            }

            if (txtMaLop.Text.Trim() != "" && dateEditNgayThi.Text.Trim() != "" && txtSoCauThi.Text.Trim() != "" && txtThoiGian.Text.Trim() != "" && txtTrinhDo.Text.Trim() != "")
            {
                panelControlTop.Enabled = false;
                phut = Int32.Parse(txtThoiGian.Text) - 1;
                timer1.Start();
            }
        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát Form Thi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (phut > -1)
            {
                if(giay == 0 && phut > 0)
                {
                    giay = 59;
                    phut--;
                }
                giay--;
            }

            if(phut == 0 && giay == 0)
            {
                timer1.Stop();
                labelDongHo.Text = "00 : 00";

            }
            else
            {
                labelDongHo.Text = phut + " : " + giay;

            }



        }
    }
}
