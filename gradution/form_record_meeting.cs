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
    public partial class form_record_meeting : Form
    {
        public form_record_meeting()
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
            if(txtbox_name.Text==""||txtbox_teacher.Text==""|| datetime_start.Text==""|| datetime_finish.Text==""||
               combobox_majer.Text==""||txtbox_count_m.Text==""|| comboBox_madrak.Text==""|| richtext_comment.Text=="")
            {
                MessageBox.Show("اطلاعات خواسته شده را(ستاره دار) وارد نمایید");
            }
            else
            {
                connect();
                SqlCommand cmd = new SqlCommand("insert into Meetings (name,major,date_start,date_finish,teacher,count_m,madrak,comment)values(@a,@b,@c,@d,@e,@f,@g,@h)", con);
                cmd.Parameters.AddWithValue("@a", txtbox_name.Text);
                cmd.Parameters.AddWithValue("@b", combobox_majer.Text);
                cmd.Parameters.AddWithValue("@c", datetime_start.Text);
                cmd.Parameters.AddWithValue("@d", datetime_finish.Text);
                cmd.Parameters.AddWithValue("@e", txtbox_teacher.Text);
                cmd.Parameters.AddWithValue("@f", txtbox_count_m.Text);
                cmd.Parameters.AddWithValue("@g", comboBox_madrak.Text);
                cmd.Parameters.AddWithValue("@h", richtext_comment.Text);

                cmd.ExecuteNonQuery();
                disconnect();
                MessageBox.Show("دوره با موفقیت ثبت شد");
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
