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
    public partial class form_grad_request_camp : Form
    {
        public form_grad_request_camp()
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
            adp.SelectCommand = new SqlCommand("select * from request_camp_grad", con);
            adp.Fill(ds, "request_camp_grad");
            dataGrid_list_camp.DataSource = ds;
            dataGrid_list_camp.DataMember = "request_camp_grad";

            dataGrid_list_camp.Columns[0].HeaderText = "کداردو";
            dataGrid_list_camp.Columns[1].HeaderText = "نام اردو";
            dataGrid_list_camp.Columns[2].HeaderText = "کدعضویت درخواست دهنده";
            dataGrid_list_camp.Columns[3].HeaderText = "نام درخواست دهنده";
            dataGrid_list_camp.Columns[4].HeaderText = "نام خانوادگی درخواست دهنده";
            dataGrid_list_camp.Columns[5].HeaderText = "مکان اردو";

            dataGrid_list_camp.Columns[0].Width = 80;
            dataGrid_list_camp.Columns[1].Width = 100;
            dataGrid_list_camp.Columns[2].Width = 100;
            dataGrid_list_camp.Columns[3].Width = 110;
            dataGrid_list_camp.Columns[4].Width = 120;
            dataGrid_list_camp.Columns[5].Width = 120;
            
        }

        private void txtbox_id_camp_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from request_camp_grad where id_camp like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_id_camp.Text);
            adp.Fill(ds, "request_camp_grad");
            dataGrid_list_camp.DataSource = ds;
            dataGrid_list_camp.DataMember = "request_camp_grad";
        }

        private void txtbox_name_camp_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from request_camp_grad where name_c like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_name_camp.Text);
            adp.Fill(ds, "request_camp_grad");
            dataGrid_list_camp.DataSource = ds;
            dataGrid_list_camp.DataMember = "request_camp_grad";
        }

        private void txtbox_idgrad_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from request_camp_grad where id_grad like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_idgrad.Text);
            adp.Fill(ds, "request_camp_grad");
            dataGrid_list_camp.DataSource = ds;
            dataGrid_list_camp.DataMember = "request_camp_grad";
        }

        private void txtbox_lname_TextChanged(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from request_camp_grad where lname like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_lname.Text);
            adp.Fill(ds, "request_camp_grad");
            dataGrid_list_camp.DataSource = ds;
            dataGrid_list_camp.DataMember = "request_camp_grad";

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_grad_request_camp_Load(object sender, EventArgs e)
        {
            display();
        }
    }
}
