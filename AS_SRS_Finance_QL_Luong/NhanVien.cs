using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AS_SRS_Finance_QL_Luong
{
    public partial class NhanVien : Form
    {
        SqlConnection con;
        SqlCommand com;
        String str = @"Data Source=LAPTOP-6PPQ4G5I\SQLEXPRESS;Initial Catalog=QL_Luong;Persist Security Info=True;User ID=sa;Password=123";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        int intRow = 0;

        void LoadData()
        {
            com = con.CreateCommand();
            com.CommandText = "select MaNV,HoTen,ChucVu,TrangThai from NhanVien";
            adapter.SelectCommand = com;
            table.Clear();
            adapter.Fill(table);
            
            BangNV.DataSource = table;

            BangNV.Columns[0].HeaderText = "Mã Nhân Viên";
            BangNV.Columns[1].HeaderText = "Tên Nhân Viên";
            BangNV.Columns[2].HeaderText = "Chức vụ";
            BangNV.Columns[3].HeaderText = "Trạng Thái Hoạt Động";

            foreach (DataRow item in table.Rows)
            {

                if (item[3].ToString() == "True")
                {
                    intRow ++;
                }
            }
            lbl_Soluong.Text = intRow.ToString();
        }

        
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            LoadData();
            
        }


        private void BangNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChiTiet_NhanVien.a = BangNV.Rows[e.RowIndex].Cells[0].Value.ToString();
            ChiTiet_NhanVien h = new ChiTiet_NhanVien();
            h.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select MaNV,HoTen,ChucVu,TrangThai from NhanVien where MaNV LIKE N'%" + txt_TimKiem.Text + "%' or  HoTen LIKE N'%" + txt_TimKiem.Text + "%'";
            com = con.CreateCommand();
            com.CommandText = sql;
            adapter.SelectCommand = com;
            table.Clear();
            adapter.Fill(table);

            BangNV.DataSource = table;
        }
    }
}
