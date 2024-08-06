
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Mustafa_Abdulateef_To_Do_List_Application
{
    public partial class CalendarForm : Form
    {
        private MainForm mainForm;
        private DateTime currentDate;

        // Define colors
        private Color primaryColor = Color.FromArgb(255, 140, 0);  // Dark Orange
        private Color secondaryColor = Color.FromArgb(255, 200, 100);  // Light Orange
        private Color textColor = Color.White;
        private Color todayColor = Color.FromArgb(255, 69, 0);  // Red-Orange
        private Color lineColor = Color.White;
        private Dictionary<DateTime, List<TodoItem>> tasksByDate;

        public CalendarForm(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
            tasksByDate = new Dictionary<DateTime, List<TodoItem>>();
            currentDate = DateTime.Now;

            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ShowInTaskbar = false;
            this.MinimumSize = new Size(600, 500);  // Set minimum size
            this.StartPosition = FormStartPosition.Manual;

            // Enable double buffering
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            // Enable double buffering for the TableLayoutPanel
            typeof(TableLayoutPanel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, calendarTable, new object[] { true });

            InitializeCalendar();
            LoadTasksIntoCalendar();
        }

        private void InitializeCalendar()
        {
            // Set form background color
            this.BackColor = primaryColor;

            // Style the month/year label
            monthYearLabel.ForeColor = textColor;
            monthYearLabel.Font = new Font("Arial", 24, FontStyle.Bold);

            // Style the navigation buttons
            StyleButton(prevMonthButton);
            StyleButton(nextMonthButton);
        }

        private void StyleButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = secondaryColor;
            button.ForeColor = textColor;
            button.Font = new Font("Arial", 14, FontStyle.Bold);
            button.Size = new Size(50, 50);
        }

        private void DisplayCurrentMonth()
        {
            calendarTable.SuspendLayout();
            calendarTable.Controls.Clear();
            monthYearLabel.Text = currentDate.ToString("MMMM yyyy");

            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
            int startDayOfWeek = (int)firstDayOfMonth.DayOfWeek;

            // Add day of week headers
            string[] daysOfWeek = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            for (int i = 0; i < 7; i++)
            {
                Label dayLabel = new Label
                {
                    Text = daysOfWeek[i],
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = textColor,
                    BackColor = secondaryColor
                };
                calendarTable.Controls.Add(dayLabel, i, 0);
            }

            for (int i = 0; i < startDayOfWeek; i++)
            {
                calendarTable.Controls.Add(new Label() { BackColor = primaryColor }, i, 1);
            }

            for (int day = 1; day <= daysInMonth; day++)
            {
                Panel dayPanel = new Panel
                {
                    Dock = DockStyle.Fill,
                    Padding = new Padding(1),
                    BackColor = lineColor
                };

                Label dayLabel = new Label
                {
                    Text = day.ToString(),
                    Dock = DockStyle.Top,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = textColor,
                    BackColor = primaryColor,
                    Height = 30,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                if (day == DateTime.Now.Day && currentDate.Month == DateTime.Now.Month && currentDate.Year == DateTime.Now.Year)
                {
                    dayLabel.BackColor = todayColor;
                }

                // Create a scrollable panel for tasks
                Panel taskPanel = new Panel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true
                };

                // Add tasks for this day
                DateTime currentDay = new DateTime(currentDate.Year, currentDate.Month, day);
                if (tasksByDate.ContainsKey(currentDay))
                {
                    foreach (var task in tasksByDate[currentDay])
                    {
                        Label taskLabel = new Label
                        {
                            Text = "• " + task.Title,
                            Dock = DockStyle.Top,
                            Font = new Font("Arial", 8),
                            ForeColor = Color.Black,
                            AutoEllipsis = true,
                            Height = 20  // Reduced height for less gap
                        };
                        taskPanel.Controls.Add(taskLabel);
                    }
                }

                dayPanel.Controls.Add(taskPanel);
                dayPanel.Controls.Add(dayLabel); // Add the dayLabel after the taskPanel to position it above the tasks

                dayPanel.Click += (sender, e) => DayPanel_Click(sender, e, day);
                int row = ((day + startDayOfWeek - 1) / 7) + 1;
                int col = (day + startDayOfWeek - 1) % 7;
                calendarTable.Controls.Add(dayPanel, col, row);
            }

            calendarTable.ResumeLayout();
        }

        private void DayPanel_Click(object sender, EventArgs e, int day)
        {
            try
            {
                // Check if the day is valid for the current month and year
                int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
                if (day > 0 && day <= daysInMonth)
                {
                    DateTime selectedDate = new DateTime(currentDate.Year, currentDate.Month, day);
                    UpdateEventList(selectedDate);
                }
                else
                {
                    MessageBox.Show("Invalid date selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Error selecting date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void prevMonthButton_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(-1);
            LoadTasksIntoCalendar();
        }

        private void nextMonthButton_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(1);
            LoadTasksIntoCalendar();
        }

        private void CalendarForm_Resize(object sender, EventArgs e)
        {
            // Adjust controls when the form is resized
            monthYearLabel.Left = (this.ClientSize.Width - monthYearLabel.Width) / 2;
            prevMonthButton.Left = 20;
            nextMonthButton.Left = this.ClientSize.Width - nextMonthButton.Width - 20;

            // Resize and reposition the calendar table
            calendarTable.Width = this.ClientSize.Width - 40;
            calendarTable.Height = this.ClientSize.Height - calendarTable.Top - 20;
        }

        public void UpdateEventList(DateTime date)
        {
            List<TodoItem> items = mainForm.GetAllTodoItems().Where(item => item.DueDate.Date == date.Date).ToList();
            string message = $"To-Do Items for {date.ToShortDateString()}:\n\n";
            if (items.Count == 0)
            {
                message += "No items for this date.";
            }
            else
            {
                foreach (var item in items)
                {
                    message += $"• {item.Title}: {item.Description}\n";
                }
            }
            MessageBox.Show(message, "To-Do Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            PositionCalendarOnTopOfMainForm();
        }

        private void PositionCalendarOnTopOfMainForm()
        {
            if (mainForm != null && !mainForm.IsDisposed)
            {
                this.Location = new Point(mainForm.Location.X, mainForm.Location.Y);
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void LoadTasksIntoCalendar()
        {
            tasksByDate.Clear();
            foreach (var task in mainForm.GetAllTodoItems())
            {
                DateTime date = task.DueDate.Date;
                if (!tasksByDate.ContainsKey(date))
                {
                    tasksByDate[date] = new List<TodoItem>();
                }
                tasksByDate[date].Add(task);
            }
            DisplayCurrentMonth();
        }
    }
}