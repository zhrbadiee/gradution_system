
namespace gradution
{
    partial class form_record_game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_record_game));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.btn_back = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbox_count_g = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.combobox_majer_g = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtbox_place_g = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.richtext_comment_g = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtbox_name_g = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.datetime_finish_g = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.datetime_start_g = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datetime_finish_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetime_start_g)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_save);
            this.groupBox3.Controls.Add(this.btn_back);
            this.groupBox3.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox3.Location = new System.Drawing.Point(12, 354);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(711, 62);
            this.groupBox3.TabIndex = 12;
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
            this.btn_save.Text = "ذخیره";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbox_count_g);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.combobox_majer_g);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.txtbox_place_g);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.richtext_comment_g);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.txtbox_name_g);
            this.groupBox1.Controls.Add(this.datetime_finish_g);
            this.groupBox1.Controls.Add(this.datetime_start_g);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ثبت مسابقه";
            // 
            // txtbox_count_g
            // 
            // 
            // 
            // 
            this.txtbox_count_g.Border.Class = "TextBoxBorder";
            this.txtbox_count_g.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbox_count_g.Location = new System.Drawing.Point(363, 153);
            this.txtbox_count_g.Name = "txtbox_count_g";
            this.txtbox_count_g.PreventEnterBeep = true;
            this.txtbox_count_g.Size = new System.Drawing.Size(200, 27);
            this.txtbox_count_g.TabIndex = 4;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(602, 157);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(46, 23);
            this.labelX2.TabIndex = 43;
            this.labelX2.Text = "ظرفیت*";
            // 
            // combobox_majer_g
            // 
            this.combobox_majer_g.DisplayMember = "Text";
            this.combobox_majer_g.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_majer_g.FormattingEnabled = true;
            this.combobox_majer_g.ItemHeight = 22;
            this.combobox_majer_g.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4});
            this.combobox_majer_g.Location = new System.Drawing.Point(39, 41);
            this.combobox_majer_g.Name = "combobox_majer_g";
            this.combobox_majer_g.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.combobox_majer_g.Size = new System.Drawing.Size(200, 28);
            this.combobox_majer_g.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.combobox_majer_g.TabIndex = 1;
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
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(232, 45);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(79, 23);
            this.labelX3.TabIndex = 41;
            this.labelX3.Text = "زمینه *";
            // 
            // txtbox_place_g
            // 
            // 
            // 
            // 
            this.txtbox_place_g.Border.Class = "TextBoxBorder";
            this.txtbox_place_g.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbox_place_g.Location = new System.Drawing.Point(363, 206);
            this.txtbox_place_g.Name = "txtbox_place_g";
            this.txtbox_place_g.PreventEnterBeep = true;
            this.txtbox_place_g.Size = new System.Drawing.Size(200, 27);
            this.txtbox_place_g.TabIndex = 5;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(578, 205);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(70, 23);
            this.labelX6.TabIndex = 39;
            this.labelX6.Text = "مکان مسابقه*";
            // 
            // richtext_comment_g
            // 
            // 
            // 
            // 
            this.richtext_comment_g.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richtext_comment_g.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richtext_comment_g.Location = new System.Drawing.Point(181, 261);
            this.richtext_comment_g.Name = "richtext_comment_g";
            this.richtext_comment_g.Rtf = resources.GetString("richtext_comment_g.Rtf");
            this.richtext_comment_g.Size = new System.Drawing.Size(382, 60);
            this.richtext_comment_g.TabIndex = 6;
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
            this.labelX8.Text = "توضیحات اضافی";
            // 
            // txtbox_name_g
            // 
            // 
            // 
            // 
            this.txtbox_name_g.Border.Class = "TextBoxBorder";
            this.txtbox_name_g.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbox_name_g.Location = new System.Drawing.Point(363, 41);
            this.txtbox_name_g.Name = "txtbox_name_g";
            this.txtbox_name_g.PreventEnterBeep = true;
            this.txtbox_name_g.Size = new System.Drawing.Size(200, 27);
            this.txtbox_name_g.TabIndex = 0;
            // 
            // datetime_finish_g
            // 
            // 
            // 
            // 
            this.datetime_finish_g.BackgroundStyle.Class = "DateTimeInputBackground";
            this.datetime_finish_g.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datetime_finish_g.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.datetime_finish_g.ButtonDropDown.Visible = true;
            this.datetime_finish_g.IsPopupCalendarOpen = false;
            this.datetime_finish_g.Location = new System.Drawing.Point(39, 97);
            // 
            // 
            // 
            // 
            // 
            // 
            this.datetime_finish_g.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datetime_finish_g.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.datetime_finish_g.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.datetime_finish_g.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.datetime_finish_g.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.datetime_finish_g.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.datetime_finish_g.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.datetime_finish_g.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.datetime_finish_g.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.datetime_finish_g.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datetime_finish_g.MonthCalendar.DisplayMonth = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.datetime_finish_g.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.datetime_finish_g.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.datetime_finish_g.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.datetime_finish_g.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datetime_finish_g.MonthCalendar.TodayButtonVisible = true;
            this.datetime_finish_g.Name = "datetime_finish_g";
            this.datetime_finish_g.Size = new System.Drawing.Size(200, 27);
            this.datetime_finish_g.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.datetime_finish_g.TabIndex = 3;
            // 
            // datetime_start_g
            // 
            // 
            // 
            // 
            this.datetime_start_g.BackgroundStyle.Class = "DateTimeInputBackground";
            this.datetime_start_g.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datetime_start_g.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.datetime_start_g.ButtonDropDown.Visible = true;
            this.datetime_start_g.IsPopupCalendarOpen = false;
            this.datetime_start_g.Location = new System.Drawing.Point(363, 97);
            // 
            // 
            // 
            // 
            // 
            // 
            this.datetime_start_g.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datetime_start_g.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.datetime_start_g.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.datetime_start_g.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.datetime_start_g.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.datetime_start_g.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.datetime_start_g.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.datetime_start_g.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.datetime_start_g.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.datetime_start_g.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datetime_start_g.MonthCalendar.DisplayMonth = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.datetime_start_g.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.datetime_start_g.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.datetime_start_g.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.datetime_start_g.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datetime_start_g.MonthCalendar.TodayButtonVisible = true;
            this.datetime_start_g.Name = "datetime_start_g";
            this.datetime_start_g.Size = new System.Drawing.Size(200, 27);
            this.datetime_start_g.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.datetime_start_g.TabIndex = 2;
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
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(582, 45);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(66, 23);
            this.labelX1.TabIndex = 24;
            this.labelX1.Text = "نام مسابقه*";
            // 
            // form_record_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 422);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_record_game";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت مسابقه";
            this.TopMost = true;
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datetime_finish_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetime_start_g)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private DevComponents.DotNetBar.ButtonX btn_back;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbox_count_g;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx combobox_majer_g;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbox_place_g;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richtext_comment_g;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbox_name_g;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datetime_finish_g;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datetime_start_g;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}