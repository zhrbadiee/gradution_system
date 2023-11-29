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
    public partial class form_record_camp : Form
    {
        public form_record_camp()
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
            if (txtbox_name_c.Text == "" || txtbox_place_c.Text == "" || datetime_start_c.Text == "" || datetime_finish_c.Text == "" ||
               combobox_majer_c.Text == "" || txtbox_count_c.Text == "" || richtext_comment_c.Text == "")
            {
                MessageBox.Show("اطلاعات خواسته شده را(ستاره دار) وارد نمایید");
            }
            else
            {
                connect();
                SqlCommand cmd = new SqlCommand("insert into Camps (name_c,majer_c,place_c,count_c,date_start_c,date_finish_c,comment_c)values(@a,@b,@c,@d,@e,@f,@g)", con);
                cmd.Parameters.AddWithValue("@a", txtbox_name_c.Text);
                cmd.Parameters.AddWithValue("@b", combobox_majer_c.Text);
                cmd.Parameters.AddWithValue("@c", txtbox_place_c.Text);
                cmd.Parameters.AddWithValue("@d", txtbox_count_c.Text);
                cmd.Parameters.AddWithValue("@e", datetime_start_c.Text);
                cmd.Parameters.AddWithValue("@f", datetime_finish_c.Text);
                cmd.Parameters.AddWithValue("@g", richtext_comment_c.Text);
                cmd.ExecuteNonQuery();
                disconnect();
                MessageBox.Show("اردو با موفقیت ثبت شد");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
