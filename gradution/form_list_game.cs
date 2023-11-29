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
    public partial class form_list_game : Form
    {
        public form_list_game()
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
            adp.SelectCommand.CommandText = "Select id_game,name_g,count_g,date_start_g,date_finish_g,place_g,comment_g,majer_g from Game";
            adp.Fill(ds, "Game");
            dataGrid_list_game.DataSource = ds;
            dataGrid_list_game.DataMember = "Game";

            dataGrid_list_game.Columns[0].HeaderText = "کداردو";
            dataGrid_list_game.Columns[1].HeaderText = "نام اردو";
            dataGrid_list_game.Columns[2].HeaderText = "ظرفیت";
            dataGrid_list_game.Columns[3].HeaderText = "تاریخ شروع";
            dataGrid_list_game.Columns[4].HeaderText = "تاریخ پایان";
            dataGrid_list_game.Columns[5].HeaderText = "مکان";
            dataGrid_list_game.Columns[6].HeaderText = "توضیحات";
            dataGrid_list_game.Columns[7].HeaderText = "زمینه";

            dataGrid_list_game.Columns[0].Width = 50;
            dataGrid_list_game.Columns[1].Width = 110;
            dataGrid_list_game.Columns[2].Width = 50;
            dataGrid_list_game.Columns[5].Width = 150;
            dataGrid_list_game.Columns[6].Width = 155;
            dataGrid_list_game.Columns[7].Width = 62;

        }

        private void form_list_game_Load(object sender, EventArgs e)
        {
            display();
        }

        private void txtbox_id_game_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select id_game,name_g,count_g,date_start_g,date_finish_g,place_g,comment_g,majer_g from Game  where id_game like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_id_game.Text);
            adp.Fill(ds, "Game");
            dataGrid_list_game.DataSource = ds;
            dataGrid_list_game.DataMember = "Game";
        }

        private void txtbox_name_game_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select id_game,name_g,count_g,date_start_g,date_finish_g,place_g,comment_g,majer_g from Game  where name_g like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_name_game.Text);
            adp.Fill(ds, "Game");
            dataGrid_list_game.DataSource = ds;
            dataGrid_list_game.DataMember = "Game";
        }

        private void txtbox_place_game_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select id_game,name_g,count_g,date_start_g,date_finish_g,place_g,comment_g,majer_g from Game  where place_g like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_place_game.Text);
            adp.Fill(ds, "Game");
            dataGrid_list_game.DataSource = ds;
            dataGrid_list_game.DataMember = "Game";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(dataGrid_list_game.SelectedCells[0].Value);
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "Delete from Game where id_game=@N";
            cmd.Parameters.AddWithValue("@N", x);
            connect();
            cmd.ExecuteNonQuery();
            disconnect();
            display();
            MessageBox.Show("مسابقه با موفقیت حذف شد");
        }
    }
}
