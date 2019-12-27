namespace CSDLPT
{
    partial class frmGiaoVienDK
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label sOCAUTHILabel;
            System.Windows.Forms.Label tHOIGIANLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVienDK));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.dS = new CSDLPT.DS();
            this.bdsGiaoVienDK = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new CSDLPT.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new CSDLPT.DSTableAdapters.TableAdapterManager();
            this.gcGiaoVienDK = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.cmbTenMH = new System.Windows.Forms.ComboBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.cmbHoTen = new System.Windows.Forms.ComboBox();
            this.bdsDSGV = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaMH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.cmbTrinhDo = new System.Windows.Forms.ComboBox();
            this.dateEditNgayThi = new DevExpress.XtraEditors.DateEdit();
            this.cmbLan = new System.Windows.Forms.ComboBox();
            this.spinEditSoCauThi = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditThoiGian = new DevExpress.XtraEditors.SpinEdit();
            this.dSGVTableAdapter = new CSDLPT.DSTableAdapters.DSGVTableAdapter();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dSMHTableAdapter = new CSDLPT.DSTableAdapters.DSMHTableAdapter();
            this.bdsDSLop = new System.Windows.Forms.BindingSource(this.components);
            this.dSLOPTableAdapter = new CSDLPT.DSTableAdapters.DSLOPTableAdapter();
            mAGVLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVienDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiaoVienDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayThi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditSoCauThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditThoiGian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLop)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(503, 49);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(48, 17);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "MAGV:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(503, 77);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(50, 17);
            mAMHLabel.TabIndex = 2;
            mAMHLabel.Text = "MAMH:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(503, 105);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(56, 17);
            mALOPLabel.TabIndex = 4;
            mALOPLabel.Text = "MALOP:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(64, 141);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(72, 17);
            tRINHDOLabel.TabIndex = 6;
            tRINHDOLabel.Text = "TRINHDO:";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Location = new System.Drawing.Point(785, 49);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(68, 17);
            nGAYTHILabel.TabIndex = 8;
            nGAYTHILabel.Text = "NGAYTHI:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(785, 80);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(37, 17);
            lANLabel.TabIndex = 10;
            lANLabel.Text = "LAN:";
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.Location = new System.Drawing.Point(785, 108);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(78, 17);
            sOCAUTHILabel.TabIndex = 12;
            sOCAUTHILabel.Text = "SOCAUTHI:";
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Location = new System.Drawing.Point(785, 138);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(74, 17);
            tHOIGIANLabel.TabIndex = 14;
            tHOIGIANLabel.Text = "THOIGIAN:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(64, 47);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(55, 17);
            hOTENLabel.TabIndex = 16;
            hOTENLabel.Text = "TENGV:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(64, 77);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(57, 17);
            tENMHLabel.TabIndex = 18;
            tENMHLabel.Text = "TENMH:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(64, 109);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(63, 17);
            tENLOPLabel.TabIndex = 20;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3,
            this.bar4});
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
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar4;
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
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
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
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // barDockControl1
            // 
            this.barDockControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDockControl1.Appearance.Options.UseFont = true;
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(1350, 51);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 591);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(1350, 20);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 51);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(0, 540);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1350, 51);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Size = new System.Drawing.Size(0, 540);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGiaoVienDK
            // 
            this.bdsGiaoVienDK.DataMember = "GIAOVIEN_DANGKY";
            this.bdsGiaoVienDK.DataSource = this.dS;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CHITIET_BAITHITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcGiaoVienDK
            // 
            this.gcGiaoVienDK.DataSource = this.bdsGiaoVienDK;
            this.gcGiaoVienDK.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcGiaoVienDK.Location = new System.Drawing.Point(0, 51);
            this.gcGiaoVienDK.MainView = this.gridView1;
            this.gcGiaoVienDK.MenuManager = this.barManager1;
            this.gcGiaoVienDK.Name = "gcGiaoVienDK";
            this.gcGiaoVienDK.Size = new System.Drawing.Size(1350, 285);
            this.gcGiaoVienDK.TabIndex = 5;
            this.gcGiaoVienDK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colMAMH,
            this.colMALOP,
            this.colTRINHDO,
            this.colNGAYTHI,
            this.colLAN,
            this.colSOCAUTHI,
            this.colTHOIGIAN});
            this.gridView1.GridControl = this.gcGiaoVienDK;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 94;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            this.colMAMH.Width = 94;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 2;
            this.colMALOP.Width = 94;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 25;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 3;
            this.colTRINHDO.Width = 94;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.MinWidth = 25;
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 4;
            this.colNGAYTHI.Width = 94;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.MinWidth = 25;
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 5;
            this.colLAN.Width = 94;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.MinWidth = 25;
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 6;
            this.colSOCAUTHI.Width = 94;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.MinWidth = 25;
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 7;
            this.colTHOIGIAN.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(tENLOPLabel);
            this.panelControl1.Controls.Add(this.cmbTenLop);
            this.panelControl1.Controls.Add(tENMHLabel);
            this.panelControl1.Controls.Add(this.cmbTenMH);
            this.panelControl1.Controls.Add(hOTENLabel);
            this.panelControl1.Controls.Add(this.cmbHoTen);
            this.panelControl1.Controls.Add(mAGVLabel);
            this.panelControl1.Controls.Add(this.txtMaGV);
            this.panelControl1.Controls.Add(mAMHLabel);
            this.panelControl1.Controls.Add(this.txtMaMH);
            this.panelControl1.Controls.Add(mALOPLabel);
            this.panelControl1.Controls.Add(this.txtMaLop);
            this.panelControl1.Controls.Add(tRINHDOLabel);
            this.panelControl1.Controls.Add(this.cmbTrinhDo);
            this.panelControl1.Controls.Add(nGAYTHILabel);
            this.panelControl1.Controls.Add(this.dateEditNgayThi);
            this.panelControl1.Controls.Add(lANLabel);
            this.panelControl1.Controls.Add(this.cmbLan);
            this.panelControl1.Controls.Add(sOCAUTHILabel);
            this.panelControl1.Controls.Add(this.spinEditSoCauThi);
            this.panelControl1.Controls.Add(tHOIGIANLabel);
            this.panelControl1.Controls.Add(this.spinEditThoiGian);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 336);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1350, 255);
            this.panelControl1.TabIndex = 6;
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsGiaoVienDK, "MALOP", true));
            this.cmbTenLop.DataSource = this.bdsDSLop;
            this.cmbTenLop.DisplayMember = "TENLOP";
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(148, 106);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(310, 24);
            this.cmbTenLop.TabIndex = 21;
            this.cmbTenLop.ValueMember = "MALOP";
            this.cmbTenLop.SelectedIndexChanged += new System.EventHandler(this.cmbTenLop_SelectedIndexChanged);
            // 
            // cmbTenMH
            // 
            this.cmbTenMH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsGiaoVienDK, "MAMH", true));
            this.cmbTenMH.DataSource = this.bdsMH;
            this.cmbTenMH.DisplayMember = "TENMH";
            this.cmbTenMH.FormattingEnabled = true;
            this.cmbTenMH.Location = new System.Drawing.Point(148, 74);
            this.cmbTenMH.Name = "cmbTenMH";
            this.cmbTenMH.Size = new System.Drawing.Size(310, 24);
            this.cmbTenMH.TabIndex = 19;
            this.cmbTenMH.ValueMember = "MAMH";
            this.cmbTenMH.SelectedIndexChanged += new System.EventHandler(this.cmbTenMH_SelectedIndexChanged);
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "DSMH";
            this.bdsMH.DataSource = this.dS;
            // 
            // cmbHoTen
            // 
            this.cmbHoTen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsGiaoVienDK, "MAGV", true));
            this.cmbHoTen.DataSource = this.bdsDSGV;
            this.cmbHoTen.DisplayMember = "HOTEN";
            this.cmbHoTen.FormattingEnabled = true;
            this.cmbHoTen.Location = new System.Drawing.Point(148, 44);
            this.cmbHoTen.Name = "cmbHoTen";
            this.cmbHoTen.Size = new System.Drawing.Size(310, 24);
            this.cmbHoTen.TabIndex = 17;
            this.cmbHoTen.ValueMember = "MAGV";
            this.cmbHoTen.SelectedIndexChanged += new System.EventHandler(this.cmbHoTen_SelectedIndexChanged);
            // 
            // bdsDSGV
            // 
            this.bdsDSGV.DataMember = "DSGV";
            this.bdsDSGV.DataSource = this.dS;
            // 
            // txtMaGV
            // 
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVienDK, "MAGV", true));
            this.txtMaGV.Enabled = false;
            this.txtMaGV.Location = new System.Drawing.Point(587, 46);
            this.txtMaGV.MenuManager = this.barManager1;
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(111, 22);
            this.txtMaGV.TabIndex = 1;
            // 
            // txtMaMH
            // 
            this.txtMaMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVienDK, "MAMH", true));
            this.txtMaMH.Enabled = false;
            this.txtMaMH.Location = new System.Drawing.Point(587, 74);
            this.txtMaMH.MenuManager = this.barManager1;
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(111, 22);
            this.txtMaMH.TabIndex = 3;
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVienDK, "MALOP", true));
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Location = new System.Drawing.Point(587, 102);
            this.txtMaLop.MenuManager = this.barManager1;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(111, 22);
            this.txtMaLop.TabIndex = 5;
            // 
            // cmbTrinhDo
            // 
            this.cmbTrinhDo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGiaoVienDK, "TRINHDO", true));
            this.cmbTrinhDo.FormattingEnabled = true;
            this.cmbTrinhDo.Location = new System.Drawing.Point(148, 138);
            this.cmbTrinhDo.Name = "cmbTrinhDo";
            this.cmbTrinhDo.Size = new System.Drawing.Size(310, 24);
            this.cmbTrinhDo.TabIndex = 7;
            // 
            // dateEditNgayThi
            // 
            this.dateEditNgayThi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVienDK, "NGAYTHI", true));
            this.dateEditNgayThi.EditValue = null;
            this.dateEditNgayThi.Location = new System.Drawing.Point(869, 46);
            this.dateEditNgayThi.MenuManager = this.barManager1;
            this.dateEditNgayThi.Name = "dateEditNgayThi";
            this.dateEditNgayThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayThi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayThi.Size = new System.Drawing.Size(310, 22);
            this.dateEditNgayThi.TabIndex = 9;
            // 
            // cmbLan
            // 
            this.cmbLan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGiaoVienDK, "LAN", true));
            this.cmbLan.FormattingEnabled = true;
            this.cmbLan.Location = new System.Drawing.Point(869, 77);
            this.cmbLan.Name = "cmbLan";
            this.cmbLan.Size = new System.Drawing.Size(310, 24);
            this.cmbLan.TabIndex = 11;
            // 
            // spinEditSoCauThi
            // 
            this.spinEditSoCauThi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVienDK, "SOCAUTHI", true));
            this.spinEditSoCauThi.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinEditSoCauThi.Location = new System.Drawing.Point(869, 105);
            this.spinEditSoCauThi.MenuManager = this.barManager1;
            this.spinEditSoCauThi.Name = "spinEditSoCauThi";
            this.spinEditSoCauThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditSoCauThi.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEditSoCauThi.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinEditSoCauThi.Size = new System.Drawing.Size(310, 24);
            this.spinEditSoCauThi.TabIndex = 13;
            // 
            // spinEditThoiGian
            // 
            this.spinEditThoiGian.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVienDK, "THOIGIAN", true));
            this.spinEditThoiGian.EditValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.spinEditThoiGian.Location = new System.Drawing.Point(869, 135);
            this.spinEditThoiGian.MenuManager = this.barManager1;
            this.spinEditThoiGian.Name = "spinEditThoiGian";
            this.spinEditThoiGian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditThoiGian.Properties.MaxValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.spinEditThoiGian.Properties.MinValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.spinEditThoiGian.Size = new System.Drawing.Size(310, 24);
            this.spinEditThoiGian.TabIndex = 15;
            // 
            // dSGVTableAdapter
            // 
            this.dSGVTableAdapter.ClearBeforeFill = true;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(474, 27);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(333, 24);
            this.cmbCoSo.TabIndex = 43;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "CƠ SỞ:";
            // 
            // dSMHTableAdapter
            // 
            this.dSMHTableAdapter.ClearBeforeFill = true;
            // 
            // bdsDSLop
            // 
            this.bdsDSLop.DataMember = "DSLOP";
            this.bdsDSLop.DataSource = this.dS;
            // 
            // dSLOPTableAdapter
            // 
            this.dSLOPTableAdapter.ClearBeforeFill = true;
            // 
            // frmGiaoVienDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 611);
            this.Controls.Add(this.cmbCoSo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcGiaoVienDK);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmGiaoVienDK";
            this.Text = "Giáo Viên Đăng Ký";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiaoVienDK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVienDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiaoVienDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayThi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditSoCauThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditThoiGian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private System.Windows.Forms.BindingSource bdsGiaoVienDK;
        private DS dS;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcGiaoVienDK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
        private DevExpress.XtraEditors.TextEdit txtMaMH;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private System.Windows.Forms.ComboBox cmbTrinhDo;
        private DevExpress.XtraEditors.DateEdit dateEditNgayThi;
        private System.Windows.Forms.ComboBox cmbLan;
        private DevExpress.XtraEditors.SpinEdit spinEditSoCauThi;
        private DevExpress.XtraEditors.SpinEdit spinEditThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private System.Windows.Forms.ComboBox cmbHoTen;
        private System.Windows.Forms.BindingSource bdsDSGV;
        private DSTableAdapters.DSGVTableAdapter dSGVTableAdapter;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.DSMHTableAdapter dSMHTableAdapter;
        private System.Windows.Forms.ComboBox cmbTenMH;
        private System.Windows.Forms.BindingSource bdsMH;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private System.Windows.Forms.BindingSource bdsDSLop;
        private DSTableAdapters.DSLOPTableAdapter dSLOPTableAdapter;
    }
}