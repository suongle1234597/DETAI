using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CSDLPT
{
    public partial class Xrpt_XemBangDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_XemBangDiem(string maMH, string maLop, string lan)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_XemBangDiemTableAdapter.Fill(ds1.SP_XemBangDiem, maMH, maLop, Int16.Parse(lan));
        }

    }
}
