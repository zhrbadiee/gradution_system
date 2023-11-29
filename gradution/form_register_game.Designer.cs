
namespace gradution
{
    partial class form_register_game
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_register = new DevComponents.DotNetBar.ButtonX();
            this.btn_back = new DevComponents.DotNetBar.ButtonX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.datagrid_list_camp = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbox_fname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtbox_lname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX26 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search_codemeli = new DevComponents.DotNetBar.ButtonX();
            this.btn_search_idgrad = new DevComponents.DotNetBar.ButtonX();
            this.txtbox_codemeli = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtbox_idgrad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_list_camp)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_register);
            this.groupBox4.Controls.Add(this.btn_back);
            this.groupBox4.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox4.Location = new System.Drawing.Point(10, 446);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(513, 60);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "عملیات";
            // 
            // btn_register
            // 
            this.btn_register.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_register.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_register.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_register.Location = new System.Drawing.Point(349, 17);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(147, 38);
            this.btn_register.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_register.TabIndex = 5;
            this.btn_register.Text = "ثبت نام";
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_back
            // 
            this.btn_back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_back.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_back.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_back.Location = new System.Drawing.Point(7, 17);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(110, 38);
            this.btn_back.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "بازگشت";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupPanel1);
            this.groupBox3.Location = new System.Drawing.Point(10, 166);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(513, 276);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "انتخاب مسابقه";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.datagrid_list_camp);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(0, 28);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(513, 248);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 2;
            // 
            // datagrid_list_camp
            // 
            this.datagrid_list_camp.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_list_camp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_list_camp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid_list_camp.GridColor = System.Drawing.Color.DarkGray;
            this.datagrid_list_camp.Location = new System.Drawing.Point(0, 0);
            this.datagrid_list_camp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datagrid_list_camp.Name = "datagrid_list_camp";
            this.datagrid_list_camp.Size = new System.Drawing.Size(507, 242);
            this.datagrid_list_camp.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbox_fname);
            this.groupBox2.Controls.Add(this.txtbox_lname);
            this.groupBox2.Controls.Add(this.labelX15);
            this.groupBox2.Controls.Add(this.labelX26);
            this.groupBox2.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(10, 70);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(513, 95);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مشخصات فارغ التحصیل";
            // 
            // txtbox_fname
            // 
            // 
            // 
            // 
            this.txtbox_fname.Border.Class = "TextBoxBorder";
            this.txtbox_fname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbox_fname.DisabledBackColor = System.Drawing.Color.White;
            this.txtbox_fname.Location = new System.Drawing.Point(289, 43);
            this.txtbox_fname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_fname.Name = "txtbox_fname";
            this.txtbox_fname.PreventEnterBeep = true;
            this.txtbox_fname.Size = new System.Drawing.Size(183, 27);
            this.txtbox_fname.TabIndex = 98;
            // 
            // txtbox_lname
            // 
            // 
            // 
            // 
            this.txtbox_lname.Border.Class = "TextBoxBorder";
            this.txtbox_lname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbox_lname.DisabledBackColor = System.Drawing.Color.White;
            this.txtbox_lname.Location = new System.Drawing.Point(16, 47);
            this.txtbox_lname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_lname.Name = "txtbox_lname";
            this.txtbox_lname.PreventEnterBeep = true;
            this.txtbox_lname.Size = new System.Drawing.Size(183, 27);
            this.txtbox_lname.TabIndex = 99;
            // 
            // labelX15
            // 
            this.labelX15.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX15.Location = new System.Drawing.Point(467, 43);
            this.labelX15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX15.Name = "labelX15";
            this.labelX15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX15.Size = new System.Drawing.Size(33, 29);
            this.labelX15.TabIndex = 101;
            this.labelX15.Text = "نام";
            // 
            // labelX26
            // 
            this.labelX26.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX26.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX26.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX26.Location = new System.Drawing.Point(188, 43);
            this.labelX26.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX26.Name = "labelX26";
            this.labelX26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX26.Size = new System.Drawing.Size(83, 29);
            this.labelX26.TabIndex = 100;
            this.labelX26.Text = "نام خانوادگی";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_search_codemeli);
            this.groupBox1.Controls.Add(this.btn_search_idgrad);
            this.groupBox1.Controls.Add(this.txtbox_codemeli);
            this.groupBox1.Controls.Add(this.txtbox_idgrad);
            this.groupBox1.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(10, -1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(513, 70);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو بر اساس";
            // 
            // btn_search_codemeli
            // 
            this.btn_search_codemeli.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_search_codemeli.BackColor = System.Drawing.Color.Transparent;
            this.btn_search_codemeli.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_search_codemeli.Location = new System.Drawing.Point(41, 26);
            this.btn_search_codemeli.Name = "btn_search_codemeli";
            this.btn_search_codemeli.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_search_codemeli.Size = new System.Drawing.Size(32, 26);
            this.btn_search_codemeli.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_search_codemeli.TabIndex = 111;
            this.btn_search_codemeli.Text = "؟";
            this.btn_search_codemeli.Click += new System.EventHandler(this.btn_search_codemeli_Click);
            // 
            // btn_search_idgrad
            // 
            this.btn_search_idgrad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_search_idgrad.BackColor = System.Drawing.Color.Transparent;
            this.btn_search_idgrad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_search_idgrad.Location = new System.Drawing.Point(289, 26);
            this.btn_search_idgrad.Name = "btn_search_idgrad";
            this.btn_search_idgrad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_search_idgrad.Size = new System.Drawing.Size(32, 26);
            this.btn_search_idgrad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_search_idgrad.TabIndex = 110;
            this.btn_search_idgrad.Text = "؟";
            this.btn_search_idgrad.Click += new System.EventHandler(this.btn_search_idgrad_Click);
            // 
            // txtbox_codemeli
            // 
            // 
            // 
            // 
            this.txtbox_codemeli.Border.Class = "TextBoxBorder";
            this.txtbox_codemeli.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbox_codemeli.DisabledBackColor = System.Drawing.Color.White;
            this.txtbox_codemeli.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtbox_codemeli.Location = new System.Drawing.Point(79, 26);
            this.txtbox_codemeli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_codemeli.Name = "txtbox_codemeli";
            this.txtbox_codemeli.PreventEnterBeep = true;
            this.txtbox_codemeli.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbox_codemeli.Size = new System.Drawing.Size(165, 26);
            this.txtbox_codemeli.TabIndex = 4;
            this.txtbox_codemeli.WatermarkText = "کدملی را وارد کنید";
            // 
            // txtbox_idgrad
            // 
            // 
            // 
            // 
            this.txtbox_idgrad.Border.Class = "TextBoxBorder";
            this.txtbox_idgrad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbox_idgrad.DisabledBackColor = System.Drawing.Color.White;
            this.txtbox_idgrad.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtbox_idgrad.Location = new System.Drawing.Point(328, 26);
            this.txtbox_idgrad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_idgrad.Name = "txtbox_idgrad";
            this.txtbox_idgrad.PreventEnterBeep = true;
            this.txtbox_idgrad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbox_idgrad.Size = new System.Drawing.Size(144, 26);
            this.txtbox_idgrad.TabIndex = 3;
            this.txtbox_idgrad.WatermarkText = "کد عضویت را وارد کنید";
            // 
            // form_register_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 515);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_register_game";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت نام مسابقات";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.form_register_game_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_list_camp)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private DevComponents.DotNetBar.ButtonX btn_register;
        private DevComponents.DotNetBar.ButtonX btn_back;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.DataGridView datagrid_list_camp;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbox_fname;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbox_lname;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX26;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btn_search_codemeli;
        private DevComponents.DotNetBar.ButtonX btn_search_idgrad;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbox_codemeli;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbox_idgrad;
    }
}