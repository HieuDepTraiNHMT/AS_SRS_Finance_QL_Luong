using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_SRS_Finance_QL_Luong
{
    public partial class DangNhap : Form
    {
        SqlConnection con;
        SqlCommand com;
        String str = @"Data Source=LAPTOP-6PPQ4G5I\SQLEXPRESS;Initial Catalog=QL_Luong;Persist Security Info=True;User ID=sa;Password=123";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
     
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Btn_DangNhap_Click(object sender, EventArgs e)
        {
            com = con.CreateCommand();
            com.CommandText = "select * from NhanVien where MaNV='" + txt_TaiKhoan.Text + "' AND MatKhau='"+txt_MatKhau.Text+"'";
            adapter.SelectCommand = com;
            table.Clear();
            adapter.Fill(table);

            if(table.Rows.Count>0)
            {
                TrangChu.a = txt_TaiKhoan.Text;
                this.Hide();
                TrangChu a = new TrangChu();
                a.ShowDialog();
                this.Close();
            }    
            else
            {
                MessageBox.Show("Lỗi đăng nhập!", "Thông báo",
                             MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }    
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            
            txt_TaiKhoan.Focus();
        }

        private void txt_TaiKhoan_Leave(object sender, EventArgs e)
        {
            if(txt_TaiKhoan.Text=="")
            {
                errorProvider1.SetError(this.txt_TaiKhoan, "Không được để trống!");
            }    
            else
            {
                errorProvider1.Clear();
            }    
        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txt_MatKhau.Text == "")
            {
                errorProvider1.SetError(this.txt_MatKhau, "Không được để trống!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void Btn_Huy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
