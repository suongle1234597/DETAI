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
    public partial class frmGiaoDienNhomTruong : Form
    {
        public frmGiaoDienNhomTruong()
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

        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
