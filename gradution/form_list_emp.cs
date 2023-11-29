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
    public partial class form_list_emp : Form
    {
        public form_list_emp()
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
            adp.SelectCommand.CommandText = "Select id_emp,codemeli_e,fname_e,lname_e,fathername_e,bdate_e,shnumber_e,status_e,phon_e,mobile_e,address_e,study_e,majer_e,semat_e from Oganizer";
            adp.Fill(ds, "Oganizer");
            dataGrid_list_emp.DataSource = ds;
            dataGrid_list_emp.DataMember = "Oganizer";

            dataGrid_list_emp.Columns[0].HeaderText = "کدپرسنلی";
            dataGrid_list_emp.Columns[1].HeaderText = "کدملی";
            dataGrid_list_emp.Columns[2].HeaderText = "نام";
            dataGrid_list_emp.Columns[3].HeaderText = "نام خانوادگی";
            dataGrid_list_emp.Columns[4].HeaderText = "نام پدر";
            dataGrid_list_emp.Columns[5].HeaderText = "تاریخ تولد";
            dataGrid_list_emp.Columns[6].HeaderText = "شماره شناسنامه";
            dataGrid_list_emp.Columns[7].HeaderText = "وضعیت";
            dataGrid_list_emp.Columns[8].HeaderText = "تلفن ثابت";
            dataGrid_list_emp.Columns[9].HeaderText = "تلفن همراه";
            dataGrid_list_emp.Columns[10].HeaderText = "آدرس";
            dataGrid_list_emp.Columns[11].HeaderText = "تحصیلات";
            dataGrid_list_emp.Columns[12].HeaderText = "رشته تحصیلی";
            dataGrid_list_emp.Columns[13].HeaderText = "سمت شغلی";


        }
         private void txtbox_id_emp_TextChanged(object sender, EventArgs e)
         {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select id_emp,codemeli_e,fname_e,lname_e,fathername_e,bdate_e,shnumber_e,status_e,phon_e,mobile_e,address_e,study_e,majer_e,semat_e from Oganizer where id_emp like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_id_emp.Text);
            adp.Fill(ds, "Oganizer");
            dataGrid_list_emp.DataSource = ds;
            dataGrid_list_emp.DataMember = "Oganizer";
        }

        private void txtbox_codemeli_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select id_emp,codemeli_e,fname_e,lname_e,fathername_e,bdate_e,shnumber_e,status_e,phon_e,mobile_e,address_e,study_e,majer_e,semat_e from Oganizer where codemeli_e like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_codemeli.Text);
            adp.Fill(ds, "Oganizer");
            dataGrid_list_emp.DataSource = ds;
            dataGrid_list_emp.DataMember = "Oganizer";
        }

        private void txtbox_lname_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select id_emp,codemeli_e,fname_e,lname_e,fathername_e,bdate_e,shnumber_e,status_e,phon_e,mobile_e,address_e,study_e,majer_e,semat_e from Oganizer where lname_e like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_lname.Text);
            adp.Fill(ds, "Oganizer");
            dataGrid_list_emp.DataSource = ds;
            dataGrid_list_emp.DataMember = "Oganizer";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(dataGrid_list_emp.SelectedCells[0].Value);

            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.CommandText = "Delete from Oganizer where id_emp=@N";
            cmd.Parameters.AddWithValue("@N", x);
            connect();
            cmd.ExecuteNonQuery();
            disconnect();
            display();
            MessageBox.Show(" کارمند با موفقیت حذف شد");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_list_emp_Load(object sender, EventArgs e)
        {
            display();
        }
    }
}
