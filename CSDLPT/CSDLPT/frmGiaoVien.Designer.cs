namespace CSDLPT
{
    partial class frmGiaoVien
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
            System.Windows.Forms.Label mAKHLabel2;
            System.Windows.Forms.Label tENKHLabel1;
            System.Windows.Forms.Label mACSLabel;
            System.Windows.Forms.Label mAGVLabel1;
            System.Windows.Forms.Label hOLabel1;
            System.Windows.Forms.Label tENLabel1;
            System.Windows.Forms.Label dIACHILabel1;
            System.Windows.Forms.Label hOCVILabel1;
            System.Windows.Forms.Label mAKHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVien));
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
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new CSDLPT.DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new CSDLPT.DSTableAdapters.TableAdapterManager();
            this.gIAOVIENTableAdapter = new CSDLPT.DSTableAdapters.GIAOVIENTableAdapter();
            this.gcKhoa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControlGiaoVien = new DevExpress.XtraEditors.PanelControl();
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.bdsGiaoVien = new System.Windows.Forms.BindingSource(this.components);
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtHocVi = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKH2 = new DevExpress.XtraEditors.TextEdit();
            this.panelControlKhoa = new DevExpress.XtraEditors.PanelControl();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaCS = new DevExpress.XtraEditors.TextEdit();
            this.gIAOVIENDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhucHoiGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefreshGV = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bdsBoDe = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new CSDLPT.DSTableAdapters.BODETableAdapter();
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new CSDLPT.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            mAKHLabel2 = new System.Windows.Forms.Label();
            tENKHLabel1 = new System.Windows.Forms.Label();
            mACSLabel = new System.Windows.Forms.Label();
            mAGVLabel1 = new System.Windows.Forms.Label();
            hOLabel1 = new System.Windows.Forms.Label();
            tENLabel1 = new System.Windows.Forms.Label();
            dIACHILabel1 = new System.Windows.Forms.Label();
            hOCVILabel1 = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGiaoVien)).BeginInit();
            this.panelControlGiaoVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlKhoa)).BeginInit();
            this.panelControlKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel2
            // 
            mAKHLabel2.AutoSize = true;
            mAKHLabel2.Location = new System.Drawing.Point(42, 103);
            mAKHLabel2.Name = "mAKHLabel2";
            mAKHLabel2.Size = new System.Drawing.Size(48, 17);
            mAKHLabel2.TabIndex = 4;
            mAKHLabel2.Text = "MAKH:";
            // 
            // tENKHLabel1
            // 
            tENKHLabel1.AutoSize = true;
            tENKHLabel1.Location = new System.Drawing.Point(42, 135);
            tENKHLabel1.Name = "tENKHLabel1";
            tENKHLabel1.Size = new System.Drawing.Size(55, 17);
            tENKHLabel1.TabIndex = 6;
            tENKHLabel1.Text = "TENKH:";
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(42, 168);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(48, 17);
            mACSLabel.TabIndex = 8;
            mACSLabel.Text = "MACS:";
            // 
            // mAGVLabel1
            // 
            mAGVLabel1.AutoSize = true;
            mAGVLabel1.Location = new System.Drawing.Point(112, 44);
            mAGVLabel1.Name = "mAGVLabel1";
            mAGVLabel1.Size = new System.Drawing.Size(48, 17);
            mAGVLabel1.TabIndex = 13;
            mAGVLabel1.Text = "MAGV:";
            // 
            // hOLabel1
            // 
            hOLabel1.AutoSize = true;
            hOLabel1.Location = new System.Drawing.Point(112, 76);
            hOLabel1.Name = "hOLabel1";
            hOLabel1.Size = new System.Drawing.Size(32, 17);
            hOLabel1.TabIndex = 15;
            hOLabel1.Text = "HO:";
            // 
            // tENLabel1
            // 
            tENLabel1.AutoSize = true;
            tENLabel1.Location = new System.Drawing.Point(112, 108);
            tENLabel1.Name = "tENLabel1";
            tENLabel1.Size = new System.Drawing.Size(38, 17);
            tENLabel1.TabIndex = 17;
            tENLabel1.Text = "TEN:";
            // 
            // dIACHILabel1
            // 
            dIACHILabel1.AutoSize = true;
            dIACHILabel1.Location = new System.Drawing.Point(112, 140);
            dIACHILabel1.Name = "dIACHILabel1";
            dIACHILabel1.Size = new System.Drawing.Size(57, 17);
            dIACHILabel1.TabIndex = 19;
            dIACHILabel1.Text = "DIACHI:";
            // 
            // hOCVILabel1
            // 
            hOCVILabel1.AutoSize = true;
            hOCVILabel1.Location = new System.Drawing.Point(112, 172);
            hOCVILabel1.Name = "hOCVILabel1";
            hOCVILabel1.Size = new System.Drawing.Size(53, 17);
            hOCVILabel1.TabIndex = 21;
            hOCVILabel1.Text = "HOCVI:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(112, 204);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(48, 17);
            mAKHLabel.TabIndex = 23;
            mAKHLabel.Text = "MAKH:";
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
            this.barDockControl1.Size = new System.Drawing.Size(1674, 51);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 1035);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(1674, 20);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 51);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(0, 984);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1674, 51);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Size = new System.Drawing.Size(0, 984);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKhoa
            // 
            this.bdsKhoa.DataMember = "KHOA";
            this.bdsKhoa.DataSource = this.dS;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CHITIET_BAITHITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.gIAOVIENTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // gcKhoa
            // 
            this.gcKhoa.DataSource = this.bdsKhoa;
            this.gcKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKhoa.Location = new System.Drawing.Point(0, 51);
            this.gcKhoa.MainView = this.gridView1;
            this.gcKhoa.MenuManager = this.barManager1;
            this.gcKhoa.Name = "gcKhoa";
            this.gcKhoa.Size = new System.Drawing.Size(1674, 984);
            this.gcKhoa.TabIndex = 5;
            this.gcKhoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.gridView1.GridControl = this.gcKhoa;
            this.gridView1.Name = "gridView1";
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            this.colMAKH.Width = 94;
            // 
            // colTENKH
            // 
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.MinWidth = 25;
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            this.colTENKH.Width = 94;
            // 
            // colMACS
            // 
            this.colMACS.FieldName = "MACS";
            this.colMACS.MinWidth = 25;
            this.colMACS.Name = "colMACS";
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            this.colMACS.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControlGiaoVien);
            this.panelControl1.Controls.Add(this.panelControlKhoa);
            this.panelControl1.Controls.Add(this.gIAOVIENDataGridView);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 676);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1674, 359);
            this.panelControl1.TabIndex = 6;
            // 
            // panelControlGiaoVien
            // 
            this.panelControlGiaoVien.Controls.Add(mAGVLabel1);
            this.panelControlGiaoVien.Controls.Add(this.txtMaGV);
            this.panelControlGiaoVien.Controls.Add(hOLabel1);
            this.panelControlGiaoVien.Controls.Add(this.txtHo);
            this.panelControlGiaoVien.Controls.Add(tENLabel1);
            this.panelControlGiaoVien.Controls.Add(this.txtTen);
            this.panelControlGiaoVien.Controls.Add(dIACHILabel1);
            this.panelControlGiaoVien.Controls.Add(this.txtDiaChi);
            this.panelControlGiaoVien.Controls.Add(hOCVILabel1);
            this.panelControlGiaoVien.Controls.Add(this.txtHocVi);
            this.panelControlGiaoVien.Controls.Add(mAKHLabel);
            this.panelControlGiaoVien.Controls.Add(this.txtMaKH2);
            this.panelControlGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlGiaoVien.Location = new System.Drawing.Point(430, 2);
            this.panelControlGiaoVien.Name = "panelControlGiaoVien";
            this.panelControlGiaoVien.Size = new System.Drawing.Size(638, 355);
            this.panelControlGiaoVien.TabIndex = 2;
            // 
            // txtMaGV
            // 
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVien, "MAGV", true));
            this.txtMaGV.Location = new System.Drawing.Point(175, 41);
            this.txtMaGV.MenuManager = this.barManager1;
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(284, 22);
            this.txtMaGV.TabIndex = 14;
            // 
            // bdsGiaoVien
            // 
            this.bdsGiaoVien.DataMember = "FK_GIAOVIEN_KHOA";
            this.bdsGiaoVien.DataSource = this.bdsKhoa;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVien, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(175, 73);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(284, 22);
            this.txtHo.TabIndex = 16;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVien, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(175, 105);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(284, 22);
            this.txtTen.TabIndex = 18;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVien, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(175, 137);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(284, 22);
            this.txtDiaChi.TabIndex = 20;
            // 
            // txtHocVi
            // 
            this.txtHocVi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVien, "HOCVI", true));
            this.txtHocVi.Location = new System.Drawing.Point(175, 169);
            this.txtHocVi.MenuManager = this.barManager1;
            this.txtHocVi.Name = "txtHocVi";
            this.txtHocVi.Size = new System.Drawing.Size(284, 22);
            this.txtHocVi.TabIndex = 22;
            // 
            // txtMaKH2
            // 
            this.txtMaKH2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVien, "MAKH", true));
            this.txtMaKH2.Location = new System.Drawing.Point(175, 201);
            this.txtMaKH2.MenuManager = this.barManager1;
            this.txtMaKH2.Name = "txtMaKH2";
            this.txtMaKH2.Size = new System.Drawing.Size(284, 22);
            this.txtMaKH2.TabIndex = 24;
            // 
            // panelControlKhoa
            // 
            this.panelControlKhoa.Controls.Add(this.txtTenKH);
            this.panelControlKhoa.Controls.Add(mAKHLabel2);
            this.panelControlKhoa.Controls.Add(this.txtMaKH);
            this.panelControlKhoa.Controls.Add(tENKHLabel1);
            this.panelControlKhoa.Controls.Add(mACSLabel);
            this.panelControlKhoa.Controls.Add(this.txtMaCS);
            this.panelControlKhoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControlKhoa.Location = new System.Drawing.Point(2, 2);
            this.panelControlKhoa.Name = "panelControlKhoa";
            this.panelControlKhoa.Size = new System.Drawing.Size(428, 355);
            this.panelControlKhoa.TabIndex = 0;
            // 
            // txtTenKH
            // 
            this.txtTenKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "TENKH", true));
            this.txtTenKH.Location = new System.Drawing.Point(110, 132);
            this.txtTenKH.MenuManager = this.barManager1;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(262, 22);
            this.txtTenKH.TabIndex = 10;
            // 
            // txtMaKH
            // 
            this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MAKH", true));
            this.txtMaKH.Location = new System.Drawing.Point(110, 100);
            this.txtMaKH.MenuManager = this.barManager1;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(262, 22);
            this.txtMaKH.TabIndex = 5;
            // 
            // txtMaCS
            // 
            this.txtMaCS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MACS", true));
            this.txtMaCS.Location = new System.Drawing.Point(110, 165);
            this.txtMaCS.MenuManager = this.barManager1;
            this.txtMaCS.Name = "txtMaCS";
            this.txtMaCS.Size = new System.Drawing.Size(262, 22);
            this.txtMaCS.TabIndex = 9;
            // 
            // gIAOVIENDataGridView
            // 
            this.gIAOVIENDataGridView.AutoGenerateColumns = false;
            this.gIAOVIENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gIAOVIENDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.gIAOVIENDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.gIAOVIENDataGridView.DataSource = this.bdsGiaoVien;
            this.gIAOVIENDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.gIAOVIENDataGridView.Location = new System.Drawing.Point(1068, 2);
            this.gIAOVIENDataGridView.Name = "gIAOVIENDataGridView";
            this.gIAOVIENDataGridView.RowTemplate.Height = 24;
            this.gIAOVIENDataGridView.Size = new System.Drawing.Size(604, 355);
            this.gIAOVIENDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAGV";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAGV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HO";
            this.dataGridViewTextBoxColumn2.HeaderText = "HO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TEN";
            this.dataGridViewTextBoxColumn3.HeaderText = "TEN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn4.HeaderText = "DIACHI";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HOCVI";
            this.dataGridViewTextBoxColumn5.HeaderText = "HOCVI";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MAKH";
            this.dataGridViewTextBoxColumn6.HeaderText = "MAKH";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemGV,
            this.btnSuaGV,
            this.btnGhiGV,
            this.btnXoaGV,
            this.btnPhucHoiGV,
            this.btnRefreshGV});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 148);
            // 
            // btnThemGV
            // 
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(134, 24);
            this.btnThemGV.Text = "Thêm";
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.Name = "btnSuaGV";
            this.btnSuaGV.Size = new System.Drawing.Size(134, 24);
            this.btnSuaGV.Text = "Sửa";
            this.btnSuaGV.Click += new System.EventHandler(this.btnSuaGV_Click);
            // 
            // btnGhiGV
            // 
            this.btnGhiGV.Name = "btnGhiGV";
            this.btnGhiGV.Size = new System.Drawing.Size(134, 24);
            this.btnGhiGV.Text = "Ghi";
            this.btnGhiGV.Click += new System.EventHandler(this.btnGhiGV_Click);
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(134, 24);
            this.btnXoaGV.Text = "Xóa";
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // btnPhucHoiGV
            // 
            this.btnPhucHoiGV.Name = "btnPhucHoiGV";
            this.btnPhucHoiGV.Size = new System.Drawing.Size(134, 24);
            this.btnPhucHoiGV.Text = "Phục hồi";
            this.btnPhucHoiGV.Click += new System.EventHandler(this.btnPhucHoiGV_Click);
            // 
            // btnRefreshGV
            // 
            this.btnRefreshGV.Name = "btnRefreshGV";
            this.btnRefreshGV.Size = new System.Drawing.Size(134, 24);
            this.btnRefreshGV.Text = "Refresh";
            this.btnRefreshGV.Click += new System.EventHandler(this.btnRefreshGV_Click);
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DisplayMember = "TENCS";
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(497, 27);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(333, 24);
            this.cmbCoSo.TabIndex = 43;
            this.cmbCoSo.ValueMember = "TENSERVER";
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "CƠ SỞ:";
            // 
            // bdsBoDe
            // 
            this.bdsBoDe.DataMember = "FK_BODE_GIAOVIEN";
            this.bdsBoDe.DataSource = this.bdsGiaoVien;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // bdsGVDK
            // 
            this.bdsGVDK.DataMember = "FK_GIAOVIEN_DANGKY_GIAOVIEN";
            this.bdsGVDK.DataSource = this.bdsGiaoVien;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1674, 1055);
            this.Controls.Add(this.cmbCoSo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcKhoa);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmGiaoVien";
            this.Text = "Giáo viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGiaoVien)).EndInit();
            this.panelControlGiaoVien.ResumeLayout(false);
            this.panelControlGiaoVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlKhoa)).EndInit();
            this.panelControlKhoa.ResumeLayout(false);
            this.panelControlKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsKhoa;
        private DS dS;
        private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControlKhoa;
        private DSTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControlGiaoVien;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtTenKH;
        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private DevExpress.XtraEditors.TextEdit txtMaCS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemGV;
        private System.Windows.Forms.ToolStripMenuItem btnSuaGV;
        private System.Windows.Forms.ToolStripMenuItem btnGhiGV;
        private System.Windows.Forms.ToolStripMenuItem btnXoaGV;
        private System.Windows.Forms.ToolStripMenuItem btnPhucHoiGV;
        private System.Windows.Forms.ToolStripMenuItem btnRefreshGV;
        private System.Windows.Forms.DataGridView gIAOVIENDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource bdsGiaoVien;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtHocVi;
        private DevExpress.XtraEditors.TextEdit txtMaKH2;
        private System.Windows.Forms.BindingSource bdsBoDe;
        private DSTableAdapters.BODETableAdapter bODETableAdapter;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
    }
}