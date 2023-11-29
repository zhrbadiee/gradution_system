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
    public partial class form_edit_game : Form
    {
        public form_edit_game()
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
        private void btn_search_idgame_Click(object sender, EventArgs e)
        {
            connect();
            SqlDataReader dr;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Game where id_game=@N";
            cmd.Parameters.AddWithValue("@N", txtbox_id_game.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtbox_name_g.Text = dr["name_g"].ToString();
                combobox_majer_g.Text = dr["majer_g"].ToString();
                txtbox_place_g.Text = dr["place_g"].ToString();
                txtbox_count_g.Text = dr["count_g"].ToString();
                datetime_start_g.Text = dr["date_start_g"].ToString();
                datetime_finish_g.Text = dr["date_finish_g"].ToString();
                richtext_comment_g.Text = dr["comment_g"].ToString();

            }
            else
            {
                txtbox_id_game.Text = "";
                MessageBox.Show("مشخصاتی بااین کد مسابقه پیدا نشد");
            }
            disconnect();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Game set name_g='" + txtbox_name_g.Text + "',majer_g='" + combobox_majer_g.Text + "',place_g='" + txtbox_place_g.Text + "',count_g='" + txtbox_count_g.Text + "',date_start_g='" + datetime_start_g.Text + "',date_finish_g='" + datetime_finish_g.Text + "',comment_g='" + richtext_comment_g.Text + "'where id_game='" + txtbox_id_game.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            disconnect();
            MessageBox.Show("ویرایش با موفقیت انجام شد");

            txtbox_id_game.Text = "";
            txtbox_name_g.Text = "";
            combobox_majer_g.Text = "";
            txtbox_place_g.Text = "";
            txtbox_count_g.Text = "";
            datetime_start_g.Text = "";
            datetime_finish_g.Text = "";
            richtext_comment_g.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
