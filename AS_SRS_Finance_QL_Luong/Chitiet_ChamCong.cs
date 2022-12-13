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
    public partial class Chitiet_ChamCong : Form
    {
        SqlConnection con;
        SqlCommand com;
        String str = @"Data Source=LAPTOP-6PPQ4G5I\SQLEXPRESS;Initial Catalog=QL_Luong;Persist Security Info=True;User ID=sa;Password=123";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public static String a = "";
        public Chitiet_ChamCong()
        {
            InitializeComponent();
        }

        private void Chitiet_ChamCong_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            LoadData();
            
        }

        void LoadData()
        {
           
            com = con.CreateCommand();
            com.CommandText = "select ct.* , ctct.TrangThai from ChiTiet_CongTac ctct full outer join CongTac ct on ctct.MaCongTac=ct.MaCongTac  where ctct.MaNV='" + a + "'";
            adapter.SelectCommand = com;
            table.Clear();
            adapter.Fill(table);

            ds_CongTac.DataSource = table;

            ds_CongTac.Columns[0].HeaderText = "Mã Công Việc";
            ds_CongTac.Columns[1].HeaderText = "Nội Dung Công Việc";
            ds_CongTac.Columns[2].HeaderText = "Thời gian";
            ds_CongTac.Columns[3].HeaderText = "Trạng Thái";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Tất Cả") {
                LoadData();
            }
            else{

                string sql = "select ct.* , ctct.TrangThai from ChiTiet_CongTac ctct full outer join CongTac ct on ctct.MaCongTac=ct.MaCongTac  where ctct.MaNV='" + a + "' and MONTH( ct.ThoiGian)= '" + comboBox1.Text.ToString() + "'";
                com = con.CreateCommand();
                com.CommandText = sql;
                adapter.SelectCommand = com;
                table.Clear();
                adapter.Fill(table);

                ds_CongTac.DataSource = table;
            }
        }
    }
}
