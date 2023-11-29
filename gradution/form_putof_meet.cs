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
    public partial class form_putof_meet : Form
    {
        public form_putof_meet()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        public void connect()
        {

            con = new SqlConnection("Data source=.\\SQLEXPRESS;initial catalog=Graduates's Organize; integrated security = true");
            con.Open();

        }
        public void disconnect()
        {
            con.Close();
        }

        private void form_putof_meet_Load(object sender, EventArgs e)
        {
            display();
        }

        void display()
        {
            connect();
            
            //DataTable dt = new DataTable();
            DataSet dt = new DataSet();
            cmd = new SqlCommand("list_meeting_register_grad", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p;
            p = cmd.Parameters.AddWithValue("@id_grad", txtbox_idgrad.Text);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            datagrid_list_meet.DataSource = dt;
            datagrid_list_meet.DataBindings.Clear();
            //datagrid_list_meet.DataBindings.Add("list_meeting_register_grad");
            


            //DataSet ds = new DataSet();
            //SqlDataAdapter adp = new SqlDataAdapter();
            //adp.SelectCommand = new SqlCommand("list_meeting_register_grad", con);
            //adp.Fill(ds, "list_meeting_register_grad ");
            //datagrid_list_meet.DataSource = ds;
            //datagrid_list_meet.DataMember = "list_meeting_register_grad";

            //datagrid_list_meet.Columns[0].HeaderText = "کددوره";
            //datagrid_list_meet.Columns[1].HeaderText = "نام دوره";
            //datagrid_list_meet.Columns[2].HeaderText = "مدرس";
            //datagrid_list_meet.Columns[3].HeaderText = "ظرفیت";
            //datagrid_list_meet.Columns[4].HeaderText = "تاریخ شروع";
            //datagrid_list_meet.Columns[5].HeaderText = "تاریخ پایان";
            //datagrid_list_meet.Columns[6].HeaderText = "مدرک";
            //datagrid_list_meet.Columns[7].HeaderText = "توضیحات";
            //datagrid_list_meet.Columns[8].HeaderText = "زمینه";

            //datagrid_list_meet.Columns[0].Width = 50;
            //datagrid_list_meet.Columns[1].Width = 70;
            //datagrid_list_meet.Columns[2].Width = 100;
            //datagrid_list_meet.Columns[3].Width = 50;
            //datagrid_list_meet.Columns[6].Width = 150;
            //datagrid_list_meet.Columns[7].Width = 65;

        }
        private void btn_search_idgrad_Click(object sender, EventArgs e)
        {
            connect();
            SqlDataReader dr;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select fname,lname,codemeli from Graduates where id_grad=@N";
            cmd.Parameters.AddWithValue("@N", txtbox_idgrad.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtbox_codemeli.Text = dr["codemeli"].ToString();
                txtbox_fname.Text = dr["fname"].ToString();
                txtbox_lname.Text = dr["lname"].ToString();
                display();

            }
            else
            {
                txtbox_idgrad.Text = "";
                MessageBox.Show("مشخصاتی بااین کدعضویت پیدا نشد");
            }
            disconnect();
        }

        private void btn_search_codemeli_Click(object sender, EventArgs e)
        {
            connect();
            SqlDataReader dr;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select id_grad,fname,lname from Graduates where codemeli=@N";
            cmd.Parameters.AddWithValue("@N", txtbox_codemeli.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtbox_idgrad.Text = dr["id_grad"].ToString();
                txtbox_fname.Text = dr["fname"].ToString();
                txtbox_lname.Text = dr["lname"].ToString();
                display();
            }
            else
            {
                txtbox_codemeli.Text = "";
                MessageBox.Show("مشخصاتی بااین کدملی پیدا نشد");
            }
            disconnect();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

        }
    }
}
