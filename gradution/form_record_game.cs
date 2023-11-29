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
    public partial class form_record_game : Form
    {
        public form_record_game()
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


        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txtbox_name_g.Text == "" || txtbox_place_g.Text == "" || datetime_start_g.Text == "" || datetime_finish_g.Text == "" ||
               combobox_majer_g.Text == "" || txtbox_count_g.Text == "" )
            {
                MessageBox.Show("اطلاعات خواسته شده را(ستاره دار) وارد نمایید");
            }
            else
            {
                connect();
                SqlCommand cmd = new SqlCommand("insert into Game (name_g,majer_g,place_g,count_g,date_start_g,date_finish_g,comment_g)values(@a,@b,@c,@d,@e,@f,@g)", con);
                cmd.Parameters.AddWithValue("@a", txtbox_name_g.Text);
                cmd.Parameters.AddWithValue("@b", combobox_majer_g.Text);
                cmd.Parameters.AddWithValue("@c", txtbox_place_g.Text);
                cmd.Parameters.AddWithValue("@d", txtbox_count_g.Text);
                cmd.Parameters.AddWithValue("@e", datetime_start_g.Text);
                cmd.Parameters.AddWithValue("@f", datetime_finish_g.Text);
                cmd.Parameters.AddWithValue("@g", richtext_comment_g.Text);
                cmd.ExecuteNonQuery();
                disconnect();
                MessageBox.Show("مسابقه با موفقیت ثبت شد");
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
