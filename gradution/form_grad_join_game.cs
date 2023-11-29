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
    public partial class form_grad_join_game : Form
    {
        public form_grad_join_game()
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
            adp.SelectCommand = new SqlCommand("select * from join_game_grad", con);
            adp.Fill(ds, "join_game_grad");
            dataGrid_list_game.DataSource = ds;
            dataGrid_list_game.DataMember = "join_game_grad";

            dataGrid_list_game.Columns[0].HeaderText = "کدمسابقه";
            dataGrid_list_game.Columns[1].HeaderText = "نام مسابقه";
            dataGrid_list_game.Columns[2].HeaderText = "کدعضویت شرکت کننده";
            dataGrid_list_game.Columns[3].HeaderText = "نام شرکت کننده";
            dataGrid_list_game.Columns[4].HeaderText = "نام خانوادگی شرکت کننده";
            dataGrid_list_game.Columns[5].HeaderText = "مکان مسابقه";
            dataGrid_list_game.Columns[6].HeaderText = "تاریخ شروع";
            dataGrid_list_game.Columns[7].HeaderText = "تاریخ پایان";


            dataGrid_list_game.Columns[0].Width = 80;
            dataGrid_list_game.Columns[1].Width = 100;
            dataGrid_list_game.Columns[2].Width = 100;
            dataGrid_list_game.Columns[3].Width = 110;
            dataGrid_list_game.Columns[4].Width = 120;
            dataGrid_list_game.Columns[5].Width = 120;
            dataGrid_list_game.Columns[6].Width = 70;
            dataGrid_list_game.Columns[7].Width = 70;
        }

        private void form_grad_join_game_Load(object sender, EventArgs e)
        {
            display();
        }

        private void txtbox_name_game_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from join_game_grad where name_g like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_name_game.Text);
            adp.Fill(ds, "join_game_grad");
            dataGrid_list_game.DataSource = ds;
            dataGrid_list_game.DataMember = "join_game_grad";
        }

        private void txtbox_idgrad_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from join_game_grad where id_grad like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_idgrad.Text);
            adp.Fill(ds, "join_game_grad");
            dataGrid_list_game.DataSource = ds;
            dataGrid_list_game.DataMember = "join_game_grad";
        }

        private void txtbox_lname_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from join_game_grad where lname like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_lname.Text);
            adp.Fill(ds, "join_game_grad");
            dataGrid_list_game.DataSource = ds;
            dataGrid_list_game.DataMember = "join_game_grad";
        }

        private void txtbox_id_game_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from join_game_grad where id_game like '%' +@S+ '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtbox_id_game.Text);
            adp.Fill(ds, "join_game_grad");
            dataGrid_list_game.DataSource = ds;
            dataGrid_list_game.DataMember = "join_game_grad";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
