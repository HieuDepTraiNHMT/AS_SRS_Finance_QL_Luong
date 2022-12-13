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
    public partial class ChiTiet_NhanVien : Form
    {
        SqlConnection con;
        SqlCommand com;
        String str = @"Data Source=LAPTOP-6PPQ4G5I\SQLEXPRESS;Initial Catalog=QL_Luong;Persist Security Info=True;User ID=sa;Password=123";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public static String a = "";
        public ChiTiet_NhanVien()
        {
            InitializeComponent();

        }



        private void Btn_Back_CTNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChiTiet_NhanVien_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            txt_MaNV.Text = a;
            LoadData();

        }

        void LoadData()
        {
            com = con.CreateCommand();
            com.CommandText = "select * from NhanVien where MaNV='"+txt_MaNV.Text+"'";
            adapter.SelectCommand = com;
            table.Clear();
            Chitiet_ChamCong.a = a;
            ChiTiet_PhieuChiLuong.a = a;

            adapter.Fill(table);

            

            foreach (DataRow item in table.Rows)
            {
            
                    txt_TenNV.Text = item[1].ToString();
                    txt_ChucVu.Text = item[2].ToString();
                    txt_NS.Text = DateTime.Parse(item[3].ToString()).ToString("dd/MM/yyyy");
                    txt_GioiTinh.Text = item[4].ToString();
                    txt_SDT.Text = item[5].ToString();

                     if(item[6].ToString()=="False")
                {
                    btn_XemBieuPhi.Enabled = false;
                    Btn_XemChamCong.Enabled = false;
                }    
            }
        }

        private void Btn_XemChamCong_Click(object sender, EventArgs e)
        {
            Chitiet_ChamCong ct = new Chitiet_ChamCong();
            ct.ShowDialog();
        }

        private void btn_XemBieuPhi_Click(object sender, EventArgs e)
        {
            ChiTiet_PhieuChiLuong pcl = new ChiTiet_PhieuChiLuong();
            pcl.ShowDialog();
        }
    }
}
