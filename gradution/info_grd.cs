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
    public partial class form_info_grd : Form
    {
        public form_info_grd()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        public void connect()
        {

            con = new SqlConnection("Data source=(local);initial catalog=Graduates's Organize; integrated security = true");
            con.Open();

        }
        public void disconnect()
        {
            con.Close();
        }



        void display()
        {

        }

        Image imagebyte(byte[] bytes)
        {
            System.IO.MemoryStream m = new MemoryStream(bytes);
            return Image.FromStream(m);
        }


        private void btn_search_idgrad_Click(object sender, EventArgs e)
        {
            connect();
            SqlDataReader dr;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Graduates  where id_grad=@N";
            cmd.Parameters.AddWithValue("@N", txtbox_id_grad.Text);
            
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtbox_codemeli.Text = dr["codemeli"].ToString();
                txtbox_fname.Text = dr["fname"].ToString();
                txtbox_lname.Text = dr["lname"].ToString();
                txtbox_faname.Text = dr["fathername"].ToString();
                dateTimeInput_birth.Text = dr["birth"].ToString();
                txtbox_shnumber.Text = dr["Shnumber"].ToString();
                comboBox_status.Text = dr["status"].ToString();
                txtbox_phon.Text = dr["phon"].ToString();
                txtbox_mobile.Text = dr["mobile"].ToString();
                richTextBox_address.Text = dr["address"].ToString();
                comboBox_study.Text = dr["study"].ToString();
                txtbox_majer.Text = dr["majer"].ToString();
                txtbox_gpa.Text = dr["gpa"].ToString();
                //pictureBox.Image = imagebyte((byte[])dr[15]);

            }
            else
            {
                txtbox_id_grad.Text = "";
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
            cmd.CommandText = "select * from Graduates  where codemeli=@N";
            cmd.Parameters.AddWithValue("@N", txtbox_codemeli.Text);

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtbox_id_grad.Text = dr["id_grad"].ToString();
                txtbox_fname.Text = dr["fname"].ToString();
                txtbox_lname.Text = dr["lname"].ToString();
                txtbox_faname.Text = dr["fathername"].ToString();
                dateTimeInput_birth.Text = dr["birth"].ToString();
                txtbox_shnumber.Text = dr["Shnumber"].ToString();
                comboBox_status.Text = dr["status"].ToString();
                txtbox_phon.Text = dr["phon"].ToString();
                txtbox_mobile.Text = dr["mobile"].ToString();
                richTextBox_address.Text = dr["address"].ToString();
                comboBox_study.Text = dr["study"].ToString();
                txtbox_majer.Text = dr["majer"].ToString();
                txtbox_gpa.Text = dr["gpa"].ToString();
                //pictureBox.Image = imagebyte((byte[])dr[15]);

            }
            else
            {
                txtbox_id_grad.Text = "";
                MessageBox.Show("مشخصاتی بااین کدملی پیدا نشد");
            }
            disconnect();
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

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

       
    }
}
