
namespace AS_SRS_Finance_QL_Luong
{
    partial class DangNhap
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Huy = new System.Windows.Forms.Button();
            this.Btn_DangNhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Btn_Huy);
            this.panel2.Controls.Add(this.Btn_DangNhap);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_MatKhau);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_TaiKhoan);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(723, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 710);
            this.panel2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 684);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Alata Software";
            // 
            // Btn_Huy
            // 
            this.Btn_Huy.Location = new System.Drawing.Point(86, 428);
            this.Btn_Huy.Name = "Btn_Huy";
            this.Btn_Huy.Size = new System.Drawing.Size(110, 40);
            this.Btn_Huy.TabIndex = 20;
            this.Btn_Huy.Text = "Hủy";
            this.Btn_Huy.UseVisualStyleBackColor = true;
            this.Btn_Huy.Click += new System.EventHandler(this.Btn_Huy_Click);
            // 
            // Btn_DangNhap
            // 
            this.Btn_DangNhap.Location = new System.Drawing.Point(296, 428);
            this.Btn_DangNhap.Name = "Btn_DangNhap";
            this.Btn_DangNhap.Size = new System.Drawing.Size(111, 40);
            this.Btn_DangNhap.TabIndex = 19;
            this.Btn_DangNhap.Text = "Đăng Nhập";
            this.Btn_DangNhap.UseVisualStyleBackColor = true;
            this.Btn_DangNhap.Click += new System.EventHandler(this.Btn_DangNhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mật Khẩu:";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(42, 352);
            this.txt_MatKhau.Multiline = true;
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(391, 42);
            this.txt_MatKhau.TabIndex = 17;
            this.txt_MatKhau.Text = "123";
            this.txt_MatKhau.TextChanged += new System.EventHandler(this.txt_MatKhau_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tài Khoản:";
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.Location = new System.Drawing.Point(42, 262);
            this.txt_TaiKhoan.Multiline = true;
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(391, 39);
            this.txt_TaiKhoan.TabIndex = 15;
            this.txt_TaiKhoan.Text = "nv005";
            this.txt_TaiKhoan.Leave += new System.EventHandler(this.txt_TaiKhoan_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BackgroundImage = global::AS_SRS_Finance_QL_Luong.Properties.Resources.Untitled;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(722, 710);
            this.panel7.TabIndex = 18;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DangNhap
            // 
            this.AcceptButton = this.Btn_DangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 710);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Huy;
        private System.Windows.Forms.Button Btn_DangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}