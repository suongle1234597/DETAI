using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace CSDLPT
{
    public partial class frmXemKetQua : Form
    {
        public frmXemKetQua()
        {
            InitializeComponent();
        }

        private void frmXemKetQua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.DSMH' table. You can move, or remove it, as needed.
            this.dSMHTableAdapter.Fill(this.dS.DSMH);
            // TODO: This line of code loads data into the 'dS.DSLOP' table. You can move, or remove it, as needed.
            this.dSLOPTableAdapter.Fill(this.dS.DSLOP);

            cmbTrinhDo.Items.Add("A");
            cmbTrinhDo.Items.Add("B");
            cmbTrinhDo.Items.Add("C");

            cmbTrinhDo.SelectedIndex = 0;

            txtHoTen.Text = Program.mHoten;
            txtHoTen.Enabled = false;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string strLenh = "EXEC SP_ThongTinXemKQ '" + cmbTenLop.SelectedValue.ToString() +"', '" + Program.mlogin +"', '" + cmbTenMH.SelectedValue.ToString() + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            //Program.myReader.Read();
            Xrpt_XemKetQua xrpt = new Xrpt_XemKetQua();
            ReportPrintTool print = new ReportPrintTool(xrpt);
            print.ShowPreviewDialog();


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát Form Xem kết quả không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
