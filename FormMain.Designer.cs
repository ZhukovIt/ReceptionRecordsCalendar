
namespace ReceptionRecordsCalendar
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpgFirstTask = new System.Windows.Forms.TabPage();
            this.numUDMinColumnWidth = new System.Windows.Forms.NumericUpDown();
            this.btnFixMinColumnWidth = new System.Windows.Forms.Button();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteDay = new System.Windows.Forms.Button();
            this.btnAddNewDay = new System.Windows.Forms.Button();
            this.tpgSecondTask = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxAdditionalInfo = new System.Windows.Forms.TextBox();
            this.chkBoxShowAdditionalInfo = new System.Windows.Forms.CheckBox();
            this.tpgThirdTask = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDayGroupingVariants = new System.Windows.Forms.ComboBox();
            this.chkBoxDayGroupIsEnabled = new System.Windows.Forms.CheckBox();
            this.calendar = new System.Windows.Forms.Calendar.Calendar();
            this.tpgTests = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpgFirstTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMinColumnWidth)).BeginInit();
            this.tpgSecondTask.SuspendLayout();
            this.tpgThirdTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 99);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpgFirstTask);
            this.tabControl1.Controls.Add(this.tpgSecondTask);
            this.tabControl1.Controls.Add(this.tpgThirdTask);
            this.tabControl1.Controls.Add(this.tpgTests);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(997, 99);
            this.tabControl1.TabIndex = 0;
            // 
            // tpgFirstTask
            // 
            this.tpgFirstTask.Controls.Add(this.numUDMinColumnWidth);
            this.tpgFirstTask.Controls.Add(this.btnFixMinColumnWidth);
            this.tpgFirstTask.Controls.Add(this.ss);
            this.tpgFirstTask.Controls.Add(this.label1);
            this.tpgFirstTask.Controls.Add(this.btnDeleteDay);
            this.tpgFirstTask.Controls.Add(this.btnAddNewDay);
            this.tpgFirstTask.Location = new System.Drawing.Point(4, 22);
            this.tpgFirstTask.Name = "tpgFirstTask";
            this.tpgFirstTask.Padding = new System.Windows.Forms.Padding(3);
            this.tpgFirstTask.Size = new System.Drawing.Size(989, 73);
            this.tpgFirstTask.TabIndex = 0;
            this.tpgFirstTask.Text = "Управление данными для задачи №1";
            this.tpgFirstTask.UseVisualStyleBackColor = true;
            // 
            // numUDMinColumnWidth
            // 
            this.numUDMinColumnWidth.Location = new System.Drawing.Point(506, 16);
            this.numUDMinColumnWidth.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numUDMinColumnWidth.Name = "numUDMinColumnWidth";
            this.numUDMinColumnWidth.Size = new System.Drawing.Size(161, 20);
            this.numUDMinColumnWidth.TabIndex = 11;
            // 
            // btnFixMinColumnWidth
            // 
            this.btnFixMinColumnWidth.Location = new System.Drawing.Point(698, 12);
            this.btnFixMinColumnWidth.Name = "btnFixMinColumnWidth";
            this.btnFixMinColumnWidth.Size = new System.Drawing.Size(283, 23);
            this.btnFixMinColumnWidth.TabIndex = 10;
            this.btnFixMinColumnWidth.Text = "Зафиксировать минимальную ширину колонки";
            this.btnFixMinColumnWidth.UseVisualStyleBackColor = true;
            this.btnFixMinColumnWidth.Click += new System.EventHandler(this.btnFixMinColumnWidth_Click);
            // 
            // ss
            // 
            this.ss.Location = new System.Drawing.Point(3, 48);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(983, 22);
            this.ss.TabIndex = 8;
            this.ss.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Минимальная ширина колонки";
            // 
            // btnDeleteDay
            // 
            this.btnDeleteDay.Location = new System.Drawing.Point(171, 11);
            this.btnDeleteDay.Name = "btnDeleteDay";
            this.btnDeleteDay.Size = new System.Drawing.Size(121, 23);
            this.btnDeleteDay.TabIndex = 4;
            this.btnDeleteDay.Text = "Удалить день";
            this.btnDeleteDay.UseVisualStyleBackColor = true;
            this.btnDeleteDay.Click += new System.EventHandler(this.btnDeleteDay_Click);
            // 
            // btnAddNewDay
            // 
            this.btnAddNewDay.Location = new System.Drawing.Point(12, 11);
            this.btnAddNewDay.Name = "btnAddNewDay";
            this.btnAddNewDay.Size = new System.Drawing.Size(121, 23);
            this.btnAddNewDay.TabIndex = 5;
            this.btnAddNewDay.Text = "Добавить день";
            this.btnAddNewDay.UseVisualStyleBackColor = true;
            this.btnAddNewDay.Click += new System.EventHandler(this.btnAddNewDay_Click);
            // 
            // tpgSecondTask
            // 
            this.tpgSecondTask.Controls.Add(this.label2);
            this.tpgSecondTask.Controls.Add(this.tBoxAdditionalInfo);
            this.tpgSecondTask.Controls.Add(this.chkBoxShowAdditionalInfo);
            this.tpgSecondTask.Location = new System.Drawing.Point(4, 22);
            this.tpgSecondTask.Name = "tpgSecondTask";
            this.tpgSecondTask.Padding = new System.Windows.Forms.Padding(3);
            this.tpgSecondTask.Size = new System.Drawing.Size(989, 73);
            this.tpgSecondTask.TabIndex = 1;
            this.tpgSecondTask.Text = "Управление данными для задачи №2";
            this.tpgSecondTask.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Текст дополнительной информации в заголовке дня";
            // 
            // tBoxAdditionalInfo
            // 
            this.tBoxAdditionalInfo.Location = new System.Drawing.Point(751, 30);
            this.tBoxAdditionalInfo.Name = "tBoxAdditionalInfo";
            this.tBoxAdditionalInfo.Size = new System.Drawing.Size(217, 20);
            this.tBoxAdditionalInfo.TabIndex = 1;
            this.tBoxAdditionalInfo.TextChanged += new System.EventHandler(this.tBoxAdditionalInfo_TextChanged);
            // 
            // chkBoxShowAdditionalInfo
            // 
            this.chkBoxShowAdditionalInfo.AutoSize = true;
            this.chkBoxShowAdditionalInfo.Location = new System.Drawing.Point(23, 30);
            this.chkBoxShowAdditionalInfo.Name = "chkBoxShowAdditionalInfo";
            this.chkBoxShowAdditionalInfo.Size = new System.Drawing.Size(417, 17);
            this.chkBoxShowAdditionalInfo.TabIndex = 0;
            this.chkBoxShowAdditionalInfo.Text = "Активировать отображение дополнительной информации в заголовках дней";
            this.chkBoxShowAdditionalInfo.UseVisualStyleBackColor = true;
            this.chkBoxShowAdditionalInfo.CheckedChanged += new System.EventHandler(this.chkBoxShowAdditionalInfo_CheckedChanged);
            // 
            // tpgThirdTask
            // 
            this.tpgThirdTask.Controls.Add(this.label3);
            this.tpgThirdTask.Controls.Add(this.cmbDayGroupingVariants);
            this.tpgThirdTask.Controls.Add(this.chkBoxDayGroupIsEnabled);
            this.tpgThirdTask.Location = new System.Drawing.Point(4, 22);
            this.tpgThirdTask.Name = "tpgThirdTask";
            this.tpgThirdTask.Size = new System.Drawing.Size(989, 73);
            this.tpgThirdTask.TabIndex = 2;
            this.tpgThirdTask.Text = "Управление данными для задачи №3";
            this.tpgThirdTask.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Варианты группировки";
            // 
            // cmbDayGroupingVariants
            // 
            this.cmbDayGroupingVariants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDayGroupingVariants.FormattingEnabled = true;
            this.cmbDayGroupingVariants.Items.AddRange(new object[] {
            "Чётные / нечётные дни",
            "По три дня в группе",
            "С использованием очень длинных имён"});
            this.cmbDayGroupingVariants.Location = new System.Drawing.Point(346, 25);
            this.cmbDayGroupingVariants.Name = "cmbDayGroupingVariants";
            this.cmbDayGroupingVariants.Size = new System.Drawing.Size(223, 21);
            this.cmbDayGroupingVariants.TabIndex = 1;
            this.cmbDayGroupingVariants.SelectedIndexChanged += new System.EventHandler(this.cmbDayGroupingVariants_SelectedIndexChanged);
            // 
            // chkBoxDayGroupIsEnabled
            // 
            this.chkBoxDayGroupIsEnabled.AutoSize = true;
            this.chkBoxDayGroupIsEnabled.Location = new System.Drawing.Point(16, 27);
            this.chkBoxDayGroupIsEnabled.Name = "chkBoxDayGroupIsEnabled";
            this.chkBoxDayGroupIsEnabled.Size = new System.Drawing.Size(143, 17);
            this.chkBoxDayGroupIsEnabled.TabIndex = 0;
            this.chkBoxDayGroupIsEnabled.Text = "Группировка включена";
            this.chkBoxDayGroupIsEnabled.UseVisualStyleBackColor = true;
            this.chkBoxDayGroupIsEnabled.CheckedChanged += new System.EventHandler(this.chkBoxDayGroupIsEnabled_CheckedChanged);
            // 
            // calendar
            // 
            this.calendar.CloseSideBarImage = ((System.Drawing.Image)(resources.GetObject("calendar.CloseSideBarImage")));
            this.calendar.DayHeaderFormatExpandMode = "dddd";
            this.calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.calendar.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[0];
            this.calendar.Location = new System.Drawing.Point(0, 0);
            this.calendar.MaximumFullDays = 80;
            this.calendar.Name = "calendar";
            this.calendar.OpenSideBarImage = ((System.Drawing.Image)(resources.GetObject("calendar.OpenSideBarImage")));
            this.calendar.Size = new System.Drawing.Size(997, 501);
            this.calendar.TabIndex = 4;
            this.calendar.Text = "calendar1";
            this.calendar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.calendar_MouseClick);
            this.calendar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.calendar_MouseDown);
            this.calendar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.calendar_MouseMove);
            // 
            // tpgTests
            // 
            this.tpgTests.Location = new System.Drawing.Point(4, 22);
            this.tpgTests.Name = "tpgTests";
            this.tpgTests.Size = new System.Drawing.Size(989, 73);
            this.tpgTests.TabIndex = 3;
            this.tpgTests.Text = "Тестовая вкладка";
            this.tpgTests.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 600);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Календарь записей на приём";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpgFirstTask.ResumeLayout(false);
            this.tpgFirstTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMinColumnWidth)).EndInit();
            this.tpgSecondTask.ResumeLayout(false);
            this.tpgSecondTask.PerformLayout();
            this.tpgThirdTask.ResumeLayout(false);
            this.tpgThirdTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpgFirstTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteDay;
        private System.Windows.Forms.Button btnAddNewDay;
        private System.Windows.Forms.TabPage tpgSecondTask;
        private System.Windows.Forms.TabPage tpgThirdTask;
        private System.Windows.Forms.CheckBox chkBoxShowAdditionalInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxAdditionalInfo;
        private System.Windows.Forms.CheckBox chkBoxDayGroupIsEnabled;
        private System.Windows.Forms.ComboBox cmbDayGroupingVariants;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.Calendar.Calendar calendar;
        private System.Windows.Forms.Button btnFixMinColumnWidth;
        private System.Windows.Forms.NumericUpDown numUDMinColumnWidth;
        private System.Windows.Forms.TabPage tpgTests;
    }
}

