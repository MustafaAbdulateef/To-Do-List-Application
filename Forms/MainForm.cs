using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using CustomControls.RJControls;

namespace Mustafa_Abdulateef_To_Do_List_Application
{
    public partial class MainForm : Form
    {
        private Stack<Command> undoStack = new Stack<Command>();
        private Stack<Command> redoStack = new Stack<Command>();
        private Timer searchTimer;
        private const int SearchDelay = 300; // milliseconds
        private bool hasUnsavedChanges = false;

        public MainForm()
        {
            InitializeComponent();

            // Add event handlers for search box
            rjTextBoxSearch.TextChanged += RjTextBoxSearch_TextChanged;
            rjTextBoxSearch.KeyPress += RjTextBoxSearch_KeyPress;

            // Initialize the search timer
            searchTimer = new Timer();
            searchTimer.Interval = SearchDelay;
            searchTimer.Tick += SearchTimer_Tick;

            // Set up control layout
            FLP.Dock = DockStyle.Fill;
            rjTextBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Add resize event handler
            this.Resize += MainForm_Resize;

            // Load to-do items on startup
            this.Load += MainForm_Load;
            this.FormClosing += MainForm_FormClosing;

            // Add click event handler for the add new button
            rjButtonAddNew.Click += RjButtonAddNew_Click;

            // Add click event handler for the save button
            rjButtonSave.Click += SaveButton_Click;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateUndoRedoButtons();
            LoadTodoItems();
            hasUnsavedChanges = false;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            rjTextBoxSearch.Width = this.ClientSize.Width - 40; // Adjust as needed
        }

        private void RjButtonAddNew_Click(object sender, EventArgs e)
        {
            UC_Display todoItem = new UC_Display();
            todoItem.SetData($"New Task {FLP.Controls.Count + 1}", "Description", DateTime.Now);
            todoItem.DeleteRequested += TodoItem_DeleteRequested;
            todoItem.DataChanged += TodoItem_DataChanged;

            ExecuteCommand(new AddItemCommand(FLP, todoItem));
        }

        private void TodoItem_DeleteRequested(object sender, EventArgs e)
        {
            if (sender is UC_Display item)
            {
                ExecuteCommand(new RemoveItemCommand(FLP, item));
            }
        }

        private void TodoItem_DataChanged(object sender, EventArgs e)
        {
            hasUnsavedChanges = true;
        }

