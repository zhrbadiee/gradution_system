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
    public partial class form_list_mett : Form
    {
        public form_list_mett()
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
            adp.SelectCommand.CommandText = "Select id_meeting,name,teacher,count_m,date_start,date_finish,comment,madrak,major from Meetings ";
            adp.Fill(ds, "Meetings");
            dataGrid_list_meet.DataSource = ds;
            dataGrid_list_meet.DataMember = "Meetings";

            dataGrid_list_meet.Columns[0].HeaderText = "کددوره";
            dataGrid_list_meet.Columns[1].HeaderText = "نام دوره";
            dataGrid_list_meet.Columns[2].HeaderText = "مدرس";
            dataGrid_list_meet.Columns[3].HeaderText = "ظرفیت";
            dataGrid_list_meet.Columns[4].HeaderText = "تاریخ شروع";
            dataGrid_list_meet.Columns[5].HeaderText = "تاریخ پایان";
            dataGrid_list_meet.Columns[6].HeaderText = "توضیحات";
            dataGrid_list_meet.Columns[7].HeaderText = "مدرک";
            dataGrid_list_meet.Columns[8].HeaderText = "زمینه";

            dataGrid_list_meet.Columns[0].Width = 50;
            dataGrid_list_meet.Columns[1].Width = 100;
            dataGrid_list_meet.Columns[2].Width = 130;
            dataGrid_list_meet.Columns[3].Width = 50;
            dataGrid_list_meet.Columns[5].Width = 150;
            dataGrid_list_meet.Columns[6].Width = 60;
            dataGrid_list_meet.Columns[7].Width = 60;
        }

        private void txtbox_id_meet_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select id_meeting,name,teacher,count_m,date_start,date_finish,comment,madrak,major from Meetings where id_meeting like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_id_meet.Text);
            adp.Fill(ds, "Meetings");
            dataGrid_list_meet.DataSource = ds;
            dataGrid_list_meet.DataMember = "Meetings";
        }

        private void form_list_mett_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           
            int x = Convert.ToInt32(dataGrid_list_meet.SelectedCells[0].Value);
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "Delete from Meetings where id_meeting=@N";
            cmd.Parameters.AddWithValue("@N", x);
            connect();
            cmd.ExecuteNonQuery();
            disconnect();
            display();
            MessageBox.Show("دوره با موفقیت حذف شد");
        }

        private void txtbox_name_meet_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select id_meeting,name,teacher,count_m,date_start,date_finish,comment,madrak,major from Meetings where name like '%'+@S+'%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_name_meet.Text);
            adp.Fill(ds, "Meetings");
            dataGrid_list_meet.DataSource = ds;
            dataGrid_list_meet.DataMember = "Meetings";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
