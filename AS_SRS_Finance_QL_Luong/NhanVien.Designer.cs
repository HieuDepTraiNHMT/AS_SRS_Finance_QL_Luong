
namespace AS_SRS_Finance_QL_Luong
{
    partial class NhanVien
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Soluong = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.BangNV = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BangNV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.txt_TimKiem);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_Soluong);
            this.panel2.Controls.Add(this.Label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 110);
            this.panel2.TabIndex = 2;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_TimKiem.Location = new System.Drawing.Point(30, 53);
            this.txt_TimKiem.Multiline = true;
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(316, 31);
            this.txt_TimKiem.TabIndex = 3;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm Kiếm Nhân Viên";
            // 
            // lbl_Soluong
            // 
            this.lbl_Soluong.AutoSize = true;
            this.lbl_Soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Soluong.Location = new System.Drawing.Point(823, 48);
            this.lbl_Soluong.Name = "lbl_Soluong";
            this.lbl_Soluong.Size = new System.Drawing.Size(64, 25);
            this.lbl_Soluong.TabIndex = 1;
            this.lbl_Soluong.Text = "label1";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(608, 48);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(209, 25);
            this.Label.TabIndex = 0;
            this.Label.Text = "Tổng Số Nhân Viên:";
            // 
            // BangNV
            // 
            this.BangNV.AllowUserToAddRows = false;
            this.BangNV.AllowUserToDeleteRows = false;
            this.BangNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BangNV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BangNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BangNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BangNV.Location = new System.Drawing.Point(0, 110);
            this.BangNV.MultiSelect = false;
            this.BangNV.Name = "BangNV";
            this.BangNV.ReadOnly = true;
            this.BangNV.RowHeadersWidth = 51;
            this.BangNV.RowTemplate.Height = 24;
            this.BangNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BangNV.Size = new System.Drawing.Size(938, 589);
            this.BangNV.TabIndex = 3;
            this.BangNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BangNV_CellClick);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 699);
            this.Controls.Add(this.BangNV);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BangNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Soluong;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.DataGridView BangNV;

        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}