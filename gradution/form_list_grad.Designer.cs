
namespace gradution
{
    partial class form_list_grad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbox_lname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtbox_codemeli = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtbox_idgrad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dataGrid_list_grad = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new DevComponents.DotNetBar.ButtonX();
            this.btn_back = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_list_grad)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbox_lname);
            this.groupBox1.Controls.Add(this.txtbox_codemeli);
            this.groupBox1.Controls.Add(this.txtbox_idgrad);
            this.groupBox1.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(776, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو بر اساس";
            // 
            // txtbox_lname
            // 
            // 
            // 
            // 
            this.txtbox_lname.Border.Class = "TextBoxBorder";
            this.txtbox_lname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbox_lname.DisabledBackColor = System.Drawing.Color.White;
            this.txtbox_lname.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtbox_lname.Location = new System.Drawing.Point(99, 25);
            this.txtbox_lname.Name = "txtbox_lname";
            this.txtbox_lname.PreventEnterBeep = true;
            this.txtbox_lname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbox_lname.Size = new System.Drawing.Size(161, 26);
            this.txtbox_lname.TabIndex = 2;
            this.txtbox_lname.WatermarkText = "نام خانوادگی را وارد کنید";
            this.txtbox_lname.TextChanged += new System.EventHandler(this.txtbox_lname_TextChanged);
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
            this.txtbox_codemeli.Location = new System.Drawing.Point(323, 25);
            this.txtbox_codemeli.Name = "txtbox_codemeli";
            this.txtbox_codemeli.PreventEnterBeep = true;
            this.txtbox_codemeli.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbox_codemeli.Size = new System.Drawing.Size(147, 26);
            this.txtbox_codemeli.TabIndex = 1;
            this.txtbox_codemeli.WatermarkText = "کدملی را وارد کنید";
            this.txtbox_codemeli.TextChanged += new System.EventHandler(this.txtbox_codemeli_TextChanged);
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
            this.txtbox_idgrad.Location = new System.Drawing.Point(530, 25);
            this.txtbox_idgrad.Name = "txtbox_idgrad";
            this.txtbox_idgrad.PreventEnterBeep = true;
            this.txtbox_idgrad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbox_idgrad.Size = new System.Drawing.Size(147, 26);
            this.txtbox_idgrad.TabIndex = 0;
            this.txtbox_idgrad.WatermarkText = "کد عضویت را وارد کنید";
            this.txtbox_idgrad.TextChanged += new System.EventHandler(this.txtbox_idgrad_TextChanged);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dataGrid_list_grad);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 71);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(776, 320);
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
            this.groupPanel1.TabIndex = 1;
            // 
            // dataGrid_list_grad
            // 
            this.dataGrid_list_grad.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_list_grad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_list_grad.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_list_grad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_list_grad.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGrid_list_grad.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_list_grad.Name = "dataGrid_list_grad";
            this.dataGrid_list_grad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGrid_list_grad.Size = new System.Drawing.Size(770, 314);
            this.dataGrid_list_grad.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_back);
            this.groupBox3.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox3.Location = new System.Drawing.Point(12, 397);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(776, 65);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "عملیات";
            // 
            // btn_delete
            // 
            this.btn_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_delete.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete.Location = new System.Drawing.Point(464, 17);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(252, 38);
            this.btn_delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_back
            // 
            this.btn_back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_back.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_back.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_back.Location = new System.Drawing.Point(43, 17);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(217, 38);
            this.btn_back.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "بازگشت";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // form_list_grad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_list_grad";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست فارغ التحصیلان";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.form_list_grad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_list_grad)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbox_idgrad;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbox_codemeli;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbox_lname;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGrid_list_grad;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.ButtonX btn_back;
        private DevComponents.DotNetBar.ButtonX btn_delete;
    }
}