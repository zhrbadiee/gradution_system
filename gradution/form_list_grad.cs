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
    public partial class form_list_grad : Form
    {
        public form_list_grad()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        public void connect()
        {

            con = new SqlConnection("Data source=.\\SQLEXPRESS;initial catalog=Graduates's Organize; integrated security = true");
            con.Open();

        }
        public void disconnect()
        {
            con.Close();
        }
        void display()
        {
            connect();
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select id_grad,codemeli,fname,lname,fathername,birth,Shnumber,status,phon,mobile,address,study,majer,gpa from Graduates";
            adp.Fill(ds, "Graduates");
            dataGrid_list_grad.DataSource = ds;
            dataGrid_list_grad.DataMember = "Graduates";

            dataGrid_list_grad.Columns[0].HeaderText = "کدعضویت";
            dataGrid_list_grad.Columns[1].HeaderText = "کدملی";
            dataGrid_list_grad.Columns[2].HeaderText = "نام";
            dataGrid_list_grad.Columns[3].HeaderText = "نام خانوادگی";
            dataGrid_list_grad.Columns[4].HeaderText = "نام پدر";
            dataGrid_list_grad.Columns[5].HeaderText = "تاریخ تولد";
            dataGrid_list_grad.Columns[6].HeaderText = "شماره شناسنامه";
            dataGrid_list_grad.Columns[7].HeaderText = "وضعیت";
            dataGrid_list_grad.Columns[8].HeaderText = "تلفن ثابت";
            dataGrid_list_grad.Columns[9].HeaderText = "تلفن همراه";
            dataGrid_list_grad.Columns[10].HeaderText = "آدرس";
            dataGrid_list_grad.Columns[11].HeaderText = "تحصیلات";
            dataGrid_list_grad.Columns[12].HeaderText = "رشته تحصیلی";
            dataGrid_list_grad.Columns[13].HeaderText = "معدل";



        }

        private void form_list_grad_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbox_idgrad_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select id_grad,codemeli,fname,lname,fathername,birth,Shnumber,status,phon,mobile,address,study,majer,gpa from Graduates where id_grad like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_idgrad.Text);
            adp.Fill(ds, "Graduates");
            dataGrid_list_grad.DataSource = ds;
            dataGrid_list_grad.DataMember = "Graduates";
        }

        private void txtbox_codemeli_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select id_grad,codemeli,fname,lname,fathername,birth,Shnumber,status,phon,mobile,address,study,majer,gpa from Graduates where codemeli like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_codemeli.Text);
            adp.Fill(ds, "Graduates");
            dataGrid_list_grad.DataSource = ds;
            dataGrid_list_grad.DataMember = "Graduates";
        }

        private void txtbox_lname_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select id_grad,codemeli,fname,lname,fathername,birth,Shnumber,status,phon,mobile,address,study,majer,gpa from Graduates where lname like '%'+@S+'%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_lname.Text);
            adp.Fill(ds, "Graduates");
            dataGrid_list_grad.DataSource = ds;
            dataGrid_list_grad.DataMember = "Graduates";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(dataGrid_list_grad.SelectedCells[0].Value);
           
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.CommandText = "Delete from Graduates where id_grad=@N";
            cmd.Parameters.AddWithValue("@N", x);
            connect();
            cmd.ExecuteNonQuery();
            disconnect();
            display();
            MessageBox.Show("فارغ التحصیل با موفقیت حذف شد");
        }
    }
}
