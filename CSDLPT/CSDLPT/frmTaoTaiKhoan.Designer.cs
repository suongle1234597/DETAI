namespace CSDLPT
{
    partial class frmTaoTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dS = new CSDLPT.DS();
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIENTableAdapter = new CSDLPT.DSTableAdapters.GIAOVIENTableAdapter();
            this.tableAdapterManager = new CSDLPT.DSTableAdapters.TableAdapterManager();
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbNhom = new System.Windows.Forms.ComboBox();
            this.cmbTenGV = new System.Windows.Forms.ComboBox();
            this.vDSGVChuaCoTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSGVChuaCoTaiKhoanTableAdapter = new CSDLPT.DSTableAdapters.V_DSGVChuaCoTaiKhoanTableAdapter();
            mAGVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSGVChuaCoTaiKhoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(525, 302);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(81, 24);
            mAGVLabel.TabIndex = 15;
            mAGVLabel.Text = "Tên GV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhóm:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(646, 242);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(376, 28);
            this.txtMatKhau.TabIndex = 14;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(646, 182);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(376, 28);
            this.txtTaiKhoan.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật khẩu";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "GIAOVIEN";
            this.gIAOVIENBindingSource.DataSource = this.dS;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Location = new System.Drawing.Point(559, 396);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(140, 42);
            this.btnTaoTK.TabIndex = 17;
            this.btnTaoTK.Text = "Tạo tài khoản";
            this.btnTaoTK.UseVisualStyleBackColor = true;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(873, 396);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 42);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbNhom
            // 
            this.cmbNhom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "MAGV", true));
            this.cmbNhom.FormattingEnabled = true;
            this.cmbNhom.Location = new System.Drawing.Point(646, 123);
            this.cmbNhom.Name = "cmbNhom";
            this.cmbNhom.Size = new System.Drawing.Size(376, 30);
            this.cmbNhom.TabIndex = 19;
            // 
            // cmbTenGV
            // 
            this.cmbTenGV.DataSource = this.vDSGVChuaCoTaiKhoanBindingSource;
            this.cmbTenGV.DisplayMember = "HOTEN";
            this.cmbTenGV.FormattingEnabled = true;
            this.cmbTenGV.Location = new System.Drawing.Point(646, 299);
            this.cmbTenGV.Name = "cmbTenGV";
            this.cmbTenGV.Size = new System.Drawing.Size(376, 30);
            this.cmbTenGV.TabIndex = 20;
            this.cmbTenGV.ValueMember = "MAGV";
            // 
            // vDSGVChuaCoTaiKhoanBindingSource
            // 
            this.vDSGVChuaCoTaiKhoanBindingSource.DataMember = "V_DSGVChuaCoTaiKhoan";
            this.vDSGVChuaCoTaiKhoanBindingSource.DataSource = this.dS;
            // 
            // v_DSGVChuaCoTaiKhoanTableAdapter
            // 
            this.v_DSGVChuaCoTaiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 619);
            this.Controls.Add(this.cmbTenGV);
            this.Controls.Add(this.cmbNhom);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaoTK);
            this.Controls.Add(mAGVLabel);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "Tạo Tài Khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSGVChuaCoTaiKhoanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DS dS;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private DSTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnTaoTK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbNhom;
        private System.Windows.Forms.ComboBox cmbTenGV;
        private System.Windows.Forms.BindingSource vDSGVChuaCoTaiKhoanBindingSource;
        private DSTableAdapters.V_DSGVChuaCoTaiKhoanTableAdapter v_DSGVChuaCoTaiKhoanTableAdapter;
    }
}