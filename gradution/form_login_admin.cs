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
    public partial class form_login_admin : Form
    {
        public form_login_admin()
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
        private void button_login_Click(object sender, EventArgs e)
        {
            if(txt_uname.Text=="" || txt_uname.Text=="")
            {
                MessageBox.Show("نام کاربری یا رمزعبور را وارد کنید");
            }
            else
            {
                connect();
                int i = 0;
                cmd = new SqlCommand("select count(*) from Oganizer id_emp where id_emp=@UName AND codemeli_e=@Password", con);
                cmd.Parameters.AddWithValue("@Uname", txt_uname.Text);
                cmd.Parameters.AddWithValue("@Password", txt_pass.Text);
                
                i = (int)cmd.ExecuteScalar();
                disconnect();
                if (i > 0)
                {
                    new form_manage().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
                }

            }
            
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }
    }
}
