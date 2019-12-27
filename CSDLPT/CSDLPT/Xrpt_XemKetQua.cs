using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CSDLPT
{
    public partial class Xrpt_XemKetQua : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_XemKetQua(int maBD)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_XemKetQuaTableAdapter.Fill(ds1.SP_XemKetQua, maBD);
        }

    }
}
