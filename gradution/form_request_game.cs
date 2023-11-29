﻿using System;
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
    public partial class form_request_game : Form
    {
        public form_request_game()
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

        private void btn_search_idgrad_Click(object sender, EventArgs e)
        {
            connect();
            SqlDataReader dr;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select fname,lname,codemeli from Graduates where id_grad=@N";
            cmd.Parameters.AddWithValue("@N", txtbox_idgrad.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtbox_codemeli.Text = dr["codemeli"].ToString();
                txtbox_fname.Text = dr["fname"].ToString();
                txtbox_lname.Text = dr["lname"].ToString();

            }
            else
            {
                txtbox_idgrad.Text = "";
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
            cmd.CommandText = "Select id_grad,fname,lname from Graduates where codemeli=@N";
            cmd.Parameters.AddWithValue("@N", txtbox_codemeli.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtbox_idgrad.Text = dr["id_grad"].ToString();
                txtbox_fname.Text = dr["fname"].ToString();
                txtbox_lname.Text = dr["lname"].ToString();

            }
            else
            {
                txtbox_codemeli.Text = "";
                MessageBox.Show("مشخصاتی بااین کدملی پیدا نشد");
            }
            disconnect();
        }

        void display()
        {
            connect();
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select id_game,name_g from Game ";
            adp.Fill(ds, "Game");
            datagrid_list_camp.DataSource = ds;
            datagrid_list_camp.DataMember = "Game";

            datagrid_list_camp.Columns[0].HeaderText = "کد مسابقه";
            datagrid_list_camp.Columns[1].HeaderText = "نام مسابقه";
            
           

            datagrid_list_camp.Columns[0].Width = 200;
            datagrid_list_camp.Columns[1].Width = 262;
            

        }

        private void form_request_game_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btn_request_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(datagrid_list_camp.SelectedCells[0].Value);
            int y = Convert.ToInt32(txtbox_idgrad.Text);
            connect();
            SqlDataReader dr;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select GAID, GID  from RequestGame where GAID=@M AND GID=@G ";
            cmd.Parameters.AddWithValue("@M", x);
            cmd.Parameters.AddWithValue("@G", y);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("فارغ التحصیل برای این مسابقه درخواست داده است");

            }
            else
            {
                connect();
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "insert into RequestGame ( GAID, GID)values(@M,@G)";
                cmd.Parameters.AddWithValue("@M", x);
                cmd.Parameters.AddWithValue("@G", y);
                cmd.ExecuteNonQuery();
                disconnect();
                display();
                MessageBox.Show("درخواست فارغ التحصیل در این مسابقه با موفقیت انجام شد");
            }
            disconnect();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
   
}
