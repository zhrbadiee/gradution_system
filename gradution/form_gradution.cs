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
    public partial class form_gradution : Office2007Form
    {
        public form_gradution()
        {
            InitializeComponent();
        }

        private void form_gradution_RightToLeftLayoutChanged(object sender, EventArgs e)
        {

        }

        private void button_editgrad_Click(object sender, EventArgs e)
        {
            new form_info_grd().Show();
        }

        private void button_register_edit_Click(object sender, EventArgs e)
        {
            new form_register_meet().Show();
        }

        private void button_request_meet_Click(object sender, EventArgs e)
        {
            new form_request_meet().Show();
        }

        private void button_putof_meet_Click(object sender, EventArgs e)
        {
            //new form_putof_meet().Show();
        }

        private void button_register_camp_Click(object sender, EventArgs e)
        {
            new form_register_camp().Show();
        }

        private void button_request_camp_Click(object sender, EventArgs e)
        {
            new form_request_camp().Show();
        }

        private void button_register_game_Click(object sender, EventArgs e)
        {
            new form_register_game().Show();
        }

        private void button_request_game_Click(object sender, EventArgs e)
        {
            new form_request_game().Show();
        }

        private void button_skill_Click(object sender, EventArgs e)
        {
            new form_skill_grad().Show();
        }

        private void button_exist_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }
    }
}
