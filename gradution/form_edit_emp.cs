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
    public partial class form_edit_emp : Form
    {
        public form_edit_emp()
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
        Image imagebyte(byte[] bytes)
        {
            System.IO.MemoryStream m = new MemoryStream(bytes);
            return Image.FromStream(m);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Oganizer set fname_e='" + txtbox_fname.Text + "',lname_e='" + txtbox_lname.Text + "',fathername_e='" + txtbox_faname.Text + "',bdate_e='" + dateTimeInput_birth.Text + "',shnumber_e='" + txtbox_shnumber.Text + "',status_e='" + comboBox_status.Text + "',phon_e='" + txtbox_phon.Text + "',mobile_e='" + txtbox_mobile.Text + "',address_e='" + richTextBox_address.Text + "',study_e='" + comboBox_study.Text + "',majer_e='" + txtbox_majer.Text + "',semat_e='" + txtbox_semat.Text + "',codemeli_e='" + txtbox_codemeli.Text + "'where id_emp='" + txtbox_id_emp.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            disconnect();
            MessageBox.Show("ویرایش با موفقیت انجام شد");


            txtbox_id_emp.Text = "";
            txtbox_fname.Text = "";
            txtbox_lname.Text = "";
            txtbox_faname.Text = "";
            dateTimeInput_birth.Text = "";
            txtbox_shnumber.Text = "";
            comboBox_status.Text = "";
            txtbox_phon.Text = "";
            txtbox_mobile.Text = "";
            richTextBox_address.Text = "";
            comboBox_study.Text = "";
            txtbox_majer.Text = "";
            txtbox_semat.Text = "";
        }

        private void btn_search_idemp_Click(object sender, EventArgs e)
        {
            connect();
            SqlDataReader dr;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Oganizer  where id_emp=@N";
            cmd.Parameters.AddWithValue("@N", txtbox_id_emp.Text);

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtbox_codemeli.Text = dr["codemeli_e"].ToString();
                txtbox_fname.Text = dr["fname_e"].ToString();
                txtbox_lname.Text = dr["lname_e"].ToString();
                txtbox_faname.Text = dr["fathername_e"].ToString();
                dateTimeInput_birth.Text = dr["bdate_e"].ToString();
                txtbox_shnumber.Text = dr["shnumber_e"].ToString();
                comboBox_status.Text = dr["status_e"].ToString();
                txtbox_phon.Text = dr["phon_e"].ToString();
                txtbox_mobile.Text = dr["mobile_e"].ToString();
                richTextBox_address.Text = dr["address_e"].ToString();
                comboBox_study.Text = dr["study_e"].ToString();
                txtbox_majer.Text = dr["majer_e"].ToString();
                txtbox_semat.Text = dr["semat_e"].ToString();
                // pictureBox.Image = imagebyte((byte[])dr[15]);

            }
            else
            {
                txtbox_id_emp.Text = "";
                MessageBox.Show("مشخصاتی بااین کدپرسنلی پیدا نشد");
            }
            disconnect();

        }

        private void btn_search_codemeli_Click(object sender, EventArgs e)
        {
            connect();
            SqlDataReader dr;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Oganizer where codemeli_e=@N";
            cmd.Parameters.AddWithValue("@N", txtbox_codemeli.Text);

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtbox_id_emp.Text = dr["id_emp"].ToString();
                txtbox_fname.Text = dr["fname_e"].ToString();
                txtbox_lname.Text = dr["lname_e"].ToString();
                txtbox_faname.Text = dr["fathername_e"].ToString();
                dateTimeInput_birth.Text = dr["bdate_e"].ToString();
                txtbox_shnumber.Text = dr["shnumber_e"].ToString();
                comboBox_status.Text = dr["status_e"].ToString();
                txtbox_phon.Text = dr["phon_e"].ToString();
                txtbox_mobile.Text = dr["mobile_e"].ToString();
                richTextBox_address.Text = dr["address_e"].ToString();
                comboBox_study.Text = dr["study_e"].ToString();
                txtbox_majer.Text = dr["majer_e"].ToString();
                txtbox_semat.Text = dr["semat_e"].ToString();
                // pictureBox.Image = imagebyte((byte[])dr[15]);

            }
            else
            {
                txtbox_id_emp.Text = "";
                MessageBox.Show("مشخصاتی بااین کدملی پیدا نشد");
            }
            disconnect();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
