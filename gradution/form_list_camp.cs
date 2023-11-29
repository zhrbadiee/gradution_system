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

namespace gradution
{
    public partial class form_list_camp : Form
    {
        public form_list_camp()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        public void connect()
        {

            con = new SqlConnection("Data source=.\\SQLEXPRESS;initial catalog=Graduates's Organize; integrated security = true");
            con.Open();

        }
        public void disconnect()
        {
            con.Close();
        }

        void display()
        {
            connect();
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select id_camp,name_c,place_c,count_c,date_start_c,date_finish_c,comment_c,majer_c from Camps";
            adp.Fill(ds, "Camps");
            dataGrid_list_camp.DataSource = ds;
            dataGrid_list_camp.DataMember = "Camps";

            dataGrid_list_camp.Columns[0].HeaderText = "کداردو";
            dataGrid_list_camp.Columns[1].HeaderText = "نام اردو";
            dataGrid_list_camp.Columns[2].HeaderText = "مکان";
            dataGrid_list_camp.Columns[3].HeaderText = "ظرفیت";
            dataGrid_list_camp.Columns[4].HeaderText = "تاریخ شروع";
            dataGrid_list_camp.Columns[5].HeaderText = "تاریخ پایان";
            dataGrid_list_camp.Columns[6].HeaderText = "توضیحات";
            dataGrid_list_camp.Columns[7].HeaderText = "زمینه";

            dataGrid_list_camp.Columns[0].Width = 50;
            dataGrid_list_camp.Columns[1].Width = 100;
            dataGrid_list_camp.Columns[2].Width = 110;
            dataGrid_list_camp.Columns[3].Width = 50;
            dataGrid_list_camp.Columns[6].Width = 155;
            dataGrid_list_camp.Columns[7].Width = 62;

        }
        private void txtbox_idcamp_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select id_camp,name_c,place_c,count_c,date_start_c,date_finish_c,comment_c,majer_c from Camps where id_camp like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_idcamp.Text);
            adp.Fill(ds, "Camps");
            dataGrid_list_camp.DataSource = ds;
            dataGrid_list_camp.DataMember = "Camps";
        }

        private void form_list_camp_Load(object sender, EventArgs e)
        {
            display();
        }

        private void txtbox_name_cam_TextChanged(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select id_camp,name_c,place_c,count_c,date_start_c,date_finish_c,comment_c,majer_c from Camps where name_c like '%'+@S+'%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_name_cam.Text);
            adp.Fill(ds, "Camps");
            dataGrid_list_camp.DataSource = ds;
            dataGrid_list_camp.DataMember = "Camps";

        }

        private void txtbox_place_camp_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select id_camp,name_c,place_c,count_c,date_start_c,date_finish_c,comment_c,majer_c from Camps where place_c like '%'+@S+'%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_place_camp.Text);
            adp.Fill(ds, "Camps");
            dataGrid_list_camp.DataSource = ds;
            dataGrid_list_camp.DataMember = "Camps";

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            int x = Convert.ToInt32(dataGrid_list_camp.SelectedCells[0].Value);
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "Delete from Camps where id_camp=@N";
            cmd.Parameters.AddWithValue("@N", x);
            connect();
            cmd.ExecuteNonQuery();
            disconnect();
            display();
            MessageBox.Show("اردو با موفقیت حذف شد");
        }
    }
}
