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
    public partial class TrangChu : Form
    {
        SqlConnection con;
        SqlCommand com;
        String str = @"Data Source=LAPTOP-6PPQ4G5I\SQLEXPRESS;Initial Catalog=QL_Luong;Persist Security Info=True;User ID=sa;Password=123";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public static String a = "";

        public TrangChu()
        {
            InitializeComponent();
        }

        

        private Form active = null;
        private void openChildForm(Form ChildForm)
        {
            if (active != null)
                active.Close();
            active = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            Panel_Child.Controls.Add(ChildForm);
            Panel_Child.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new NhanVien());
        }

        private void btn_DeSuat_Click(object sender, EventArgs e)
        {
            openChildForm(new DeSuat_PheDuyet());
        }

        private void btn_CaiDat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            openChildForm(new Help());
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            LoadTenNV();
        }

        void LoadTenNV()
        {
            com = con.CreateCommand();
            com.CommandText = "select * from NhanVien where MaNV='" + a + "'";
            adapter.SelectCommand = com;
            table.Clear();
            

            adapter.Fill(table);



            foreach (DataRow item in table.Rows)
            {
                lbl_TenDN.Text = item[1].ToString();
            }
        }
    }
}
