
namespace AS_SRS_Finance_QL_Luong
{
    partial class DeSuat_PheDuyet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaDeSuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDeSuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qLLuongDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);

            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLuongDataSetBindingSource)).BeginInit();

            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 100);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(39, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 31);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tìm Kiếm Đề Suất:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(813, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(621, 46);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(186, 25);
            this.Label.TabIndex = 5;
            this.Label.Text = "Tổng Số Đề Suất:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 552);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDeSuat,
            this.TenDeSuat,
            this.TenNhanVien,
            this.Datetime});
            this.dataGridView1.DataSource = this.qLLuongDataSetBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(920, 552);
            this.dataGridView1.TabIndex = 0;
            // 
            // MaDeSuat
            // 
            this.MaDeSuat.HeaderText = "Mã Đề Suất";
            this.MaDeSuat.MinimumWidth = 6;
            this.MaDeSuat.Name = "MaDeSuat";
            this.MaDeSuat.Width = 125;
            // 
            // TenDeSuat
            // 
            this.TenDeSuat.HeaderText = "Tên Đề Suất";
            this.TenDeSuat.MinimumWidth = 6;
            this.TenDeSuat.Name = "TenDeSuat";
            this.TenDeSuat.Width = 125;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.HeaderText = "Tên Nhân Viên Đề Suất";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Width = 125;
            // 
            // Datetime
            // 
            this.Datetime.HeaderText = "Thời Gian Đề Suất";
            this.Datetime.MinimumWidth = 6;
            this.Datetime.Name = "Datetime";
            this.Datetime.Width = 125;
            // 
            // qLLuongDataSetBindingSource
            // 

            this.qLLuongDataSetBindingSource.Position = 0;
            // 
            // qL_LuongDataSet

            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AS_SRS_Finance_QL_Luong.Properties.Resources.search_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(347, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 31);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DeSuat_PheDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeSuat_PheDuyet";
            this.Text = "DeSuat_PheDuyet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLuongDataSetBindingSource)).EndInit();

            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDeSuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDeSuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datetime;
        private System.Windows.Forms.BindingSource qLLuongDataSetBindingSource;

    }
}