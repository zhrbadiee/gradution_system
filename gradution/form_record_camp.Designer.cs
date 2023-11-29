
namespace gradution
{
    partial class form_record_camp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_record_camp));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbox_count_c = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.richtext_comment_c = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.combobox_majer_c = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.txtbox_place_c = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtbox_name_c = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.datetime_finish_c = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.datetime_start_c = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.btn_back = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datetime_finish_c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetime_start_c)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbox_count_c);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.richtext_comment_c);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.combobox_majer_c);
            this.groupBox1.Controls.Add(this.txtbox_place_c);
            this.groupBox1.Controls.Add(this.txtbox_name_c);
            this.groupBox1.Controls.Add(this.datetime_finish_c);
            this.groupBox1.Controls.Add(this.datetime_start_c);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ثبت اردو";
            // 
            // txtbox_count_c
            // 
            // 
            // 
            // 
            this.txtbox_count_c.Border.Class = "TextBoxBorder";
            this.txtbox_count_c.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbox_count_c.Location = new System.Drawing.Point(363, 210);
            this.txtbox_count_c.Name = "txtbox_count_c";
            this.txtbox_count_c.PreventEnterBeep = true;
            this.txtbox_count_c.Size = new System.Drawing.Size(200, 27);
            this.txtbox_count_c.TabIndex = 5;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(602, 214);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(46, 23);
            this.labelX2.TabIndex = 37;
            this.labelX2.Text = "ظرفیت*";
            // 
            // richtext_comment_c
            // 
            // 
            // 
            // 
            this.richtext_comment_c.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richtext_comment_c.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richtext_comment_c.Location = new System.Drawing.Point(181, 261);
            this.richtext_comment_c.Name = "richtext_comment_c";
            this.richtext_comment_c.Rtf = resources.GetString("richtext_comment_c.Rtf");
            this.richtext_comment_c.Size = new System.Drawing.Size(382, 60);
            this.richtext_comment_c.TabIndex = 6;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(559, 261);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(90, 23);
            this.labelX8.TabIndex = 35;
            this.labelX8.Text = "توضیحات اضافی*";
            // 
            // combobox_majer_c
            // 
            this.combobox_majer_c.DisplayMember = "Text";
            this.combobox_majer_c.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_majer_c.FormattingEnabled = true;
            this.combobox_majer_c.ItemHeight = 22;
            this.combobox_majer_c.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4});
            this.combobox_majer_c.Location = new System.Drawing.Point(363, 152);
            this.combobox_majer_c.Name = "combobox_majer_c";
            this.combobox_majer_c.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.combobox_majer_c.Size = new System.Drawing.Size(200, 28);
            this.combobox_majer_c.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.combobox_majer_c.TabIndex = 4;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "فرهنگی";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "آموزشی";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "ورزشی";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "تفریحی";
            // 
            // txtbox_place_c
            // 
            // 
            // 
            // 
            this.txtbox_place_c.Border.Class = "TextBoxBorder";
            this.txtbox_place_c.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbox_place_c.Location = new System.Drawing.Point(39, 41);
            this.txtbox_place_c.Name = "txtbox_place_c";
            this.txtbox_place_c.PreventEnterBeep = true;
            this.txtbox_place_c.Size = new System.Drawing.Size(200, 27);
            this.txtbox_place_c.TabIndex = 1;
            // 
            // txtbox_name_c
            // 
            // 
            // 
            // 
            this.txtbox_name_c.Border.Class = "TextBoxBorder";
            this.txtbox_name_c.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbox_name_c.Location = new System.Drawing.Point(363, 41);
            this.txtbox_name_c.Name = "txtbox_name_c";
            this.txtbox_name_c.PreventEnterBeep = true;
            this.txtbox_name_c.Size = new System.Drawing.Size(200, 27);
            this.txtbox_name_c.TabIndex = 0;
            // 
            // datetime_finish_c
            // 
            // 
            // 
            // 
            this.datetime_finish_c.BackgroundStyle.Class = "DateTimeInputBackground";
            this.datetime_finish_c.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datetime_finish_c.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.datetime_finish_c.ButtonDropDown.Visible = true;
            this.datetime_finish_c.IsPopupCalendarOpen = false;
            this.datetime_finish_c.Location = new System.Drawing.Point(39, 97);
            // 
            // 
            // 
            // 
            // 
            // 
            this.datetime_finish_c.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datetime_finish_c.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.datetime_finish_c.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.datetime_finish_c.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.datetime_finish_c.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.datetime_finish_c.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.datetime_finish_c.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.datetime_finish_c.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.datetime_finish_c.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.datetime_finish_c.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datetime_finish_c.MonthCalendar.DisplayMonth = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.datetime_finish_c.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.datetime_finish_c.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.datetime_finish_c.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.datetime_finish_c.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datetime_finish_c.MonthCalendar.TodayButtonVisible = true;
            this.datetime_finish_c.Name = "datetime_finish_c";
            this.datetime_finish_c.Size = new System.Drawing.Size(200, 27);
            this.datetime_finish_c.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.datetime_finish_c.TabIndex = 3;
            // 
            // datetime_start_c
            // 
            // 
            // 
            // 
            this.datetime_start_c.BackgroundStyle.Class = "DateTimeInputBackground";
            this.datetime_start_c.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datetime_start_c.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.datetime_start_c.ButtonDropDown.Visible = true;
            this.datetime_start_c.IsPopupCalendarOpen = false;
            this.datetime_start_c.Location = new System.Drawing.Point(363, 97);
            // 
            // 
            // 
            // 
            // 
            // 
            this.datetime_start_c.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datetime_start_c.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.datetime_start_c.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.datetime_start_c.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.datetime_start_c.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.datetime_start_c.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.datetime_start_c.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.datetime_start_c.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.datetime_start_c.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.datetime_start_c.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datetime_start_c.MonthCalendar.DisplayMonth = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.datetime_start_c.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.datetime_start_c.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.datetime_start_c.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.datetime_start_c.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datetime_start_c.MonthCalendar.TodayButtonVisible = true;
            this.datetime_start_c.Name = "datetime_start_c";
            this.datetime_start_c.Size = new System.Drawing.Size(200, 27);
            this.datetime_start_c.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.datetime_start_c.TabIndex = 2;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(245, 45);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(66, 23);
            this.labelX6.TabIndex = 29;
            this.labelX6.Text = "مکان اردو*";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(245, 101);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(66, 23);
            this.labelX5.TabIndex = 28;
            this.labelX5.Text = "تاریخ پایان*";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(582, 101);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(66, 23);
            this.labelX4.TabIndex = 27;
            this.labelX4.Text = "تاریخ شروع*";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(570, 154);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(79, 23);
            this.labelX3.TabIndex = 26;
            this.labelX3.Text = "زمینه *";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(602, 45);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(46, 23);
            this.labelX1.TabIndex = 24;
            this.labelX1.Text = "نام اردو*";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_save);
            this.groupBox3.Controls.Add(this.btn_back);
            this.groupBox3.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox3.Location = new System.Drawing.Point(12, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(711, 62);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "عملیات";
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_save.Location = new System.Drawing.Point(393, 17);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(286, 38);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "ثبت";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_back
            // 
            this.btn_back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_back.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_back.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_back.Location = new System.Drawing.Point(6, 16);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(263, 38);
            this.btn_back.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "بازگشت";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // form_record_camp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 425);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_record_camp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت اردو";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datetime_finish_c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetime_start_c)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richtext_comment_c;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.ComboBoxEx combobox_majer_c;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbox_place_c;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datetime_finish_c;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datetime_start_c;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbox_count_c;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbox_name_c;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private DevComponents.DotNetBar.ButtonX btn_back;
    }
}