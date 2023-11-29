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
    public partial class form_skill_grad : Form
    {
        public form_skill_grad()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd ;
        public void connect()
        {

            con = new SqlConnection("Data source=.\\SQLEXPRESS;initial catalog=Graduates's Organize; integrated security = true");
            con.Open();

        }
        public void disconnect()
        {
            con.Close();
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
            if(richbox_skils.Text==""|| txtbox_idgrad.Text==""||txtbox_codemeli.Text=="")
            {
                MessageBox.Show("کدعضویت یا کد پرسنلی یا مهارت وارد کنید");
            }
            else
            {
                connect();
                SqlCommand cmd = new SqlCommand("insert  into Skills(GID,nameskill)values(@a,@b)", con);
                cmd.Parameters.AddWithValue("@a", txtbox_idgrad.Text);
                cmd.Parameters.AddWithValue("@b", richbox_skils.Text);
                cmd.ExecuteNonQuery();
                disconnect();
                MessageBox.Show("مهارت فارغ التحصیل ثبت شد");

            }
           
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
