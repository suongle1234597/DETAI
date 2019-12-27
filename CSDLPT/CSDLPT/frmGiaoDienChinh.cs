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
    public partial class frmGiaoDienChinh : Form
    {
        public frmGiaoDienChinh()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype) //kiem tra 1 form nao do da load vao bo nho chua
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f; //tra ve form do
            return null; // chua load
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate(); //chua mo roi. ta cho no active
            else //form chua mo
            {
                frmMonHoc f = new frmMonHoc(); //tao doi tuong formMonHoc trong bo nho
                f.MdiParent = this; //cho formGiaoDienTruong la form cha
                f.Show();
            }
        }

        private void frmGiaoDienNhomTruong_Load(object sender, EventArgs e)
        {
            tsstHoTen.Text = "Họ tên: " + Program.mHoten;
            tsstNhom.Text = "Nhóm: " + Program.mGroup;

            if (Program.mGroup == "Giangvien")
            {
                btnTaoTK.Enabled = false;
            }
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void siTen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //siTen.TextAlignment = 
        }

        private void barEditItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barEditItem2.EditValue = Program.mHoten;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGiaoVienDK));
            if (frm != null) frm.Activate();
            else
            {
                frmGiaoVienDK f = new frmGiaoVienDK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThiThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmThi));
            if (frm != null) frm.Activate();
            else
            {
                frmThi f = new frmThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.mlogin = "";
            Program.password = "";
            //Program.frmDN.Show();
            this.Close();
        }

        private void btnXemDSDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmXemDSDangKy));
            if (frm != null) frm.Activate();
            else
            {
                frmXemDSDangKy f = new frmXemDSDangKy();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnGiaoVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGiaoVien));
            if (frm != null) frm.Activate();
            else
            {
                frmGiaoVien f = new frmGiaoVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnXemKetQua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmXemKetQua));
            if (frm != null) frm.Activate();
            else
            {
                frmXemKetQua f = new frmXemKetQua();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmBoDe));
            if (frm != null) frm.Activate();
            else
            {
                frmBoDe f = new frmBoDe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnXemDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmXemBangDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmXemBangDiem f = new frmXemBangDiem();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
