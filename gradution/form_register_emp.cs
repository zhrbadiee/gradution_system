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
    public partial class form_register_emp : Form
    {
        public form_register_emp()
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
            if (txtbox_codemeli.Text == "" || txtbox_fname.Text == "" || txtbox_lname.Text == "" ||
                txtbox_faname.Text == "" || dateTimeInput_birth.Text == "" || txtbox_shnumber.Text == "" || txtbox_phon.Text == "" ||
                txtbox_mobile.Text == "" || richTextBox_address.Text == "" || comboBox_study.Text == "" || txtbox_majer.Text == "" ||
                txtbox_semat.Text == "")
            {
                MessageBox.Show("اطلاعات خواسته شده (ستاره دار) وارد کنید");
            }
            if (pictureBox.Image == null)
            {
                MessageBox.Show("تصویری انتخاب نکرده اید");
                return;
            }
            else
            {
                connect();
                byte[] ar = File.ReadAllBytes(pictureBox.ImageLocation);
                SqlCommand cmd = new SqlCommand("insert into Oganizer(codemeli_e,fname_e,lname_e,fathername_e,bdate_e,shnumber_e,status_e,phon_e,mobile_e,address_e,study_e,majer_e,semat_e,Pic_e)values(@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l,@m,@n,@p)", con);
                cmd.Parameters.AddWithValue("@b", txtbox_codemeli.Text);
                cmd.Parameters.AddWithValue("@c", txtbox_fname.Text);
                cmd.Parameters.AddWithValue("@d", txtbox_lname.Text);
                cmd.Parameters.AddWithValue("@e", txtbox_faname.Text);
                cmd.Parameters.AddWithValue("@f", dateTimeInput_birth.Text);
                cmd.Parameters.AddWithValue("@g", txtbox_shnumber.Text);
                cmd.Parameters.AddWithValue("@h", comboBox_status.Text);
                cmd.Parameters.AddWithValue("@i", txtbox_phon.Text);
                cmd.Parameters.AddWithValue("@j", txtbox_mobile.Text);
                cmd.Parameters.AddWithValue("@k", richTextBox_address.Text);
                cmd.Parameters.AddWithValue("@l", comboBox_study.Text);
                cmd.Parameters.AddWithValue("@m", txtbox_majer.Text);
                cmd.Parameters.AddWithValue("@n", txtbox_semat.Text);
                cmd.Parameters.AddWithValue("@p", SqlDbType.VarBinary).Value = ar;
                cmd.ExecuteNonQuery();
                disconnect();
                MessageBox.Show("ثبت نام انجام شد");

                txtbox_codemeli.Text = txtbox_fname.Text = txtbox_lname.Text = "";
                txtbox_faname.Text = dateTimeInput_birth.Text = txtbox_shnumber.Text = comboBox_status.Text = "";
                txtbox_phon.Text = txtbox_mobile.Text = richTextBox_address.Text = comboBox_study.Text = "";
                txtbox_majer.Text = txtbox_semat.Text = "";
                pictureBox.Image = null;

            }

        }

        private void btn_openpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Pictures(*.*)|*.hpg;*.bmp;*.png;*.gif";
            op.ShowDialog();
            pictureBox.ImageLocation = op.FileName;
        }

        private void btn_deletepic_Click(object sender, EventArgs e)
        {
            pictureBox.ImageLocation = null;

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
