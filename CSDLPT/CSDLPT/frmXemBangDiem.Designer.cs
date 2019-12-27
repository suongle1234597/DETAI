namespace CSDLPT
{
    partial class frmXemBangDiem
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
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label label1;
            this.cmbTenMH = new System.Windows.Forms.ComboBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new CSDLPT.DS();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.btnXem = new System.Windows.Forms.Button();
            this.cmbLan = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.labelCoSo = new System.Windows.Forms.Label();
            this.dSLOPTableAdapter = new CSDLPT.DSTableAdapters.DSLOPTableAdapter();
            this.dSMHTableAdapter = new CSDLPT.DSTableAdapters.DSMHTableAdapter();
            tENMHLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            this.SuspendLayout();
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENMHLabel.Location = new System.Drawing.Point(801, 133);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(71, 21);
            tENMHLabel.TabIndex = 60;
            tENMHLabel.Text = "TENMH:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(174, 195);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(76, 21);
            tENLOPLabel.TabIndex = 58;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(801, 195);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 21);
            label1.TabIndex = 48;
            label1.Text = "LAN:";
            // 
            // cmbTenMH
            // 
            this.cmbTenMH.DataSource = this.bdsMH;
            this.cmbTenMH.DisplayMember = "TENMH";
            this.cmbTenMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenMH.FormattingEnabled = true;
            this.cmbTenMH.Location = new System.Drawing.Point(928, 130);
            this.cmbTenMH.Name = "cmbTenMH";
            this.cmbTenMH.Size = new System.Drawing.Size(343, 29);
            this.cmbTenMH.TabIndex = 62;
            this.cmbTenMH.ValueMember = "MAMH";
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "DSMH";
            this.bdsMH.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DataSource = this.bdsLop;
            this.cmbTenLop.DisplayMember = "TENLOP";
            this.cmbTenLop.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(301, 192);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(343, 29);
            this.cmbTenLop.TabIndex = 61;
            this.cmbTenLop.ValueMember = "MALOP";
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "DSLOP";
            this.bdsLop.DataSource = this.dS;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.Black;
            this.btnXem.Location = new System.Drawing.Point(505, 279);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(117, 31);
            this.btnXem.TabIndex = 59;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cmbLan
            // 
            this.cmbLan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLan.FormattingEnabled = true;
            this.cmbLan.Location = new System.Drawing.Point(928, 192);
            this.cmbLan.Name = "cmbLan";
            this.cmbLan.Size = new System.Drawing.Size(343, 29);
            this.cmbLan.TabIndex = 49;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(769, 279);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 31);
            this.btnThoat.TabIndex = 51;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DisplayMember = "TENCS";
            this.cmbCoSo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(301, 130);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(343, 30);
            this.cmbCoSo.TabIndex = 52;
            this.cmbCoSo.ValueMember = "TENSERVER";
            // 
            // labelCoSo
            // 
            this.labelCoSo.AutoSize = true;
            this.labelCoSo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoSo.Location = new System.Drawing.Point(174, 134);
            this.labelCoSo.Name = "labelCoSo";
            this.labelCoSo.Size = new System.Drawing.Size(59, 21);
            this.labelCoSo.TabIndex = 53;
            this.labelCoSo.Text = "COSO:";
            // 
            // dSLOPTableAdapter
            // 
            this.dSLOPTableAdapter.ClearBeforeFill = true;
            // 
            // dSMHTableAdapter
            // 
            this.dSMHTableAdapter.ClearBeforeFill = true;
            // 
            // frmXemBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 503);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.cmbTenMH);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.cmbTenLop);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cmbLan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cmbCoSo);
            this.Controls.Add(this.labelCoSo);
            this.Controls.Add(label1);
            this.Name = "frmXemBangDiem";
            this.Text = "Xem Bảng Điểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXemBangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTenMH;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cmbLan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label labelCoSo;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.DSLOPTableAdapter dSLOPTableAdapter;
        private System.Windows.Forms.BindingSource bdsMH;
        private DSTableAdapters.DSMHTableAdapter dSMHTableAdapter;
    }
}