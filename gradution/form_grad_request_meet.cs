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
    public partial class form_grad_request_meet : Form
    {
        public form_grad_request_meet()
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
            adp.SelectCommand = new SqlCommand("select * from request_meet_grad", con);
            adp.Fill(ds, "request_meet_grad");
            dataGrid_list_meet.DataSource = ds;
            dataGrid_list_meet.DataMember = "request_meet_grad";

            dataGrid_list_meet.Columns[0].HeaderText = "کددوره";
            dataGrid_list_meet.Columns[1].HeaderText = "نام دوره";
            dataGrid_list_meet.Columns[2].HeaderText = "کدعضویت شرکت کننده";
            dataGrid_list_meet.Columns[3].HeaderText = "نام شرکت کننده";
            dataGrid_list_meet.Columns[4].HeaderText = "نام خانوادگی شرکت کننده";
            dataGrid_list_meet.Columns[5].HeaderText = "مدرس دوره";

            dataGrid_list_meet.Columns[0].Width = 80;
            dataGrid_list_meet.Columns[1].Width = 100;
            dataGrid_list_meet.Columns[2].Width = 100;
            dataGrid_list_meet.Columns[3].Width = 110;
            dataGrid_list_meet.Columns[4].Width = 120;
            dataGrid_list_meet.Columns[5].Width = 120;
           
        }

        private void txtbox_id_meet_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from request_meet_grad where id_meeting like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_id_meet.Text);
            adp.Fill(ds, "request_meet_grad");
            dataGrid_list_meet.DataSource = ds;
            dataGrid_list_meet.DataMember = "request_meet_grad";
        }

        private void txtbox_name_meet_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from request_meet_grad where name like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_name_meet.Text);
            adp.Fill(ds, "request_meet_grad");
            dataGrid_list_meet.DataSource = ds;
            dataGrid_list_meet.DataMember = "request_meet_grad";

        }

        private void txtbox_idgrad_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from request_meet_grad where id_grad like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_idgrad.Text);
            adp.Fill(ds, "request_meet_grad");
            dataGrid_list_meet.DataSource = ds;
            dataGrid_list_meet.DataMember = "request_meet_grad";
        }

        private void txtbox_lname_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from request_meet_grad where lname like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_lname.Text);
            adp.Fill(ds, "request_meet_grad");
            dataGrid_list_meet.DataSource = ds;
            dataGrid_list_meet.DataMember = "request_meet_grad";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_grad_request_meet_Load(object sender, EventArgs e)
        {
            display();
        }
    }
}
