namespace CSDLPT
{
    partial class frmXemKetQua
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label tENMHLabel;
            this.labelCoSo = new System.Windows.Forms.Label();
            this.labelTrinhDo = new System.Windows.Forms.Label();
            this.dS = new CSDLPT.DS();
            this.dSLOPTableAdapter = new CSDLPT.DSTableAdapters.DSLOPTableAdapter();
            this.tableAdapterManager = new CSDLPT.DSTableAdapters.TableAdapterManager();
            this.cmbTrinhDo = new System.Windows.Forms.ComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbTenMH = new System.Windows.Forms.ComboBox();
            this.bdsDSMH = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.bdsDSLop = new System.Windows.Forms.BindingSource(this.components);
            this.cmbHoTen = new System.Windows.Forms.ComboBox();
            this.bdsDSSV = new System.Windows.Forms.BindingSource(this.components);
            this.btnIn = new System.Windows.Forms.Button();
            this.cmbLan = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.vDSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControlTop = new DevExpress.XtraEditors.PanelControl();
            this.gcXemKetQua = new DevExpress.XtraGrid.GridControl();
            this.bdsXemKetQua = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRALOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dSSVTableAdapter = new CSDLPT.DSTableAdapters.DSSVTableAdapter();
            this.dSMHTableAdapter = new CSDLPT.DSTableAdapters.DSMHTableAdapter();
            this.v_DSPMTableAdapter = new CSDLPT.DSTableAdapters.V_DSPMTableAdapter();
            this.sP_XemKetQuaTableAdapter = new CSDLPT.DSTableAdapters.SP_XemKetQuaTableAdapter();
            label1 = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).BeginInit();
            this.panelControlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcXemKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXemKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(733, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 21);
            label1.TabIndex = 4;
            label1.Text = "LAN:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENLabel.Location = new System.Drawing.Point(733, 75);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(70, 21);
            hOTENLabel.TabIndex = 43;
            hOTENLabel.Text = "HOTEN:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(118, 26);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(76, 21);
            tENLOPLabel.TabIndex = 45;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENMHLabel.Location = new System.Drawing.Point(118, 75);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(71, 21);
            tENMHLabel.TabIndex = 46;
            tENMHLabel.Text = "TENMH:";
            // 
            // labelCoSo
            // 
            this.labelCoSo.AutoSize = true;
            this.labelCoSo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoSo.Location = new System.Drawing.Point(118, 124);
            this.labelCoSo.Name = "labelCoSo";
            this.labelCoSo.Size = new System.Drawing.Size(59, 21);
            this.labelCoSo.TabIndex = 42;
            this.labelCoSo.Text = "COSO:";
            // 
            // labelTrinhDo
            // 
            this.labelTrinhDo.AutoSize = true;
            this.labelTrinhDo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrinhDo.Location = new System.Drawing.Point(733, 124);
            this.labelTrinhDo.Name = "labelTrinhDo";
            this.labelTrinhDo.Size = new System.Drawing.Size(89, 21);
            this.labelTrinhDo.TabIndex = 43;
            this.labelTrinhDo.Text = "TRINHDO:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSLOPTableAdapter
            // 
            this.dSLOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CHITIET_BAITHITableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbTrinhDo
            // 
            this.cmbTrinhDo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrinhDo.FormattingEnabled = true;
            this.cmbTrinhDo.Location = new System.Drawing.Point(882, 121);
            this.cmbTrinhDo.Name = "cmbTrinhDo";
            this.cmbTrinhDo.Size = new System.Drawing.Size(343, 29);
            this.cmbTrinhDo.TabIndex = 44;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(tENMHLabel);
            this.panelControl1.Controls.Add(this.cmbTenMH);
            this.panelControl1.Controls.Add(tENLOPLabel);
            this.panelControl1.Controls.Add(this.cmbTenLop);
            this.panelControl1.Controls.Add(this.cmbHoTen);
            this.panelControl1.Controls.Add(hOTENLabel);
            this.panelControl1.Controls.Add(this.btnIn);
            this.panelControl1.Controls.Add(this.cmbLan);
            this.panelControl1.Controls.Add(this.btnXem);
            this.panelControl1.Controls.Add(this.labelTrinhDo);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.cmbCoSo);
            this.panelControl1.Controls.Add(this.labelCoSo);
            this.panelControl1.Controls.Add(label1);
            this.panelControl1.Controls.Add(this.cmbTrinhDo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1454, 226);
            this.panelControl1.TabIndex = 43;
            // 
            // cmbTenMH
            // 
            this.cmbTenMH.DataSource = this.bdsDSMH;
            this.cmbTenMH.DisplayMember = "TENMH";
            this.cmbTenMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenMH.FormattingEnabled = true;
            this.cmbTenMH.Location = new System.Drawing.Point(245, 72);
            this.cmbTenMH.Name = "cmbTenMH";
            this.cmbTenMH.Size = new System.Drawing.Size(343, 29);
            this.cmbTenMH.TabIndex = 47;
            this.cmbTenMH.ValueMember = "MAMH";
            // 
            // bdsDSMH
            // 
            this.bdsDSMH.DataMember = "DSMH";
            this.bdsDSMH.DataSource = this.dS;
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DataSource = this.bdsDSLop;
            this.cmbTenLop.DisplayMember = "TENLOP";
            this.cmbTenLop.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(245, 23);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(343, 29);
            this.cmbTenLop.TabIndex = 46;
            this.cmbTenLop.ValueMember = "MALOP";
            // 
            // bdsDSLop
            // 
            this.bdsDSLop.DataMember = "DSLOP";
            this.bdsDSLop.DataSource = this.dS;
            // 
            // cmbHoTen
            // 
            this.cmbHoTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSSV, "HOTEN", true));
            this.cmbHoTen.DataSource = this.bdsDSSV;
            this.cmbHoTen.DisplayMember = "HOTEN";
            this.cmbHoTen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHoTen.FormattingEnabled = true;
            this.cmbHoTen.Location = new System.Drawing.Point(882, 72);
            this.cmbHoTen.Name = "cmbHoTen";
            this.cmbHoTen.Size = new System.Drawing.Size(343, 29);
            this.cmbHoTen.TabIndex = 44;
            this.cmbHoTen.ValueMember = "MASV";
            // 
            // bdsDSSV
            // 
            this.bdsDSSV.DataMember = "DSSV";
            this.bdsDSSV.DataSource = this.dS;
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.Black;
            this.btnIn.Location = new System.Drawing.Point(696, 175);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(117, 31);
            this.btnIn.TabIndex = 45;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // cmbLan
            // 
            this.cmbLan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLan.FormattingEnabled = true;
            this.cmbLan.Location = new System.Drawing.Point(882, 23);
            this.cmbLan.Name = "cmbLan";
            this.cmbLan.Size = new System.Drawing.Size(343, 29);
            this.cmbLan.TabIndex = 5;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.Black;
            this.btnXem.Location = new System.Drawing.Point(482, 175);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(117, 31);
            this.btnXem.TabIndex = 7;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(901, 175);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 31);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DataSource = this.vDSPMBindingSource;
            this.cmbCoSo.DisplayMember = "TENCS";
            this.cmbCoSo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(245, 120);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(343, 30);
            this.cmbCoSo.TabIndex = 41;
            this.cmbCoSo.ValueMember = "TENSERVER";
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // vDSPMBindingSource
            // 
            this.vDSPMBindingSource.DataMember = "V_DSPM";
            this.vDSPMBindingSource.DataSource = this.dS;
            // 
            // panelControlTop
            // 
            this.panelControlTop.Controls.Add(this.gcXemKetQua);
            this.panelControlTop.Controls.Add(this.panelControl1);
            this.panelControlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlTop.Location = new System.Drawing.Point(0, 0);
            this.panelControlTop.Name = "panelControlTop";
            this.panelControlTop.Size = new System.Drawing.Size(1458, 634);
            this.panelControlTop.TabIndex = 0;
            // 
            // gcXemKetQua
            // 
            this.gcXemKetQua.DataSource = this.bdsXemKetQua;
            this.gcXemKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcXemKetQua.Location = new System.Drawing.Point(2, 228);
            this.gcXemKetQua.MainView = this.gridView1;
            this.gcXemKetQua.Name = "gcXemKetQua";
            this.gcXemKetQua.Size = new System.Drawing.Size(1454, 404);
            this.gcXemKetQua.TabIndex = 43;
            this.gcXemKetQua.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsXemKetQua
            // 
            this.bdsXemKetQua.DataMember = "SP_XemKetQua";
            this.bdsXemKetQua.DataSource = this.dS;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCAUHOI,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAP_AN,
            this.colTRALOI});
            this.gridView1.GridControl = this.gcXemKetQua;
            this.gridView1.Name = "gridView1";
            // 
            // colCAUHOI
            // 
            this.colCAUHOI.FieldName = "CAUHOI";
            this.colCAUHOI.MinWidth = 25;
            this.colCAUHOI.Name = "colCAUHOI";
            this.colCAUHOI.Visible = true;
            this.colCAUHOI.VisibleIndex = 0;
            this.colCAUHOI.Width = 94;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.MinWidth = 25;
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 1;
            this.colNOIDUNG.Width = 94;
            // 
            // colA
            // 
            this.colA.FieldName = "A";
            this.colA.MinWidth = 25;
            this.colA.Name = "colA";
            this.colA.Visible = true;
            this.colA.VisibleIndex = 2;
            this.colA.Width = 94;
            // 
            // colB
            // 
            this.colB.FieldName = "B";
            this.colB.MinWidth = 25;
            this.colB.Name = "colB";
            this.colB.Visible = true;
            this.colB.VisibleIndex = 3;
            this.colB.Width = 94;
            // 
            // colC
            // 
            this.colC.FieldName = "C";
            this.colC.MinWidth = 25;
            this.colC.Name = "colC";
            this.colC.Visible = true;
            this.colC.VisibleIndex = 4;
            this.colC.Width = 94;
            // 
            // colD
            // 
            this.colD.FieldName = "D";
            this.colD.MinWidth = 25;
            this.colD.Name = "colD";
            this.colD.Visible = true;
            this.colD.VisibleIndex = 5;
            this.colD.Width = 94;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.MinWidth = 25;
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 6;
            this.colDAP_AN.Width = 94;
            // 
            // colTRALOI
            // 
            this.colTRALOI.FieldName = "TRALOI";
            this.colTRALOI.MinWidth = 25;
            this.colTRALOI.Name = "colTRALOI";
            this.colTRALOI.Visible = true;
            this.colTRALOI.VisibleIndex = 7;
            this.colTRALOI.Width = 94;
            // 
            // dSSVTableAdapter
            // 
            this.dSSVTableAdapter.ClearBeforeFill = true;
            // 
            // dSMHTableAdapter
            // 
            this.dSMHTableAdapter.ClearBeforeFill = true;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // sP_XemKetQuaTableAdapter
            // 
            this.sP_XemKetQuaTableAdapter.ClearBeforeFill = true;
            // 
            // frmXemKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 634);
            this.Controls.Add(this.panelControlTop);
            this.Name = "frmXemKetQua";
            this.Text = "Xem Kết Quả";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXemKetQua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).EndInit();
            this.panelControlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcXemKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXemKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DS dS;
        private DSTableAdapters.DSLOPTableAdapter dSLOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbTrinhDo;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.ComboBox cmbLan;
        private DevExpress.XtraEditors.PanelControl panelControlTop;
        private System.Windows.Forms.BindingSource bdsDSSV;
        private DSTableAdapters.DSSVTableAdapter dSSVTableAdapter;
        private System.Windows.Forms.ComboBox cmbHoTen;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private System.Windows.Forms.BindingSource bdsDSLop;
        private DSTableAdapters.DSMHTableAdapter dSMHTableAdapter;
        private System.Windows.Forms.ComboBox cmbTenMH;
        private System.Windows.Forms.BindingSource bdsDSMH;
        private System.Windows.Forms.BindingSource vDSPMBindingSource;
        private DSTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private System.Windows.Forms.Label labelTrinhDo;
        private System.Windows.Forms.Label labelCoSo;
        private System.Windows.Forms.BindingSource bdsXemKetQua;
        private DSTableAdapters.SP_XemKetQuaTableAdapter sP_XemKetQuaTableAdapter;
        private DevExpress.XtraGrid.GridControl gcXemKetQua;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
        private DevExpress.XtraGrid.Columns.GridColumn colTRALOI;
    }
}