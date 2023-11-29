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
    public partial class form_edit_camp : Form
    {
        public form_edit_camp()
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
        private void btn_search_idcamp_Click(object sender, EventArgs e)
        {
            connect();
            SqlDataReader dr;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Camps where id_camp=@N";
            cmd.Parameters.AddWithValue("@N", txtbox_id_camp.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtbox_name_c.Text = dr["name_c"].ToString();
                combobox_majer_c.Text = dr["majer_c"].ToString();
                txtbox_place_c.Text = dr["place_c"].ToString();
                txtbox_count_c.Text = dr["count_c"].ToString();
                datetime_start_c.Text = dr["date_start_c"].ToString();
                datetime_finish_c.Text = dr["date_finish_c"].ToString();
                richtext_comment_c.Text = dr["comment_c"].ToString();

            }
            else
            {
                txtbox_id_camp.Text = "";
                MessageBox.Show("مشخصاتی بااین کداردو پیدا نشد");
            }
            disconnect();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText="update Camps set name_c='"+txtbox_name_c.Text+ "',majer_c='"+ combobox_majer_c.Text + "',place_c='"+txtbox_place_c.Text+ "',count_c='"+txtbox_count_c.Text+"',date_start_c='"+datetime_start_c.Text+ "',date_finish_c='"+datetime_finish_c.Text+ "',comment_c='"+richtext_comment_c.Text+ "'where id_camp='"+txtbox_id_camp.Text+"'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery(); 
            disconnect();
            MessageBox.Show("ویرایش با موفقیت انجام شد");

            txtbox_id_camp.Text = "";
            txtbox_name_c.Text = "";
            combobox_majer_c.Text = "";
            txtbox_place_c.Text = "";
            txtbox_count_c.Text = "";
            datetime_start_c.Text = "";
            datetime_finish_c.Text = "";
            richtext_comment_c.Text = "";



        }
    }
}
