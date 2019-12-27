using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CSDLPT
{
    public partial class Xrpt_XemDSDangKy : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_XemDSDangKy(string tuNgay, string denNgay)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_XemDSDangKyTableAdapter.Fill(ds1.SP_XemDSDangKy, DateTime.Parse(tuNgay), DateTime.Parse(denNgay));
        }

    }
}
