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
    public partial class form_loading : Form
    {
        public form_loading()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 5;

            if(progressBar.Value==100)
            {
                timer.Stop();


                new form_main().ShowDialog();  
                this.Close();
                this.Hide();
            }

        }

        private void form_loading_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
