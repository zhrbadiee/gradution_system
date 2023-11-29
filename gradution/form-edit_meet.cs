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
using System.IO;


namespace gradution
{
    public partial class form_edit_meet : Form
    {
        public form_edit_meet()
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

        private void btn_search_idmett_Click(object sender, EventArgs e)
        {
            connect();
            SqlDataReader dr;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Meetings  where id_meeting=@N";
            cmd.Parameters.AddWithValue("@N", txtbox_id_meeting.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtbox_name.Text = dr["name"].ToString();
                combobox_majer.Text = dr["major"].ToString();
                datetime_start.Text = dr["date_start"].ToString();
                datetime_finish.Text = dr["date_finish"].ToString();
                txtbox_teacher.Text = dr["teacher"].ToString();
                txtbox_count_m.Text = dr["count_m"].ToString();
                comboBox_madrak.Text = dr["madrak"].ToString();
                richtext_comment.Text = dr["comment"].ToString();
               
            }
            else
            {
                txtbox_id_meeting.Text = "";
                MessageBox.Show("مشخصاتی بااین کددوره پیدا نشد");
            }
            disconnect();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Meetings set name='" + txtbox_name.Text + "',major='" + combobox_majer.Text + "',teacher='" + txtbox_teacher.Text + "',count_m='" + txtbox_count_m.Text + "',date_start='" + datetime_start.Text + "',date_finish='" + datetime_finish.Text + "',comment='" + richtext_comment.Text + "',madrak='"+comboBox_madrak.Text+ "'where id_meeting='" + txtbox_id_meeting.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            disconnect();
            MessageBox.Show("ویرایش با موفقیت انجام شد");

            txtbox_id_meeting.Text = "";
            txtbox_name.Text = "";
            combobox_majer.Text = "";
            txtbox_teacher.Text = "";
            comboBox_madrak.Text = "";
            txtbox_count_m.Text = "";
            datetime_start.Text = "";
            datetime_finish.Text = "";
            richtext_comment.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_edit_meet_Load(object sender, EventArgs e)
        {

        }
    }
}