        private void rjButtonClearAll_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to permanently clear your to-do items?", "Confirm Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                ClearAllTodoItems();
            }
        }

        private void ExecuteCommand(Command command)
        {
            command.Execute();
            undoStack.Push(command);
            redoStack.Clear();
            UpdateUndoRedoButtons();
            hasUnsavedChanges = true;
        }

        private void Undo()
        {
            if (undoStack.Count > 0)
            {
                Command command = undoStack.Pop();
                command.Undo();
                redoStack.Push(command);
                UpdateUndoRedoButtons();
                hasUnsavedChanges = true;
            }
        }

        private void Redo()
        {
            if (redoStack.Count > 0)
            {
                Command command = redoStack.Pop();
                command.Execute();
                undoStack.Push(command);
                UpdateUndoRedoButtons();
                hasUnsavedChanges = true;
            }
        }

        private void UpdateUndoRedoButtons()
        {
            rjButtonUndo.Enabled = undoStack.Count > 0;
            rjButtonRedo.Enabled = redoStack.Count > 0;
        }

        private void rjButtonUndo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void rjButtonRedo_Click(object sender, EventArgs e)
        {
            Redo();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Z))
            {
                Undo();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Y) || keyData == (Keys.Control | Keys.Shift | Keys.Z))
            {
                Redo();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void rjButtonCalendar_Click(object sender, EventArgs e)
        {
            CalendarForm calendarForm = new CalendarForm(this);
            calendarForm.ShowDialog();
        }

        public List<TodoItem> GetAllTodoItems()
        {
            return FLP.Controls.OfType<UC_Display>()
                .Select(item => new TodoItem
                {
                    Title = item.Title,
                    Description = item.Description,
                    DueDate = item.DueDate
                })
                .ToList();
        }

        public List<UC_Display> GetToDoItemsForDate(DateTime date)
        {
            return FLP.Controls.OfType<UC_Display>()
                .Where(item => item.DueDate.Date == date.Date)
                .ToList();
        }

        private void RjTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void RjTextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the ding sound
                searchTimer.Stop();
                PerformSearch(rjTextBoxSearch.Texts);
            }
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            PerformSearch(rjTextBoxSearch.Texts);
        }

        private void PerformSearch(string searchText)
        {
            searchText = searchText.Trim().ToLower();

            foreach (Control control in FLP.Controls)
            {
                if (control is UC_Display item)
                {
                    if (string.IsNullOrWhiteSpace(searchText))
                    {
                        item.Visible = true;
                    }
                    else
                    {
                        // Check if the title contains the search text (case-insensitive)
                        bool matchesSearch = item.Title.ToLower().Contains(searchText);
                        item.Visible = matchesSearch;
                    }
                }
            }
        }

        private void LoadTodoItems()
        {
            string filePath = Path.Combine(Application.StartupPath, "todoitems.dat");
            if (File.Exists(filePath))
            {
                try
                {
                    List<TodoItem> items;
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        items = (List<TodoItem>)formatter.Deserialize(fs);
                    }

                    // Clear existing items
                    FLP.Controls.Clear();

                    // Add loaded items to the UI
                    foreach (var item in items)
                    {
                        UC_Display todoItem = new UC_Display();
                        todoItem.SetData(item.Title, item.Description, item.DueDate);
                        todoItem.DeleteRequested += TodoItem_DeleteRequested;
                        todoItem.DataChanged += TodoItem_DataChanged;
                        FLP.Controls.Add(todoItem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading to-do items: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveTodoItems();
            MessageBox.Show("To-do items saved successfully!", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            hasUnsavedChanges = false;
        }

        private void SaveTodoItems()
        {
            List<TodoItem> items = GetAllTodoItems();

            string filePath = Path.Combine(Application.StartupPath, "todoitems.dat");
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, items);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving to-do items: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAllTodoItems()
        {
            FLP.Controls.Clear();
            undoStack.Clear();
            redoStack.Clear();
            UpdateUndoRedoButtons();
            hasUnsavedChanges = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hasUnsavedChanges)
            {
                DialogResult result = MessageBox.Show("You have unsaved changes. Do you want to save before closing?",
                    "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    SaveTodoItems();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void rjButtonSave_Click(object sender, EventArgs e)
        {

        }
    }

    [Serializable]
    public class TodoItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
    }

    public abstract class Command
    {
        public abstract void Execute();
        public abstract void Undo();
    }

    public class AddItemCommand : Command
    {
        private FlowLayoutPanel _flp;
        private UC_Display _item;

        public AddItemCommand(FlowLayoutPanel flp, UC_Display item)
        {
            _flp = flp;
            _item = item;
        }

        public override void Execute()
        {
            _flp.Controls.Add(_item);
            AnimateNewItem(_item);
        }

        public override void Undo()
        {
            _flp.Controls.Remove(_item);
        }

        private void AnimateNewItem(UC_Display item)
        {
            item.BackColor = Color.White;
            Timer timer = new Timer();
            timer.Interval = 20; // Faster interval
            int fadeSteps = 25; // Fewer steps for quicker animation
            int currentStep = 0;

            timer.Tick += (sender, e) =>
            {
                if (currentStep < fadeSteps)
                {
                    int alpha = 255 - (currentStep * 255 / fadeSteps);
                    item.BackColor = Color.FromArgb(alpha, Color.White);
                    currentStep++;
                }
                else
                {
                    item.BackColor = Color.Transparent;
                    timer.Stop();
                    timer.Dispose();
                }
            };

            timer.Start();
        }
    }

    public class RemoveItemCommand : Command
    {
        private FlowLayoutPanel _flp;
        private UC_Display _item;

        public RemoveItemCommand(FlowLayoutPanel flp, UC_Display item)
        {
            _flp = flp;
            _item = item;
        }

        public override void Execute()
        {
            AnimateRemoveItem(_item);
        }

        public override void Undo()
        {
            _flp.Controls.Add(_item);
            AnimateNewItem(_item);
        }

        private void AnimateRemoveItem(UC_Display item)
        {
            Timer timer = new Timer();
            timer.Interval = 20; // Faster interval
            int fadeSteps = 25; // Fewer steps for quicker animation
            int currentStep = 0;

            timer.Tick += (sender, e) =>
            {
                if (currentStep < fadeSteps)
                {
                    int alpha = 255 - (currentStep * 255 / fadeSteps);
                    item.BackColor = Color.FromArgb(alpha, Color.White);
                    currentStep++;
                }
                else
                {
                    _flp.Controls.Remove(item);
                    timer.Stop();
                    timer.Dispose();
                }
            };

            timer.Start();
        }

        private void AnimateNewItem(UC_Display item)
        {
            item.BackColor = Color.White;
            Timer timer = new Timer();
            timer.Interval = 20; // Faster interval
            int fadeSteps = 25; // Fewer steps for quicker animation
            int currentStep = 0;

            timer.Tick += (sender, e) =>
            {
                if (currentStep < fadeSteps)
                {
                    int alpha = 255 - (currentStep * 255 / fadeSteps);
                    item.BackColor = Color.FromArgb(alpha, Color.White);
                    currentStep++;
                }
                else
                {
                    item.BackColor = Color.Transparent;
                    timer.Stop();
                    timer.Dispose();
                }
            };

            timer.Start();
        }
    }
}