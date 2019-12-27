namespace CSDLPT
{
    partial class frmBoDe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nOIDUNGLabel;
            System.Windows.Forms.Label aLabel;
            System.Windows.Forms.Label bLabel;
            System.Windows.Forms.Label cLabel;
            System.Windows.Forms.Label dLabel;
            System.Windows.Forms.Label dAP_ANLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoDe));
            System.Windows.Forms.Label cAUHOILabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.dS = new CSDLPT.DS();
            this.bdsBoDe = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new CSDLPT.DSTableAdapters.BODETableAdapter();
            this.tableAdapterManager = new CSDLPT.DSTableAdapters.TableAdapterManager();
            this.cHITIET_BAITHITableAdapter = new CSDLPT.DSTableAdapters.CHITIET_BAITHITableAdapter();
            this.gcBoDe = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbTenGV = new System.Windows.Forms.ComboBox();
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTenMH = new System.Windows.Forms.ComboBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.cmbDapAn = new System.Windows.Forms.ComboBox();
            this.cmbTrinhDo = new System.Windows.Forms.ComboBox();
            this.txtA = new DevExpress.XtraEditors.TextEdit();
            this.txtMaMH = new DevExpress.XtraEditors.TextEdit();
            this.txtB = new DevExpress.XtraEditors.TextEdit();
            this.txtC = new DevExpress.XtraEditors.TextEdit();
            this.txtD = new DevExpress.XtraEditors.TextEdit();
            this.txtNoiDung = new DevExpress.XtraEditors.TextEdit();
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bdsChiTietBaiThi = new System.Windows.Forms.BindingSource(this.components);
            this.dSGVTableAdapter = new CSDLPT.DSTableAdapters.DSGVTableAdapter();
            this.dSMHTableAdapter = new CSDLPT.DSTableAdapters.DSMHTableAdapter();
            this.txtCauHoi = new DevExpress.XtraEditors.TextEdit();
            mAMHLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nOIDUNGLabel = new System.Windows.Forms.Label();
            aLabel = new System.Windows.Forms.Label();
            bLabel = new System.Windows.Forms.Label();
            cLabel = new System.Windows.Forms.Label();
            dLabel = new System.Windows.Forms.Label();
            dAP_ANLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            cAUHOILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBoDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietBaiThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCauHoi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(64, 107);
            mAMHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(50, 17);
            mAMHLabel.TabIndex = 2;
            mAMHLabel.Text = "MAMH:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(895, 138);
            tRINHDOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(72, 17);
            tRINHDOLabel.TabIndex = 4;
            tRINHDOLabel.Text = "TRINHDO:";
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.Location = new System.Drawing.Point(64, 138);
            nOIDUNGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(73, 17);
            nOIDUNGLabel.TabIndex = 6;
            nOIDUNGLabel.Text = "NOIDUNG:";
            // 
            // aLabel
            // 
            aLabel.AutoSize = true;
            aLabel.Location = new System.Drawing.Point(479, 33);
            aLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            aLabel.Name = "aLabel";
            aLabel.Size = new System.Drawing.Size(21, 17);
            aLabel.TabIndex = 8;
            aLabel.Text = "A:";
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Location = new System.Drawing.Point(479, 69);
            bLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bLabel.Name = "bLabel";
            bLabel.Size = new System.Drawing.Size(21, 17);
            bLabel.TabIndex = 10;
            bLabel.Text = "B:";
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.Location = new System.Drawing.Point(479, 101);
            cLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cLabel.Name = "cLabel";
            cLabel.Size = new System.Drawing.Size(22, 17);
            cLabel.TabIndex = 12;
            cLabel.Text = "C:";
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.Location = new System.Drawing.Point(479, 137);
            dLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dLabel.Name = "dLabel";
            dLabel.Size = new System.Drawing.Size(23, 17);
            dLabel.TabIndex = 14;
            dLabel.Text = "D:";
            // 
            // dAP_ANLabel
            // 
            dAP_ANLabel.AutoSize = true;
            dAP_ANLabel.Location = new System.Drawing.Point(895, 33);
            dAP_ANLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dAP_ANLabel.Name = "dAP_ANLabel";
            dAP_ANLabel.Size = new System.Drawing.Size(60, 17);
            dAP_ANLabel.TabIndex = 16;
            dAP_ANLabel.Text = "DAP AN:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(895, 103);
            mAGVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(48, 17);
            mAGVLabel.TabIndex = 18;
            mAGVLabel.Text = "MAGV:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(64, 68);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(57, 17);
            tENMHLabel.TabIndex = 22;
            tENMHLabel.Text = "TENMH:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(895, 70);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(55, 17);
            hOTENLabel.TabIndex = 23;
            hOTENLabel.Text = "TENGV:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar5});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnRefresh,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Offset = 1;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 5;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar5
            // 
            this.bar5.BarName = "Status bar";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Status bar";
            // 
            // barDockControl1
            // 
            this.barDockControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDockControl1.Appearance.Options.UseFont = true;
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl1.Size = new System.Drawing.Size(1303, 51);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 655);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl2.Size = new System.Drawing.Size(1303, 20);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 51);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl3.Size = new System.Drawing.Size(0, 604);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1303, 51);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl4.Size = new System.Drawing.Size(0, 604);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsBoDe
            // 
            this.bdsBoDe.DataMember = "BODE";
            this.bdsBoDe.DataSource = this.dS;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.bODETableAdapter;
            this.tableAdapterManager.CHITIET_BAITHITableAdapter = this.cHITIET_BAITHITableAdapter;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cHITIET_BAITHITableAdapter
            // 
            this.cHITIET_BAITHITableAdapter.ClearBeforeFill = true;
            // 
            // gcBoDe
            // 
            this.gcBoDe.DataSource = this.bdsBoDe;
            this.gcBoDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBoDe.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcBoDe.Location = new System.Drawing.Point(0, 51);
            this.gcBoDe.MainView = this.gridView1;
            this.gcBoDe.Margin = new System.Windows.Forms.Padding(4);
            this.gcBoDe.MenuManager = this.barManager1;
            this.gcBoDe.Name = "gcBoDe";
            this.gcBoDe.Size = new System.Drawing.Size(1303, 402);
            this.gcBoDe.TabIndex = 5;
            this.gcBoDe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCAUHOI,
            this.colMAMH,
            this.colTRINHDO,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAP_AN,
            this.colMAGV});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gcBoDe;
            this.gridView1.Name = "gridView1";
            // 
            // colCAUHOI
            // 
            this.colCAUHOI.FieldName = "CAUHOI";
            this.colCAUHOI.MinWidth = 31;
            this.colCAUHOI.Name = "colCAUHOI";
            this.colCAUHOI.Visible = true;
            this.colCAUHOI.VisibleIndex = 0;
            this.colCAUHOI.Width = 117;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 31;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            this.colMAMH.Width = 117;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 31;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 2;
            this.colTRINHDO.Width = 117;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.MinWidth = 31;
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 3;
            this.colNOIDUNG.Width = 117;
            // 
            // colA
            // 
            this.colA.FieldName = "A";
            this.colA.MinWidth = 31;
            this.colA.Name = "colA";
            this.colA.Visible = true;
            this.colA.VisibleIndex = 4;
            this.colA.Width = 117;
            // 
            // colB
            // 
            this.colB.FieldName = "B";
            this.colB.MinWidth = 31;
            this.colB.Name = "colB";
            this.colB.Visible = true;
            this.colB.VisibleIndex = 5;
            this.colB.Width = 117;
            // 
            // colC
            // 
            this.colC.FieldName = "C";
            this.colC.MinWidth = 31;
            this.colC.Name = "colC";
            this.colC.Visible = true;
            this.colC.VisibleIndex = 6;
            this.colC.Width = 117;
            // 
            // colD
            // 
            this.colD.FieldName = "D";
            this.colD.MinWidth = 31;
            this.colD.Name = "colD";
            this.colD.Visible = true;
            this.colD.VisibleIndex = 7;
            this.colD.Width = 117;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.MinWidth = 31;
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 8;
            this.colDAP_AN.Width = 117;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 31;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 9;
            this.colMAGV.Width = 117;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(cAUHOILabel);
            this.panelControl1.Controls.Add(this.txtCauHoi);
            this.panelControl1.Controls.Add(hOTENLabel);
            this.panelControl1.Controls.Add(this.cmbTenGV);
            this.panelControl1.Controls.Add(tENMHLabel);
            this.panelControl1.Controls.Add(this.cmbTenMH);
            this.panelControl1.Controls.Add(this.cmbDapAn);
            this.panelControl1.Controls.Add(this.cmbTrinhDo);
            this.panelControl1.Controls.Add(mAMHLabel);
            this.panelControl1.Controls.Add(aLabel);
            this.panelControl1.Controls.Add(this.txtA);
            this.panelControl1.Controls.Add(this.txtMaMH);
            this.panelControl1.Controls.Add(bLabel);
            this.panelControl1.Controls.Add(tRINHDOLabel);
            this.panelControl1.Controls.Add(this.txtB);
            this.panelControl1.Controls.Add(cLabel);
            this.panelControl1.Controls.Add(this.txtC);
            this.panelControl1.Controls.Add(dLabel);
            this.panelControl1.Controls.Add(nOIDUNGLabel);
            this.panelControl1.Controls.Add(this.txtD);
            this.panelControl1.Controls.Add(this.txtNoiDung);
            this.panelControl1.Controls.Add(dAP_ANLabel);
            this.panelControl1.Controls.Add(mAGVLabel);
            this.panelControl1.Controls.Add(this.txtMaGV);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 453);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1303, 202);
            this.panelControl1.TabIndex = 6;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // cmbTenGV
            // 
            this.cmbTenGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "HOTEN", true));
            this.cmbTenGV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsBoDe, "MAGV", true));
            this.cmbTenGV.DataSource = this.bdsGV;
            this.cmbTenGV.DisplayMember = "HOTEN";
            this.cmbTenGV.FormattingEnabled = true;
            this.cmbTenGV.Location = new System.Drawing.Point(994, 65);
            this.cmbTenGV.Name = "cmbTenGV";
            this.cmbTenGV.Size = new System.Drawing.Size(243, 24);
            this.cmbTenGV.TabIndex = 24;
            this.cmbTenGV.ValueMember = "MAGV";
            this.cmbTenGV.SelectedIndexChanged += new System.EventHandler(this.cmbTenGV_SelectedIndexChanged);
            // 
            // bdsGV
            // 
            this.bdsGV.DataMember = "DSGV";
            this.bdsGV.DataSource = this.dS;
            // 
            // cmbTenMH
            // 
            this.cmbTenMH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsBoDe, "MAMH", true));
            this.cmbTenMH.DataSource = this.bdsMH;
            this.cmbTenMH.DisplayMember = "TENMH";
            this.cmbTenMH.FormattingEnabled = true;
            this.cmbTenMH.Location = new System.Drawing.Point(163, 65);
            this.cmbTenMH.Name = "cmbTenMH";
            this.cmbTenMH.Size = new System.Drawing.Size(243, 24);
            this.cmbTenMH.TabIndex = 23;
            this.cmbTenMH.ValueMember = "MAMH";
            this.cmbTenMH.SelectedIndexChanged += new System.EventHandler(this.cmbTenMH_SelectedIndexChanged);
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "DSMH";
            this.bdsMH.DataSource = this.dS;
            // 
            // cmbDapAn
            // 
            this.cmbDapAn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBoDe, "DAP_AN", true));
            this.cmbDapAn.FormattingEnabled = true;
            this.cmbDapAn.Location = new System.Drawing.Point(994, 26);
            this.cmbDapAn.Name = "cmbDapAn";
            this.cmbDapAn.Size = new System.Drawing.Size(243, 24);
            this.cmbDapAn.TabIndex = 22;
            // 
            // cmbTrinhDo
            // 
            this.cmbTrinhDo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBoDe, "TRINHDO", true));
            this.cmbTrinhDo.FormattingEnabled = true;
            this.cmbTrinhDo.Location = new System.Drawing.Point(994, 135);
            this.cmbTrinhDo.Name = "cmbTrinhDo";
            this.cmbTrinhDo.Size = new System.Drawing.Size(243, 24);
            this.cmbTrinhDo.TabIndex = 21;
            // 
            // txtA
            // 
            this.txtA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "A", true));
            this.txtA.Location = new System.Drawing.Point(578, 30);
            this.txtA.Margin = new System.Windows.Forms.Padding(4);
            this.txtA.MenuManager = this.barManager1;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(243, 22);
            this.txtA.TabIndex = 9;
            // 
            // txtMaMH
            // 
            this.txtMaMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "MAMH", true));
            this.txtMaMH.Enabled = false;
            this.txtMaMH.Location = new System.Drawing.Point(163, 103);
            this.txtMaMH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaMH.MenuManager = this.barManager1;
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(243, 22);
            this.txtMaMH.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "B", true));
            this.txtB.Location = new System.Drawing.Point(578, 65);
            this.txtB.Margin = new System.Windows.Forms.Padding(4);
            this.txtB.MenuManager = this.barManager1;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(243, 22);
            this.txtB.TabIndex = 11;
            // 
            // txtC
            // 
            this.txtC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "C", true));
            this.txtC.Location = new System.Drawing.Point(578, 98);
            this.txtC.Margin = new System.Windows.Forms.Padding(4);
            this.txtC.MenuManager = this.barManager1;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(243, 22);
            this.txtC.TabIndex = 13;
            // 
            // txtD
            // 
            this.txtD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "D", true));
            this.txtD.Location = new System.Drawing.Point(578, 133);
            this.txtD.Margin = new System.Windows.Forms.Padding(4);
            this.txtD.MenuManager = this.barManager1;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(243, 22);
            this.txtD.TabIndex = 15;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "NOIDUNG", true));
            this.txtNoiDung.Location = new System.Drawing.Point(163, 134);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoiDung.MenuManager = this.barManager1;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(243, 22);
            this.txtNoiDung.TabIndex = 7;
            // 
            // txtMaGV
            // 
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "MAGV", true));
            this.txtMaGV.Enabled = false;
            this.txtMaGV.Location = new System.Drawing.Point(994, 99);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaGV.MenuManager = this.barManager1;
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(243, 22);
            this.txtMaGV.TabIndex = 19;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(569, 34);
            this.cmbCoSo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(415, 28);
            this.cmbCoSo.TabIndex = 41;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "CƠ SỞ:";
            // 
            // bdsChiTietBaiThi
            // 
            this.bdsChiTietBaiThi.DataMember = "FK_CHITIET_BAITHI_BODE";
            this.bdsChiTietBaiThi.DataSource = this.bdsBoDe;
            // 
            // dSGVTableAdapter
            // 
            this.dSGVTableAdapter.ClearBeforeFill = true;
            // 
            // dSMHTableAdapter
            // 
            this.dSMHTableAdapter.ClearBeforeFill = true;
            // 
            // cAUHOILabel
            // 
            cAUHOILabel.AutoSize = true;
            cAUHOILabel.Location = new System.Drawing.Point(64, 35);
            cAUHOILabel.Name = "cAUHOILabel";
            cAUHOILabel.Size = new System.Drawing.Size(62, 17);
            cAUHOILabel.TabIndex = 24;
            cAUHOILabel.Text = "CAUHOI:";
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "CAUHOI", true));
            this.txtCauHoi.Location = new System.Drawing.Point(163, 30);
            this.txtCauHoi.MenuManager = this.barManager1;
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(243, 22);
            this.txtCauHoi.TabIndex = 25;
            // 
            // frmBoDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1303, 675);
            this.Controls.Add(this.cmbCoSo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcBoDe);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBoDe";
            this.Text = "Bộ đề";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBoDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietBaiThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCauHoi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private System.Windows.Forms.BindingSource bdsBoDe;
        private DS dS;
        private DSTableAdapters.BODETableAdapter bODETableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcBoDe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaMH;
        private DevExpress.XtraEditors.TextEdit txtNoiDung;
        private DevExpress.XtraEditors.TextEdit txtA;
        private DevExpress.XtraEditors.TextEdit txtB;
        private DevExpress.XtraEditors.TextEdit txtC;
        private DevExpress.XtraEditors.TextEdit txtD;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.CHITIET_BAITHITableAdapter cHITIET_BAITHITableAdapter;
        private System.Windows.Forms.BindingSource bdsChiTietBaiThi;
        private System.Windows.Forms.ComboBox cmbDapAn;
        private System.Windows.Forms.ComboBox cmbTrinhDo;
        private System.Windows.Forms.ComboBox cmbTenMH;
        private System.Windows.Forms.BindingSource bdsGV;
        private DSTableAdapters.DSGVTableAdapter dSGVTableAdapter;
        private System.Windows.Forms.ComboBox cmbTenGV;
        private System.Windows.Forms.BindingSource bdsMH;
        private DSTableAdapters.DSMHTableAdapter dSMHTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtCauHoi;
    }
}