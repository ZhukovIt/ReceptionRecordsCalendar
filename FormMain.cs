using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;

namespace ReceptionRecordsCalendar
{
    public partial class FormMain : Form
    {
        private ToolStripStatusLabel _visibleHorizontalScroll;
        private ToolStripStatusLabel _visibleVerticalScroll;
        private ToolStripStatusLabel _minColumnWidth;
        private int _minColumnWidthValue;
        private static string _fileSettingsPath = Application.StartupPath + "/Settings.txt";
        //---------------------------------------------------
        public FormMain()
        {
            InitializeComponent();
            calendar.OpenCloseSideBarButtonOpenOnStart = true;
            cmbDayGroupingVariants.SelectedIndex = 0;
            CheckAndReadMinColumnWidth();
            calendar.MinColumnWidth = _minColumnWidthValue;
            calendar.Size = new Size(calendar.Size.Width + 1, calendar.Size.Height);
            calendar.MaximumViewDays = 70;

            _visibleHorizontalScroll = new ToolStripStatusLabel();
            _visibleVerticalScroll = new ToolStripStatusLabel();
            _minColumnWidth = new ToolStripStatusLabel();

            ss.Items.Add(_minColumnWidth);
            ss.Items.Add(_visibleVerticalScroll);
            ss.Items.Add(_visibleHorizontalScroll);

            Timer timer = new Timer() { Interval = 100 };
            timer.Tick += timer_Tick;
            timer.Start();
        }
        //---------------------------------------------------
        private void CheckAndReadMinColumnWidth()
        {
            if (File.Exists(_fileSettingsPath))
            {
                if (int.TryParse(File.ReadAllText(_fileSettingsPath), out int parsedMinColumnWidth))
                {
                    _minColumnWidthValue = parsedMinColumnWidth;
                    numUDMinColumnWidth.Value = _minColumnWidthValue;
                    return;
                }
                else
                {
                    File.Delete(_fileSettingsPath);
                }
            }

            _minColumnWidthValue = 200;
            numUDMinColumnWidth.Value = _minColumnWidthValue;
            WriteMinColumnWidth();
        }
        //---------------------------------------------------
        private void WriteMinColumnWidth()
        {
            File.WriteAllText(_fileSettingsPath, numUDMinColumnWidth.Value.ToString());
        }
        //---------------------------------------------------
        private void btnFixMinColumnWidth_Click(object sender, EventArgs e)
        {
            string text;
            string caption;
            MessageBoxButtons buttons;
            MessageBoxIcon icon;

            if (numUDMinColumnWidth.Value == _minColumnWidthValue)
            {
                text = "Значение минимальной ширины колонки не изменилось!";
                caption = "Измените значение минимальной ширины колонки";
                buttons = MessageBoxButtons.OK;
                icon = MessageBoxIcon.Information;
            }
            else
            {
                text = "После фиксирования значения минимальной ширины колонки приложение будет закрыто!\r\n" +
                "После нового запуска программы изменения будут зафиксированы!\r\n" +
                "Выполнить фиксацию значения минимальной ширины колонки?";
                caption = "Нужно принять решение!";
                buttons = MessageBoxButtons.YesNo;
                icon = MessageBoxIcon.Question;
            }

            DialogResult res = MessageBox.Show(text, caption, buttons, icon);
            if (res == DialogResult.Yes)
            {
                WriteMinColumnWidth();
                Close();
            }
        }
        //---------------------------------------------------
        private void btnAddNewDay_Click(object sender, EventArgs e)
        {
            if (calendar.Days.Length >= calendar.MaximumViewDays)
                return;
            calendar.SetViewRange(DateTime.Now, DateTime.Now.AddDays(calendar.Days.Length));
            tBoxAdditionalInfo_TextChanged(tBoxAdditionalInfo, null);
            cmbDayGroupingVariants_SelectedIndexChanged(cmbDayGroupingVariants, null);
            calendar.HorizontalScroll.Value = 0;
            calendar.DayUnitsOffset = 0;
        }
        //---------------------------------------------------
        private void btnDeleteDay_Click(object sender, EventArgs e)
        {
            int countDays = calendar.Days.Length - 2;
            if (countDays < 0)
                countDays = 0;
            calendar.SetViewRange(DateTime.Now, DateTime.Now.AddDays(countDays));
            tBoxAdditionalInfo_TextChanged(tBoxAdditionalInfo, null);
            cmbDayGroupingVariants_SelectedIndexChanged(cmbDayGroupingVariants, null);
            calendar.HorizontalScroll.Value = 0;
            calendar.DayUnitsOffset = 0;
        }
        //---------------------------------------------------
        private void chkBoxShowAdditionalInfo_CheckedChanged(object sender, EventArgs e)
        {
            calendar.ShowAdditionalInfoOfDayHeader = chkBoxShowAdditionalInfo.Checked;
            ReloadItems();
        }
        //---------------------------------------------------
        private void tBoxAdditionalInfo_TextChanged(object sender, EventArgs e)
        {
            foreach (CalendarDay day in calendar.Days)
            {
                day.AdditionalInformation = tBoxAdditionalInfo.Text;
            }
            ReloadItems();
        }
        //---------------------------------------------------
        private void ReloadItems()
        {
            calendar.Renderer.PerformLayout();
            calendar.Invalidate();
        }
        //---------------------------------------------------
        private void chkBoxDayGroupIsEnabled_CheckedChanged(object sender, EventArgs e)
        {
            calendar.DayGroupingType = chkBoxDayGroupIsEnabled.Checked ? DayGroupingTypes.Auto : DayGroupingTypes.None;
            if (chkBoxDayGroupIsEnabled.Checked)
                calendar.CreateDayGroups();
            ReloadItems();
        }
        //---------------------------------------------------
        private void cmbDayGroupingVariants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDayGroupingVariants.SelectedItem == null)
                return;

