using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gradution
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        private void ribbonBarMergeContainer1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_register_grad_Click(object sender, EventArgs e)
        {
            new form_registergrad().Show();
            
        }

        private void button_log_grad_Click(object sender, EventArgs e)
        {
            new form_login_grad().Show();
        }

        private void button_log_manage_Click(object sender, EventArgs e)
        {
            new form_login_admin().Show();
        }
    }
}
