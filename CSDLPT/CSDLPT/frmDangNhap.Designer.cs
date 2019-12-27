namespace CSDLPT
{
    partial class frmDangNhap
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
            this.rdbSinhVien = new System.Windows.Forms.RadioButton();
            this.rdbGiangVien = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.dS = new CSDLPT.DS();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.v_DSPMTableAdapter = new CSDLPT.DSTableAdapters.V_DSPMTableAdapter();
            this.vDSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbSinhVien
            // 
            this.rdbSinhVien.AutoSize = true;
            this.rdbSinhVien.Checked = true;
            this.rdbSinhVien.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSinhVien.Location = new System.Drawing.Point(620, 38);
            this.rdbSinhVien.Name = "rdbSinhVien";
            this.rdbSinhVien.Size = new System.Drawing.Size(108, 27);
            this.rdbSinhVien.TabIndex = 0;
            this.rdbSinhVien.TabStop = true;
            this.rdbSinhVien.Text = "Sinh viên";
            this.rdbSinhVien.UseVisualStyleBackColor = true;
            // 
            // rdbGiangVien
            // 
            this.rdbGiangVien.AutoSize = true;
            this.rdbGiangVien.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGiangVien.Location = new System.Drawing.Point(337, 38);
            this.rdbGiangVien.Name = "rdbGiangVien";
            this.rdbGiangVien.Size = new System.Drawing.Size(120, 27);
            this.rdbGiangVien.TabIndex = 1;
            this.rdbGiangVien.Text = "Giảng viên";
            this.rdbGiangVien.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cơ sở";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tài khoản";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(294, 298);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(137, 32);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(591, 298);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 32);
            this.btnThoat.TabIndex = 7;
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
            this.cmbCoSo.Location = new System.Drawing.Point(277, 102);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(502, 30);
            this.cmbCoSo.TabIndex = 8;
            this.cmbCoSo.ValueMember = "TENSERVER";
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(277, 165);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(502, 29);
            this.txtTaiKhoan.TabIndex = 9;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(277, 225);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(502, 29);
            this.txtMatKhau.TabIndex = 10;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // vDSPMBindingSource
            // 
            this.vDSPMBindingSource.DataMember = "V_DSPM";
            this.vDSPMBindingSource.DataSource = this.dS;
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 395);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.cmbCoSo);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbGiangVien);
            this.Controls.Add(this.rdbSinhVien);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbSinhVien;
        private System.Windows.Forms.RadioButton rdbGiangVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private DS dS;
        private DSTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private System.Windows.Forms.BindingSource vDSPMBindingSource;
    }
}

