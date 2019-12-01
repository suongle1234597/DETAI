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
        int phut = 0, giay = 59, cau = 1;
        List<string> dapAn = new List<string>();
        string maSV = "";
        public frmThi()
        {
            InitializeComponent();
        }

        private void load_ThongTinThi()
        {

            if (txtMaLop.Text.Trim() != "" && dateEditNgayThi.Text.Trim() != "" && panelControlThi.Enabled == true)
            {
                string strLenh = "EXEC dbo.SP_KiemTraDangKy '" + cmbTenMH.SelectedValue.ToString().Trim() + "', '" + txtMaLop.Text.Trim() + "', " + Int32.Parse(cmbLan.SelectedItem.ToString());

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                if (Program.myReader == null) return;
                int dem = 0;
                if (Program.myReader.HasRows)
                {
                    dem++;
                }
                if (dem == 0)
                {
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

                    if (maSV != null)
                    {
                        if (KTDaThi())
                        {
                            MessageBox.Show("Bạn đã thi lớp này rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            txtSoCauThi.Text = "";
                            txtThoiGian.Text = "";
                            txtTrinhDo.Text = "";
                            dateEditNgayThi.Focus();
                            Program.myReader.Close();
                            return;
                        }
                    }
                }

                Program.myReader.Close();
                Program.conn.Close();
            }
        }

        private Boolean KTDaThi()
        {
            Program.myReader.Close();
            string strLenh = "EXEC SP_KTBANGDIEM '" + maSV + "', '" + cmbTenMH.SelectedValue.ToString().Trim() + "', "+ Int32.Parse(cmbLan.SelectedItem.ToString());
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            Boolean kq = Program.myReader.GetBoolean(0);
            Program.myReader.Close();
            Program.conn.Close();
            if(kq == true)
            {
                return true;
            }
            return false;
        }

        private void frmThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.BANGDIEM' table. You can move, or remove it, as needed.
            //this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
            // TODO: This line of code loads data into the 'dS.CHITIET_BAITHI' table. You can move, or remove it, as needed.
            this.cHITIET_BAITHITableAdapter.Fill(this.dS.CHITIET_BAITHI);
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
            btnNopBai.Enabled = false;
            if (Program.mGroup == "Truong" || Program.mGroup == "Coso" || Program.mGroup == "Giangvien")
            {
                txtMaLop.Enabled = true;
                btnXemKetQua.Enabled = false;
            }
            else
            {
                string strLenh = "EXEC SP_ThongTinSV '" + Program.mlogin + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                txtMaLop.Text = Program.myReader.GetString(0);
                txtTenLop.Text = Program.myReader.GetString(1);
                txtHoTen.Text = Program.myReader.GetString(2) + Program.myReader.GetString(3);
                maSV = Program.myReader.GetString(4);
                panelControlTopLeft.Enabled = false;
                Program.myReader.Close();
                Program.conn.Close();
                btnXemKetQua.Enabled = true;
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
                if (flag == false)
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
                btnThoat.Enabled = false;
                btnBatDauThi.Enabled = false;
                btnXemKetQua.Enabled = false;
                btnNopBai.Enabled = true;
                phut = Int32.Parse(txtThoiGian.Text) - 1;
                timer1.Start();

                string strLenh = "SELECT TOP 10 * FROM dbo.BODE ORDER BY NEWID()";

                for (int i = 0; i < Int32.Parse(txtSoCauThi.Text); i++)
                {
                    dapAn.Add(" ");
                }

                LoadListViewTraLoi();

                DataTable dt = Program.ExecSqlDataTable(strLenh);
                bdsChiTietBaiThi.DataSource = dt;
                bindingNavigator1.BindingSource = bdsChiTietBaiThi;
                lbCau.Text = "Câu 1: ";
                richTextBoxCauHoi.DataBindings.Add("Text", bdsChiTietBaiThi, "NOIDUNG");
                labelA.DataBindings.Add("Text", bdsChiTietBaiThi, "A");
                labelB.DataBindings.Add("Text", bdsChiTietBaiThi, "B");
                labelC.DataBindings.Add("Text", bdsChiTietBaiThi, "C");
                labelD.DataBindings.Add("Text", bdsChiTietBaiThi, "D");
            }
        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            //((DataRowView)bdsChiTietBaiThi[i])["DAP_AN"].
            if (MessageBox.Show("Bạn có chắc chắn muốn Nộp bài thi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                timer1.Stop();
                panelControlThi.Enabled = false;
                btnBatDauThi.Enabled = false;
                btnThoat.Enabled = true;
                btnXemKetQua.Enabled = true;
                TinhDiem(); 
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát Form Thi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void LoadTraLoi()
        {
            for (int i = 0; i < Int32.Parse(txtSoCauThi.Text); i++)
            {
                listViewTraLoi.Items[i].SubItems[1].Text = dapAn[i];
            }
        }

        private void LoadListViewTraLoi()
        {
            for (int i = 0; i < Int32.Parse(txtSoCauThi.Text); i++)
            {
                ListViewItem.ListViewSubItem svnv = new ListViewItem.ListViewSubItem(listViewTraLoi.Items.Add((i + 1) + ""), "");
                listViewTraLoi.Items[i].SubItems.Add(svnv);
            }
        }

        private void DaChon()
        {
            if (dapAn[cau - 1].Equals("A"))
            {
                rbtnA.Checked = true;
            }
            else if (dapAn[cau - 1].Equals("B"))
            {
                rbtnB.Checked = true;
            }
            else if (dapAn[cau - 1].Equals("C"))
            {
                rbtnC.Checked = true;
            }
            else if (dapAn[cau - 1].Equals("D"))
            {
                rbtnD.Checked = true;
            }
            else if (dapAn[cau - 1].Equals(" "))
            {
                rbtnA.Checked = false;
                rbtnB.Checked = false;
                rbtnC.Checked = false;
                rbtnD.Checked = false;
            }
            LoadTraLoi();
        }

        private void ThemVaoChiTietBaiThi()
        {

        }

        private void ThemVaoBangDiem(float diem)
        {
            string strLenh = "INSERT INTO BANGDIEM (MASV, MAMH, LAN, NGAYTHI, DIEM) VALUES('" + maSV + "', '" + cmbTenMH.SelectedValue.ToString().Trim() + "', " + Int32.Parse(cmbLan.SelectedItem.ToString()) + ", " + dateEditNgayThi.Text.Trim() + ", " + diem + ")";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            Program.myReader.Close();
            Program.conn.Close();
        }

        private void TinhDiem()
        {
            int cauDung = 0;
            for (int i = 0; i < Int32.Parse(bdsChiTietBaiThi.Count.ToString()); i++)
            {
                if (dapAn[i] == ((DataRowView)bdsChiTietBaiThi[i])["DAP_AN"].ToString())
                {
                    cauDung = cauDung + 1;
                }
            }
            ThemVaoBangDiem(((float)cauDung / Int32.Parse(bdsChiTietBaiThi.Count.ToString())) * 10);
            MessageBox.Show("Điểm số của bạn là :" + ((float)cauDung / Int32.Parse(bdsChiTietBaiThi.Count.ToString())) * 10
                + "\nSố câu đúng: " + cauDung
                + "\nTổng số câu hỏi: " + Int32.Parse(bdsChiTietBaiThi.Count.ToString()),
                "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            XoaChon();
            cau = Int32.Parse(bindingNavigatorPositionItem.Text);
            lbCau.Text = "Câu " + (cau ) + ":";
            DaChon();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            XoaChon();
            cau = Int32.Parse(bindingNavigatorPositionItem.Text);
            lbCau.Text = "Câu " + cau + ":";
            DaChon();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            XoaChon();
            cau = Int32.Parse(bindingNavigatorPositionItem.Text);
            lbCau.Text = "Câu 1:";
            DaChon();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            XoaChon();
            cau = Int32.Parse(bindingNavigatorPositionItem.Text);
            lbCau.Text = "Câu " + cau + ":";
            DaChon();
        }

        private void bindingNavigatorPositionItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                XoaChon();
                cau = Int32.Parse(bindingNavigatorPositionItem.Text);
                lbCau.Text = "Câu " + cau + ":";
                DaChon();
            }
        }

        private void XoaChon()
        {
            rbtnA.Checked = false;
            rbtnB.Checked = false;
            rbtnC.Checked = false;
            rbtnD.Checked = false;
        }

        private void rbtnA_CheckedChanged(object sender, EventArgs e)
        {
            dapAn[cau - 1] = "A";
            LoadTraLoi();
        }

        private void rbtnB_CheckedChanged(object sender, EventArgs e)
        {
            dapAn[cau - 1] = "B";
            LoadTraLoi();
        }

        private void rbtnC_CheckedChanged(object sender, EventArgs e)
        {
            dapAn[cau - 1] = "C";
            LoadTraLoi();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            //if (!KTDaThi())
            //{
                frmXemKetQua f = new frmXemKetQua();
                f.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Bạn chưa thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //    return;
            //}
        }

        private void rbtnD_CheckedChanged(object sender, EventArgs e)
        {
            dapAn[cau - 1] = "D";
            LoadTraLoi();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (phut == 0 && giay == 0)
            {
                timer1.Stop();
                labelDongHo.Text = "00 : 00";
                panelControlThi.Enabled = false;
                btnThoat.Enabled = true;
                btnNopBai.Enabled = false;
                btnXemKetQua.Enabled = true;
                TinhDiem();
            }
            else if (phut > -1)
            {
                giay--;
                if (giay == -1 && phut > 0)
                {
                    giay = 59;
                    phut--;
                }

                if (phut < 10)
                {
                    if (giay < 10)
                    {
                        labelDongHo.Text = "0" + phut + " : " + "0" + giay;
                    }
                    else
                    {
                        labelDongHo.Text = "0" + phut + " : " + giay;
                    }
                }
                else
                {
                    if (giay < 10)
                    {
                        labelDongHo.Text = phut + " : " + "0" + giay;
                    }
                    else
                    {
                        labelDongHo.Text = phut + " : " + giay;
                    }
                }
            }
        }
    }
}
