using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace gradution
{
    public partial class form_manage : Office2007Form
    {
        public form_manage()
        {
            InitializeComponent();
        }

        private void ribbonBar11_ItemClick(object sender, EventArgs e)
        {

        }

        private void button_register_grad_Click(object sender, EventArgs e)
        {
            new form_registergrad().Show();
        }

        private void button_edit_grad_Click(object sender, EventArgs e)
        {
            new form_info_grd().Show();
        }

        private void button_list_grad_Click(object sender, EventArgs e)
        {
            new form_list_grad().Show();
        }

        private void button_record_meet_Click(object sender, EventArgs e)
        {
            new form_record_meeting().Show();
        }

        private void button_edit_meet_Click(object sender, EventArgs e)
        {
            new form_edit_meet().Show();
        }

        private void ribbonBar4_ItemClick(object sender, EventArgs e)
        {

        }

        private void button_list_meet_Click(object sender, EventArgs e)
        {
            new form_list_mett().Show();
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            new form_record_camp().Show();
        }

        private void button_edit_camp_Click(object sender, EventArgs e)
        {
            new form_edit_camp().Show();
        }

        private void button_list_camp_Click(object sender, EventArgs e)
        {
            new form_list_camp().Show();
        }

        private void button_record_game_Click(object sender, EventArgs e)
        {
            new form_record_game().Show();
        }

        private void button_edit_game_Click(object sender, EventArgs e)
        {
            new form_edit_game().Show();
        }

        private void button_list_game_Click(object sender, EventArgs e)
        {
            new form_list_game().Show();
        }

        private void button_grad_join_meet_Click(object sender, EventArgs e)
        {
            new form_grad_join_meet().Show();
        }

        private void button_grad_join_camp_Click(object sender, EventArgs e)
        {
            new form_grad_join_camp().Show();
        }

        private void button_grad_join_game_Click(object sender, EventArgs e)
        {
            new form_grad_join_game().Show();
        }

        private void button_grad_request_meet_Click(object sender, EventArgs e)
        {
            new form_grad_request_meet().Show();
        }

        private void button_grad_request_camp_Click(object sender, EventArgs e)
        {
            new form_grad_request_camp().Show();
        }

        private void button_grad_request_game_Click(object sender, EventArgs e)
        {
            new form_grad_request_game().Show();
        }

        private void button_register_emp_Click(object sender, EventArgs e)
        {
            new form_register_emp().Show();
        }

        private void button_edit_emp_Click(object sender, EventArgs e)
        {
            new form_edit_emp().Show();
        }

        private void button_list_emp_Click(object sender, EventArgs e)
        {
            new form_list_emp().Show();
        }

        private void button_register_meet_Click(object sender, EventArgs e)
        {
            new form_register_meet().Show();
        }

        private void button_register_camp_Click(object sender, EventArgs e)
        {
            new form_register_camp().Show();
        }

        private void button_register_game_Click(object sender, EventArgs e)
        {
            new form_register_game().Show();
        }

        private void button_exist_Click(object sender, EventArgs e)
        {
            
            this.Close();
            this.Hide();
        }
    }
}
