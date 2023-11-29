
namespace gradution
{
    partial class form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_register_grad = new DevComponents.DotNetBar.ButtonX();
            this.button_log_grad = new DevComponents.DotNetBar.ButtonX();
            this.button_log_manage = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(166))))));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 475);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_register_grad
            // 
            this.button_register_grad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_register_grad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_register_grad.Image = ((System.Drawing.Image)(resources.GetObject("button_register_grad.Image")));
            this.button_register_grad.Location = new System.Drawing.Point(176, 213);
            this.button_register_grad.Name = "button_register_grad";
            this.button_register_grad.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.button_register_grad.Size = new System.Drawing.Size(186, 55);
            this.button_register_grad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_register_grad.TabIndex = 1;
            this.button_register_grad.Click += new System.EventHandler(this.button_register_grad_Click);
            // 
            // button_log_grad
            // 
            this.button_log_grad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_log_grad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_log_grad.Image = ((System.Drawing.Image)(resources.GetObject("button_log_grad.Image")));
            this.button_log_grad.Location = new System.Drawing.Point(177, 285);
            this.button_log_grad.Name = "button_log_grad";
            this.button_log_grad.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(3);
            this.button_log_grad.Size = new System.Drawing.Size(184, 55);
            this.button_log_grad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_log_grad.TabIndex = 2;
            this.button_log_grad.Click += new System.EventHandler(this.button_log_grad_Click);
            // 
            // button_log_manage
            // 
            this.button_log_manage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_log_manage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_log_manage.Image = ((System.Drawing.Image)(resources.GetObject("button_log_manage.Image")));
            this.button_log_manage.Location = new System.Drawing.Point(177, 362);
            this.button_log_manage.Name = "button_log_manage";
            this.button_log_manage.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.button_log_manage.Size = new System.Drawing.Size(184, 55);
            this.button_log_manage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_log_manage.TabIndex = 3;
            this.button_log_manage.Click += new System.EventHandler(this.button_log_manage_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 475);
            this.Controls.Add(this.button_log_manage);
            this.Controls.Add(this.button_log_grad);
            this.Controls.Add(this.button_register_grad);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انجمن فارغ التحصیلان ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX button_register_grad;
        private DevComponents.DotNetBar.ButtonX button_log_grad;
        private DevComponents.DotNetBar.ButtonX button_log_manage;
    }
}

