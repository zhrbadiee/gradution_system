﻿
namespace gradution
{
    partial class form_list_mett
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new DevComponents.DotNetBar.ButtonX();
            this.btn_back = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dataGrid_list_meet = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbox_name_meet = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtbox_id_meet = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox3.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_list_meet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_back);
            this.groupBox3.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox3.Location = new System.Drawing.Point(12, 403);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(776, 65);
            this.groupBox3.TabIndex = 14;
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
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dataGrid_list_meet);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 81);
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
            this.groupPanel1.TabIndex = 13;
            // 
            // dataGrid_list_meet
            // 
            this.dataGrid_list_meet.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_list_meet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_list_meet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_list_meet.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_list_meet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_list_meet.EnableHeadersVisualStyles = false;
            this.dataGrid_list_meet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGrid_list_meet.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_list_meet.Name = "dataGrid_list_meet";
            this.dataGrid_list_meet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_list_meet.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_list_meet.Size = new System.Drawing.Size(770, 314);
            this.dataGrid_list_meet.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbox_name_meet);
            this.groupBox1.Controls.Add(this.txtbox_id_meet);
            this.groupBox1.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(776, 63);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو بر اساس";
            // 
            // txtbox_name_meet
            // 
            // 
            // 
            // 
            this.txtbox_name_meet.Border.Class = "TextBoxBorder";
            this.txtbox_name_meet.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbox_name_meet.DisabledBackColor = System.Drawing.Color.White;
            this.txtbox_name_meet.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtbox_name_meet.Location = new System.Drawing.Point(263, 25);
            this.txtbox_name_meet.Name = "txtbox_name_meet";
            this.txtbox_name_meet.PreventEnterBeep = true;
            this.txtbox_name_meet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbox_name_meet.Size = new System.Drawing.Size(161, 26);
            this.txtbox_name_meet.TabIndex = 1;
            this.txtbox_name_meet.WatermarkText = "نام دوره را وارد کنید";
            this.txtbox_name_meet.TextChanged += new System.EventHandler(this.txtbox_name_meet_TextChanged);
            // 
            // txtbox_id_meet
            // 
            // 
            // 
            // 
            this.txtbox_id_meet.Border.Class = "TextBoxBorder";
            this.txtbox_id_meet.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbox_id_meet.DisabledBackColor = System.Drawing.Color.White;
            this.txtbox_id_meet.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtbox_id_meet.Location = new System.Drawing.Point(530, 25);
            this.txtbox_id_meet.Name = "txtbox_id_meet";
            this.txtbox_id_meet.PreventEnterBeep = true;
            this.txtbox_id_meet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbox_id_meet.Size = new System.Drawing.Size(147, 26);
            this.txtbox_id_meet.TabIndex = 0;
            this.txtbox_id_meet.WatermarkText = "کد دوره را وارد کنید";
            this.txtbox_id_meet.TextChanged += new System.EventHandler(this.txtbox_id_meet_TextChanged);
            // 
            // form_list_mett
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 478);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_list_mett";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست دوره ها";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.form_list_mett_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_list_meet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.ButtonX btn_delete;
        private DevComponents.DotNetBar.ButtonX btn_back;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGrid_list_meet;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbox_name_meet;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbox_id_meet;
    }
}