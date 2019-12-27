namespace CSDLPT
{
    partial class frmXemDSDangKy
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
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label label2;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.dateEditDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.dateEditNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.vDSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new CSDLPT.DS();
            this.label1 = new System.Windows.Forms.Label();
            this.v_DSPMTableAdapter = new CSDLPT.DSTableAdapters.V_DSPMTableAdapter();
            this.tableAdapterManager = new CSDLPT.DSTableAdapters.TableAdapterManager();
            nGAYTHILabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYTHILabel.Location = new System.Drawing.Point(399, 188);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(87, 23);
            nGAYTHILabel.TabIndex = 41;
            nGAYTHILabel.Text = "Từ ngày:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(399, 274);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 23);
            label2.TabIndex = 43;
            label2.Text = "Đến ngày:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnXem);
            this.panelControl1.Controls.Add(label2);
            this.panelControl1.Controls.Add(this.dateEditDenNgay);
            this.panelControl1.Controls.Add(nGAYTHILabel);
            this.panelControl1.Controls.Add(this.dateEditNgayBatDau);
            this.panelControl1.Controls.Add(this.cmbCoSo);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1358, 619);
            this.panelControl1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(809, 377);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 42);
            this.btnThoat.TabIndex = 46;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(495, 377);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(140, 42);
            this.btnXem.TabIndex = 45;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dateEditDenNgay
            // 
            this.dateEditDenNgay.EditValue = null;
            this.dateEditDenNgay.Location = new System.Drawing.Point(525, 271);
            this.dateEditDenNgay.Name = "dateEditDenNgay";
            this.dateEditDenNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditDenNgay.Properties.Appearance.Options.UseFont = true;
            this.dateEditDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDenNgay.Size = new System.Drawing.Size(460, 28);
            this.dateEditDenNgay.TabIndex = 44;
            // 
            // dateEditNgayBatDau
            // 
            this.dateEditNgayBatDau.EditValue = null;
            this.dateEditNgayBatDau.Location = new System.Drawing.Point(525, 185);
            this.dateEditNgayBatDau.Name = "dateEditNgayBatDau";
            this.dateEditNgayBatDau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditNgayBatDau.Properties.Appearance.Options.UseFont = true;
            this.dateEditNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayBatDau.Size = new System.Drawing.Size(460, 28);
            this.dateEditNgayBatDau.TabIndex = 42;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(525, 102);
            this.cmbCoSo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(460, 30);
            this.cmbCoSo.TabIndex = 41;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // vDSPMBindingSource
            // 
            this.vDSPMBindingSource.DataMember = "V_DSPM";
            this.vDSPMBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "CƠ SỞ:";
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
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
            // frmXemDSDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 619);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXemDSDangKy";
            this.Text = "Xem Danh Sách Đăng Ký";
            this.Load += new System.EventHandler(this.frmXemDSDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private System.Windows.Forms.BindingSource vDSPMBindingSource;
        private DSTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.DateEdit dateEditDenNgay;
        private DevExpress.XtraEditors.DateEdit dateEditNgayBatDau;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXem;
    }
}