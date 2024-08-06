using System;
using System.Drawing;
using System.Windows.Forms;
using CustomControls.RJControls;

namespace Mustafa_Abdulateef_To_Do_List_Application
{
    public partial class UC_Display : UserControl
    {
        public string Title
        {
            get { return rjTextBoxTitle.Texts; }
            set { rjTextBoxTitle.Texts = value; }
        }

        public string Description
        {
            get { return rjTextBoxDescription.Texts; }
            set { rjTextBoxDescription.Texts = value; }
        }

        public DateTime DueDate
        {
            get { return dateTimePicker.Value; }
            set { dateTimePicker.Value = value; }
        }

        public event EventHandler DeleteRequested;
        public event EventHandler DataChanged;

        public UC_Display()
        {
            InitializeComponent();

            // Add event handlers for data changes
            rjTextBoxTitle.TextChanged += (s, e) => DataChanged?.Invoke(this, EventArgs.Empty);
            rjTextBoxDescription.TextChanged += (s, e) => DataChanged?.Invoke(this, EventArgs.Empty);
            dateTimePicker.ValueChanged += (s, e) => DataChanged?.Invoke(this, EventArgs.Empty);

            // Add click event handler for the delete button
            rjButtonDel.Click += RjButtonDel_Click;
        }

        public void SetData(string title, string description, DateTime dueDate)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
        }

        private void RjButtonDel_Click(object sender, EventArgs e)
        {
            DeleteRequested?.Invoke(this, EventArgs.Empty);
        }

        // Remove unnecessary methods and event handlers
        private void pnlPenson_Click(object sender, EventArgs e)
        {
            if (pnlPenson.Location.X <= 2)
            {
                for (int i = 0; i < 150; i += 2)
                {
                    pnlPenson.Location = new Point(i, 0);
                }
            }
            else
            {
                for (int i = 70; i > 0; i -= 2)
                {
                    pnlPenson.Location = new Point(i, 0);
                }
            }
        }

        private void rjButtonDel_Click_1(object sender, EventArgs e)
        {

        }
    }
}