            switch (cmbDayGroupingVariants.SelectedItem)
            {
                case "Чётные / нечётные дни":
                    FillDaysGroupValueAsEvenOrOddDay();
                    break;
                case "По три дня в группе":
                    FillDaysGroupValueAsCountDayInGroup(3);
                    break;
                case "С использованием очень длинных имён":
                    FillDaysGroupValueAsLongestNames();
                    break;
                default:
                    throw new NotImplementedException($"Вариант {cmbDayGroupingVariants.SelectedItem} не поддерживается!");
            }
            chkBoxDayGroupIsEnabled_CheckedChanged(chkBoxDayGroupIsEnabled, null);
        }
        //---------------------------------------------------
        private void FillDaysGroupValueAsLongestNames()
        {
            Random randomizer = new Random();

            foreach (CalendarDay day in calendar.Days)
            {
                day.GroupValue = $"ОченОченьОченьОченьДлинноеИмя: {randomizer.Next(1, 10)}";
            }
        }
        //---------------------------------------------------
        private void FillDaysGroupValueAsEvenOrOddDay()
        {
            foreach (CalendarDay day in calendar.Days)
            {
                if (day.Date.Day % 2 == 0)
                {
                    day.GroupValue = "Чётные дни";
                }
                else
                {
                    day.GroupValue = "Нечётные дни";
                }

            }
        }
        //---------------------------------------------------
        private void FillDaysGroupValueAsCountDayInGroup(int _CountDaysInGroup)
        {
            foreach (CalendarDay day in CalendarCommon.OrderBy(calendar.Days, x => x))
            {
                int groupNumber = day.Date.Subtract(calendar.Days[0].Date.Date).Days / _CountDaysInGroup + 1;
                day.GroupValue = $"{groupNumber} группа";
            }
        }
        //---------------------------------------------------
        private void timer_Tick(object sender, EventArgs e)
        {
            string horizontalScrollVisibility = calendar.HorizontalScroll.Visible ? "Виден" : "Не виден";
            string verticalScrollVisibility = calendar.VerticalScroll.Visible ? "Виден" : "Не виден";

            _visibleHorizontalScroll.Text = $"Гориз скролл: {horizontalScrollVisibility} " +
                $"Min: {calendar.HorizontalScroll.Minimum} Max: {calendar.HorizontalScroll.Maximum} " +
                $"Value: {calendar.HorizontalScroll.Value}  ";
            _visibleVerticalScroll.Text = $"Верт скролл: {verticalScrollVisibility} " +
                $"Min: {calendar.VerticalScroll.Minimum} Max: {calendar.VerticalScroll.Maximum} " +
                $"Value: {calendar.VerticalScroll.Value}       ";
            //_visibleHorizontalScroll.Text = "Кнопка " + (calendar.OpenCloseSideBarButton == null ? "не " : "") + "существует; " +
            //    "Кнопка " + (calendar.OpenCloseSideBarButton.Selected ? "" : "не ") + "выбрана; ";
            _minColumnWidth.Text = $"Условие: мин ширина {calendar.MinColumnWidth} " +
               (calendar.MinColumnWidth < calendar.Days[0].Bounds.Width ? "<" : "=") + $" тек ширина {calendar.Days[0].Bounds.Width}";
        }
        //---------------------------------------------------
        private void calendar_MouseMove(object sender, MouseEventArgs e)
        {
            if (calendar.OpenCloseSideBarButton == null)
                return;

            bool cursorIsHoverButton = calendar.OpenCloseSideBarButton.Bounds.Contains(e.Location);

            Cursor.Current = cursorIsHoverButton ? Cursors.Hand : Cursors.Default;

            if (calendar.OpenCloseSideBarButton.Selected)
            {
                if (cursorIsHoverButton)
                    calendar.ButtonBuilderType = System.Windows.Forms.Calendar.OpenCloseSideBarButton.ButtonBuilderTypes.SelectedHover;
                else
                    calendar.ButtonBuilderType = System.Windows.Forms.Calendar.OpenCloseSideBarButton.ButtonBuilderTypes.SelectedStandart;
            }
            else
            {
                if (cursorIsHoverButton)
                    calendar.ButtonBuilderType = System.Windows.Forms.Calendar.OpenCloseSideBarButton.ButtonBuilderTypes.Hover;
                else
                    calendar.ButtonBuilderType = System.Windows.Forms.Calendar.OpenCloseSideBarButton.ButtonBuilderTypes.Standart;
            }

            calendar.Invalidate();
        }
        //---------------------------------------------------
        private void calendar_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left ||
                calendar.OpenCloseSideBarButton == null ||
                !calendar.OpenCloseSideBarButton.Bounds.Contains(e.Location))
                return;

            Cursor.Current = Cursors.Hand;

            calendar.OpenCloseSideBarButton.SetSelected(!calendar.OpenCloseSideBarButton.Selected);

            if (calendar.OpenCloseSideBarButton.Selected)
                calendar.ButtonBuilderType = System.Windows.Forms.Calendar.OpenCloseSideBarButton.ButtonBuilderTypes.SelectedClick;
            else
                calendar.ButtonBuilderType = System.Windows.Forms.Calendar.OpenCloseSideBarButton.ButtonBuilderTypes.Click;

            calendar.Invalidate();
        }
        //---------------------------------------------------
        private void calendar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left ||
                calendar.OpenCloseSideBarButton == null || 
                !calendar.OpenCloseSideBarButton.Bounds.Contains(e.Location))
                return;

            if (calendar.OpenCloseSideBarButton.Selected)
                calendar.ButtonBuilderType = System.Windows.Forms.Calendar.OpenCloseSideBarButton.ButtonBuilderTypes.SelectedClick;
            else
                calendar.ButtonBuilderType = System.Windows.Forms.Calendar.OpenCloseSideBarButton.ButtonBuilderTypes.Click;

            calendar.Invalidate();
        }
        //---------------------------------------------------
    }
}
