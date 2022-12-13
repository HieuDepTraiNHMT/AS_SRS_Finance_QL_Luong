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
    public partial class ChiTiet_PhieuChiLuong : Form
    {
        SqlConnection con;
        SqlCommand com;
        String str = @"Data Source=LAPTOP-6PPQ4G5I\SQLEXPRESS;Initial Catalog=QL_Luong;Persist Security Info=True;User ID=sa;Password=123";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public static string a = "";
        int thang = DateTime.Now.Month;
        int nam = DateTime.Now.Year;
        int tiencongtac = 0;
        int luonght = 0;
        int luongkt = 0;
        int luongcb = 0;
        public ChiTiet_PhieuChiLuong()
        {
            InitializeComponent();
        }

        private void ChiTiet_PhieuChiLuong_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            label2.Text = DateTime.Now.ToString("MM/yyyy");

            LoadTenNV();
            Loaddata();
            LoadLuongHT();
            LoadLuongKT();
            TongTien.Text = (luongcb + luonght + tiencongtac - luongkt)+"  VNĐ";
        }
        void LoadTenNV()
        {
            com = con.CreateCommand();
            com.CommandText = "select * from NhanVien where MaNV='" + a+ "'";
            adapter.SelectCommand = com;
            table.Clear();
            Chitiet_ChamCong.a = a;
            

            adapter.Fill(table);



            foreach (DataRow item in table.Rows)
            {
                lbl_HoTen.Text = item[1].ToString();
                lbl_ChucVu.Text = item[2].ToString();        
                lbl_LuongCB.Text = item[7].ToString();
                luongcb = int.Parse(item[7].ToString());
                lbl_STK.Text = item[5].ToString();
            }
        }

        void Loaddata()
        {
             adapter = new SqlDataAdapter();
             table = new DataTable();
            com = con.CreateCommand();
                com.CommandText = "select ct.MaBP, ct.NoiDungCT,ct.ThoiGian,ctct.TrangThai from BieuPhiLuong l ,ChiTiet_CongTac ctct,CongTac ct where l.MaBP=ct.MaBP and ctct.MaCongTac=ct.MaCongTac and ctct.MaNV='" + a + "' and ctct.TrangThai=1 and MONTH( ct.ThoiGian)= " + thang + " and year( ct.ThoiGian)= " + nam + "";
                adapter.SelectCommand = com;
                table.Clear();
                adapter.Fill(table);

                ds_TinhPhi.DataSource = table;
                ds_TinhPhi.Columns[0].HeaderText = "Mã Biểu Phí";
                ds_TinhPhi.Columns[1].HeaderText = "Nội Dung Công Việc";
                ds_TinhPhi.Columns[2].HeaderText = "Thời gian";
                ds_TinhPhi.Columns[3].HeaderText = "Trạng Thái";
            foreach (DataRow item in table.Rows)
            {
              if(  int.Parse( item[0].ToString()) ==1)
                {
                    tiencongtac += 120000;
                }
               else if (int.Parse(item[0].ToString()) == 2)
                {
                    tiencongtac += 100000;
                }
               else if (int.Parse(item[0].ToString()) == 3)
                {
                    tiencongtac += 80000;
                }
                else
                {
                    tiencongtac += 60000;
                }   
            }
            lbl_LuongCT.Text = tiencongtac.ToString();


        }

        void LoadLuongHT()
        {
            adapter = new SqlDataAdapter();
            table = new DataTable();
            com = con.CreateCommand();
            com.CommandText = "select *from LuongHoTro where MaNV='"+a+"' and MONTH( thang)= "+thang+" and year( thang)= "+nam+"";
            adapter.SelectCommand = com;
            table.Clear();
            adapter.Fill(table);

            foreach (DataRow item in table.Rows)
            {
                luonght += int. Parse(item[3].ToString());
                
            }
            lbl_LuongHT.Text = luonght.ToString();
        }

        void LoadLuongKT()
        {
            adapter = new SqlDataAdapter();
            table = new DataTable();
            com = con.CreateCommand();
            com.CommandText = "select *from LuongKhauTru where MaNV='" + a + "' and MONTH( thang)= " + thang + " and year( thang)= " + nam + "";
            adapter.SelectCommand = com;
            table.Clear();
            adapter.Fill(table);

            foreach (DataRow item in table.Rows)
            {
                luongkt += int.Parse(item[3].ToString());

            }
            lbl_LuongKT.Text = "- "+luongkt.ToString();
        }
    }
}
